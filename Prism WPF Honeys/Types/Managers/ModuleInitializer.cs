using Prism.Events;
using Prism.Modularity;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Types;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prism_WPF_Honeys.Types.Managers
{
    public class ModuleInitializer
    {
        private IGestDocService _gestDocService;
        private IEventAggregator _ea;
        public ModuleInitializer(IEventAggregator ea, IGestDocService GestDocService)
        {
            _ea = ea;
            _gestDocService = GestDocService;   
        }

        public async Task FakeLoginTaskAsync()
        {
            var tNotas = InitializeNotasModuleAsync();
            var tRegistro = InitializeRegistroModuleAsync();
            var tGestDoc = InitializeGestDocModuleAsync();

            await Task.WhenAll(tNotas, tRegistro, tGestDoc);
        }

        private async Task InitializeNotasModuleAsync()
        {
            await Task.Delay(3000);
            _ea.GetEvent<OnModuleInitializedEvent>().Publish(AppModuleNames.NotasModuleName);
        }

        private async Task InitializeRegistroModuleAsync()
        {
            await Task.Delay(2000);
            _ea.GetEvent<OnModuleInitializedEvent>().Publish(AppModuleNames.RegistroModuleName);
        }

        private async Task InitializeGestDocModuleAsync()
        {
            await Task.Delay(0);
            _gestDocService.GetBoletines();
            _ea.GetEvent<OnModuleInitializedEvent>().Publish(AppModuleNames.GestDocModuleName);
        }


    }
}
