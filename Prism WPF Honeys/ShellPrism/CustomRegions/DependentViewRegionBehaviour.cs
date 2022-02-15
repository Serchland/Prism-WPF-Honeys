using Prism.Ioc;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.CustomAttribute;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prism_WPF_Honeys.ShellPrism.CustomRegions
{
    public class DependentViewRegionBehaviour : RegionBehavior
    {
        private IContainerExtension _container;
        public const string BehaviourKey = KeyNames.DependentViewRegionBehaviourKey;
        private Dictionary<object, List<DependentViewInfo>> _dependentViewCache = new Dictionary<object, List<DependentViewInfo>>();
        
        public DependentViewRegionBehaviour(IContainerExtension container)
        {
            _container = container;
        }

        protected override void OnAttach()
        {
            Region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged;
        }

        private void ActiveViews_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var dependentViews = new List<DependentViewInfo>();

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var newView in e.NewItems)
                {
                    if (_dependentViewCache.ContainsKey(newView))
                    {
                        dependentViews = _dependentViewCache[newView];
                    }
                    else
                    {
                        var atts = GetCustomAttributes<DependentViewAttribute>(newView.GetType());
                        foreach (var att in atts)
                        {
                            var info = CreateDependentViewInfo(att);

                            if (info.View is ISupportDataContext infoDC && newView is ISupportDataContext newViewDC)
                            {
                                infoDC.DataContext = newViewDC.DataContext;
                            }

                            dependentViews.Add(info);
                        }

                        _dependentViewCache.Add(newView, dependentViews);
                    }

                }

                dependentViews.ForEach(item => Region.RegionManager.Regions[item.Region].Add(item.View));
            }

            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var oldview in e.OldItems)
                {
                    if (_dependentViewCache.ContainsKey(oldview))
                    {
                        var dependentOldViews = _dependentViewCache[oldview];
                        dependentOldViews.ForEach(item => Region.RegionManager.Regions[item.Region].Remove(item.View));

                        if (!ShouldKeepAlive(oldview))
                        {

                        }
                    }
                }
            }
        }

        private bool ShouldKeepAlive(object oldView)
        {
            var regionLifeTime = GetRegionMemberLifetime(oldView);

            if (regionLifeTime != null)
                return regionLifeTime.KeepAlive;

            return true;
        }

        private IRegionMemberLifetime GetRegionMemberLifetime(object view)
        {
            if (view is IRegionMemberLifetime regionMemberLifetime)
                return regionMemberLifetime;

            if (view is FrameworkElement frameWorkElement)
                return frameWorkElement as IRegionMemberLifetime;

            return null;
        }

        private DependentViewInfo CreateDependentViewInfo(DependentViewAttribute attribute)
        {
            var result = new DependentViewInfo();
            result.Region = attribute.Region;
            result.View = _container.Resolve(attribute.Type);

            return result;
        }

        private static IEnumerable<T> GetCustomAttributes<T>(Type type)
        {
            return type.GetCustomAttributes(typeof(T), true).OfType<T>();
        }
    }
}
