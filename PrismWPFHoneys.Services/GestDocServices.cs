using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Business.fakeObjects.svcFake2;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PrismWPFHoneys.Services
{
    public class GestDocServices : IGestDocService
    {
        public GestDocServices()
        {
            Initialize();
        }

        private void Initialize()
        {
            int i = 0;
            Random rand = new Random();
            OutboxItems = new List<GestDocMessage>()
            {
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "maria@dummy.com",
                        Id = i++,
                        Subject = "Help wanted"
                    },
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "jenifer@dummy.com",
                        Id = i++,
                        Subject = "Additional info"
                    }
            };

            InboxItems = new List<GestDocMessage>()
            {
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "pilar@dummy.com",
                        Id = i++,
                        Subject = "Final project"
                    },
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "cynthia@dummy.com",
                        Id = i++,
                        Subject = "Holidays"
                    }
            };

            DraftItems = new List<GestDocMessage>()
            {
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "penelope@dummy.com",
                        Id = i++,
                        Subject = "Friday night"
                    },
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "noelia@dummy.com",
                        Id = i++,
                        Subject = "What the heck!"
                    }
            };

            DetailMessage = new GestDocMessage()
            {
                Subject = "Detail message"
            };
        }

        public IList<GestDocMessage> OutboxItems { get; set; }
        public IList<GestDocMessage> InboxItems { get; set; }
        public IList<GestDocMessage> DraftItems { get; set; }
        public GestDocMessage DetailMessage { get; set; }

        public IList<GestDocMessage> GetItem2()
        {
            return OutboxItems;
        }

        public IList<GestDocMessage> GetItem1()
        {
            return InboxItems;
        }

        public IList<GestDocMessage> GetItem3()
        {
            return DraftItems;
        }

        public GestDocMessage GetDetailMessage(int messageID)
        {
            return DetailMessage;
        }

        public FakeResponse1 DummyRequestSvc1()
        {
            return new FakeResponse1(){ DummyString = "From sv1"};
        }

        public FakeResponse2 DummyRequestSvc2()
        {
            return new FakeResponse2() { DummyString = "From svc2" };
        }
    }
}
