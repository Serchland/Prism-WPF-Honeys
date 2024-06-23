using AutoMapper;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Services.Interfaces;
using System;

namespace PrismWPFHoneys.Modules.GestDoc.ViewModels.Dialogs
{
    public class GestDocDetailViewModel : BindableBase
    {
        private IMapper _mapper;
        private IGestDocService _GestDocService;
        public GestDocDetailViewModel(IMapper mapper, IGestDocService GestDocService)
        {
            _mapper = mapper;
            _GestDocService = GestDocService;
        }

        private GestDocMessage _detailMessage;
        public GestDocMessage DetailMessage
        {
            get { return _detailMessage; }
            set { SetProperty(ref _detailMessage, value); }
        }

        #region "Commands"
        private DelegateCommand _mapTestCommand;
        public DelegateCommand MapTestCommand =>
            _mapTestCommand ?? (_mapTestCommand = new DelegateCommand(MapTestCommandExecute));

        void MapTestCommandExecute()
        {
            //var responseSvc1 = _GestDocService.DummyRequestSvc1();
            var responseSvc2 = _GestDocService.DummyRequestSvc2();


            var result = _mapper.Map<FakeResponse1>(responseSvc2);
        }
        #endregion

    }
}
