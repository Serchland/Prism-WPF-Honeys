using AutoMapper;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Services.Interfaces;
using System;

namespace PrismWPFHoneys.Modules.Mail.ViewModels.Dialogs
{
    public class MailDetailViewModel : BindableBase
    {
        private IMapper _mapper;
        private IMailService _mailService;
        public MailDetailViewModel(IMapper mapper, IMailService mailService)
        {
            _mapper = mapper;
            _mailService = mailService;
        }

        private MailMessage _detailMessage;
        public MailMessage DetailMessage
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
            //var responseSvc1 = _mailService.DummyRequestSvc1();
            var responseSvc2 = _mailService.DummyRequestSvc2();


            var result = _mapper.Map<FakeResponse1>(responseSvc2);
        }
        #endregion

    }
}
