﻿using Prism.Commands;
using Prism.Events;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Types;
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
        private IEventAggregator _ea;
        public LoginViewModel(IEventAggregator ea)
        {
            _ea = ea;
            //TODO: Do login tasks
        }

        private DelegateCommand _acceptCommand;
        public DelegateCommand AcceptCommand =>
            _acceptCommand ?? (_acceptCommand = new DelegateCommand(ExecuteAcceptCommand));

        void ExecuteAcceptCommand()
        {
            FakeLoginTask();
        }

        private void FakeLoginTask()
        {
            Thread tNotas = new Thread(new ThreadStart(ThreadNotas));
            Thread tContacts = new Thread(new ThreadStart(ThreadContacts));
            Thread tMail = new Thread(new ThreadStart(ThreadMail));

            tNotas.Start();
            tContacts.Start();
            tMail.Start();
        }

        private void ThreadNotas()
        {
            Thread.Sleep(3000);
            _ea.GetEvent<OnModuleInitializedEvent>().Publish(AppModuleNames.NotasModuleName);
        }

        private void ThreadContacts()
        {
            Thread.Sleep(2000);
            _ea.GetEvent<OnModuleInitializedEvent>().Publish(AppModuleNames.ContactsModuleName);
        }

        private void ThreadMail()
        {
            Thread.Sleep(0);
            _ea.GetEvent<OnModuleInitializedEvent>().Publish(AppModuleNames.MailModuleName);
        }
    }
}
