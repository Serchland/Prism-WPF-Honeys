using System;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Business
{
    public class GestDocMessage : BusinessBase
    {
        public int Id { get; set; }

        private string _from;
        public string From
        {
            get { return _from; }
            set { SetProperty(ref _from, value); }
        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { SetProperty(ref _subject, value); }
        }

        private DateTime _dateSent;
        public DateTime DateSent
        {
            get { return _dateSent; }
            set { SetProperty(ref _dateSent, value); }
        }

        public GestDocMessage()
        {
            Id = new Random().Next(10, 6000);
        }
    }
}
