using PrismWPFHoneys.Business;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PrismWPFHoneys.Services
{
    public class MailServices : IMailService
    {
        public MailServices()
        {
            Initialize();
        }

        private void Initialize()
        {
            int i = 0;
            Random rand = new Random();
            OutboxItems = new List<MailMessage>()
            {
                new MailMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "maria@dummy.com",
                        Id = i++,
                        Subject = "Help wanted"
                    },
                new MailMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "jenifer@dummy.com",
                        Id = i++,
                        Subject = "Additional info"
                    }
            };

            InboxItems = new List<MailMessage>()
            {
                new MailMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "pilar@dummy.com",
                        Id = i++,
                        Subject = "Final project"
                    },
                new MailMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "cynthia@dummy.com",
                        Id = i++,
                        Subject = "Holidays"
                    }
            };

            DraftItems = new List<MailMessage>()
            {
                new MailMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "penelope@dummy.com",
                        Id = i++,
                        Subject = "Friday night"
                    },
                new MailMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "noelia@dummy.com",
                        Id = i++,
                        Subject = "What the heck!"
                    }
            };

            DetailMessage = new MailMessage()
            {
                Subject = "Detail message"
            };
        }

        public IList<MailMessage> OutboxItems { get; set; }
        public IList<MailMessage> InboxItems { get; set; }
        public IList<MailMessage> DraftItems { get; set; }
        public MailMessage DetailMessage { get; set; }

        public IList<MailMessage> GetOutboxItems()
        {
            return OutboxItems;
        }

        public IList<MailMessage> GetInboxItems()
        {
            return InboxItems;
        }

        public IList<MailMessage> GetDraftItems()
        {
            return DraftItems;
        }

        public MailMessage GetDetailMessage(int messageID)
        {
            return DetailMessage;
        }
    }
}
