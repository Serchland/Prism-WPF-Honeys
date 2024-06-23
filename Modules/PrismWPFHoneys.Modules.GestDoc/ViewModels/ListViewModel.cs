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

namespace PrismWPFHoneys.Modules.GestDoc.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _currentFolder;

        private IMyDialogService _dialogService;
        private IGestDocService _GestDocService;

        public ListViewModel(IGestDocService GestDocService, IMyDialogService dialogService)
        {
            _newGestDocCaption = "New";

            _dialogService = dialogService;
            _GestDocService = GestDocService;
        }

        private ObservableCollection<GestDocMessage> _message;
        public ObservableCollection<GestDocMessage> Messages
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private GestDocMessage _selectedMessage;
        public GestDocMessage SelectedMessage
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

        private readonly string _newGestDocCaption;
        public string NewGestDocCaption
        {
            get { return _newGestDocCaption; }
        }

        #region "Commands"
        private DelegateCommand _GestDocDetailCommand;
        public DelegateCommand GestDocDetailCommand =>
            _GestDocDetailCommand ?? (_GestDocDetailCommand = new DelegateCommand(GestDocDetailExecute));

        void GestDocDetailExecute()
        {
            if (SelectedMessage is null)
                throw new NullReferenceException("SelectedMessage cant be null");

            _dialogService.Show("GestDocDetail", SelectedMessage.Id);
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
                case Folders.GestDoc.Item1:
                    Messages = new ObservableCollection<GestDocMessage>(_GestDocService.GetItem1());
                    ServiceInfo = "GestDocService.GetItem1 called";
                    break;

                case Folders.GestDoc.Item2:
                    Messages = new ObservableCollection<GestDocMessage>(_GestDocService.GetItem3());
                    ServiceInfo = "GestDocService.GetItem2 called";
                    break;

                case Folders.GestDoc.Item3:
                    Messages = new ObservableCollection<GestDocMessage>(_GestDocService.GetItem3());
                    ServiceInfo = "GestDocService.GetItem3 called";
                    break;                
            }
        }
        #endregion
    }
}
