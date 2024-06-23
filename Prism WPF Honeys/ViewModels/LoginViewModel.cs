using Prism.Commands;
using Prism.Events;
using Prism_WPF_Honeys.Types.Managers;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prism_WPF_Honeys.ViewModels
{
    public class LoginViewModel
    {
        private IGestDocService _gestDocService;
        private IEventAggregator _ea;
        public LoginViewModel(IEventAggregator ea, IGestDocService GestDocService)
        {
            _gestDocService = GestDocService;
            _ea = ea;
            //TODO: Do login tasks
        }

        private DelegateCommand _acceptCommand;
        public DelegateCommand AcceptCommand =>
            _acceptCommand ?? (_acceptCommand = new DelegateCommand(ExecuteAcceptCommand));

        private async void ExecuteAcceptCommand()
        {
            var moduleInitializer = new ModuleInitializer(_ea, _gestDocService);
            await moduleInitializer.FakeLoginTaskAsync();
        }

       
    }
}
