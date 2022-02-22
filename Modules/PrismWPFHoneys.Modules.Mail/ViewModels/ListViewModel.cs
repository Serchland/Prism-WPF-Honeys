using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _currentFolder;

        private IMailService _mailService;

        public ListViewModel(IMailService mailService)
        {
            TestProperty = "Mail TestProperty";
            _mailService = mailService;
        }

        private ObservableCollection<MailMessage> _message;
        public ObservableCollection<MailMessage> Messages
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _serviceInfo;
        public string ServiceInfo
        {
            get { return _serviceInfo; }
            set { SetProperty(ref _serviceInfo, value); }
        }

        public string TestProperty { get; }

        #region "Commands"
        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand =>
            _testCommand ?? (_testCommand = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {
            System.Windows.MessageBox.Show("Command from Mail");
        }
        #endregion

        #region "INavigationAware implementation"
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string _currentFolder = navigationContext.Parameters.GetValue<string>("id");
            LoadMessages(_currentFolder);
        }

        private void LoadMessages(string currentFolder)
        {
            switch (currentFolder)
            {
                case Folders.Mail.Draft:
                    Messages = new ObservableCollection<MailMessage>(_mailService.GetDraftItems());
                    ServiceInfo = "mailService.GetDraftItems called";
                    break;

                case Folders.Mail.Inbox:
                    Messages = new ObservableCollection<MailMessage>(_mailService.GetInboxItems());
                    ServiceInfo = "mailService.GetInboxItems called";
                    break;

                case Folders.Mail.Outbox:
                    Messages = new ObservableCollection<MailMessage>(_mailService.GetOutboxItems());
                    ServiceInfo = "mailService.GetOutboxItems called";
                    break;                
            }
        }
        #endregion
    }
}
