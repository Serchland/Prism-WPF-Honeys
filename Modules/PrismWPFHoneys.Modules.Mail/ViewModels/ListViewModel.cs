using AutoMapper;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _currentFolder;

        private IMyDialogService _dialogService;
        private IMailService _mailService;

        public ListViewModel(IMailService mailService, IMyDialogService dialogService)
        {
            _newMailCaption = "New";

            _dialogService = dialogService;
            _mailService = mailService;
        }

        private ObservableCollection<MailMessage> _message;
        public ObservableCollection<MailMessage> Messages
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private MailMessage _selectedMessage;
        public MailMessage SelectedMessage
        {
            get { return _selectedMessage; }
            set { SetProperty(ref _selectedMessage, value); }
        }

        private string _serviceInfo;
        public string ServiceInfo
        {
            get { return _serviceInfo; }
            set { SetProperty(ref _serviceInfo, value); }
        }

        private readonly string _newMailCaption;
        public string NewMailCaption
        {
            get { return _newMailCaption; }
        }

        #region "Commands"
        private DelegateCommand _mailDetailCommand;
        public DelegateCommand MailDetailCommand =>
            _mailDetailCommand ?? (_mailDetailCommand = new DelegateCommand(MailDetailExecute));

        void MailDetailExecute()
        {
            if (SelectedMessage is null)
                throw new NullReferenceException("SelectedMessage cant be null");

            _dialogService.Show("MailDetail", SelectedMessage.Id);
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
            _currentFolder = navigationContext.Parameters.GetValue<string>("id");
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
