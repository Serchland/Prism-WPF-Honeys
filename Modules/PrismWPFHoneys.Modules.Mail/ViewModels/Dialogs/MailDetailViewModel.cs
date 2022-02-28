using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismWPFHoneys.Business;
using System;

namespace PrismWPFHoneys.Modules.Mail.ViewModels.Dialogs
{
    public class MailDetailViewModel : BindableBase
    {
        public MailDetailViewModel()
        {
        }

        private MailMessage _detailMessage;
        public MailMessage DetailMessage
        {
            get { return _detailMessage; }
            set { SetProperty(ref _detailMessage, value); }
        }
    }
}
