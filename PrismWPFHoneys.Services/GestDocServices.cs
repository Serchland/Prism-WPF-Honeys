using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Business.fakeObjects.svcFake2;
using PrismWPFHoneys.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace PrismWPFHoneys.Services
{
    public class GestDocServices : IGestDocService
    {
        private string _connectionString;
        public GestDocServices()
        {
            Initialize();
        }

        private void Initialize()
        {
            int i = 0;
            Random rand = new Random();
            GetExpedientesResult = new List<GestDocMessage>()
            {
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "Expedientes",
                        Id = i++,
                        Subject = string.Format ("{0}{1}", "Expediente info:", i.ToString())
                    },
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "Expedientes",
                        Id = i++,
                        Subject = string.Format ("{0}{1}", "Expediente info:", i.ToString())
                    }
            };

            GetBoletinesResult = new List<GestDocMessage>()
            {
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "Boletines",
                        Id = i++,
                        Subject = string.Format ("{0}{1}", "Boletines info:", i.ToString())
                    },
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "Boletines",
                        Id = i++,
                        Subject = string.Format ("{0}{1}", "Boletines info:", i.ToString())
                    }
            };

            GetMayores52Result = new List<GestDocMessage>()
            {
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "Mayores52",
                        Id = i++,
                        Subject = string.Format ("{0}{1}", "Mayores52 info:", i.ToString())
                    },
                new GestDocMessage()
                    {
                        DateSent = DateTime.Now.Subtract(new TimeSpan(rand.Next())),
                        From = "Mayores 52",
                        Id = i++,
                        Subject = string.Format ("{0}{1}", "Mayores52 info:", i.ToString())
                    }
            };

            DetailMessage = new GestDocMessage()
            {
                Subject = "Detail message"
            };
        }

        public IList<GestDocMessage> GetExpedientesResult { get; set; }
        public IList<GestDocMessage> GetBoletinesResult { get; set; }
        public IList<GestDocMessage> GetMayores52Result { get; set; }
        public GestDocMessage DetailMessage { get; set; }

        public IList<GestDocMessage> GetBoletines()
        {
            return GetBoletinesResult;
        }

        public IList<GestDocMessage> GetExpedientes()
        {
            return GetExpedientesResult;
        }

        public IList<GestDocMessage> GetMayores52()
        {
            return GetMayores52Result;
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
