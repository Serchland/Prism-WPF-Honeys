using Fluent;
using Prism.Regions;
using System.Collections.Specialized;

namespace PrismWPFHoneys.ShellPrism.CustomRegion
{
    public class RibbonRegionAdapter : RegionAdapterBase<Ribbon>
    {
        public RibbonRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) 
            : base(regionBehaviorFactory)
        {

        }

        protected override void Adapt(IRegion region, Ribbon regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (RibbonTabItem element in e.NewItems)
                    {
                        regionTarget.Tabs.Add(element);
                    }
                }

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (RibbonTabItem element in e.OldItems)
                    {
                        regionTarget.Tabs.Remove(element);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
