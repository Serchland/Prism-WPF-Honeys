using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Business.fakeObjects.svcFake2;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Services.Interfaces
{
    public interface IGestDocService
    {
        IList<GestDocMessage> GetExpedientes();
        IList<GestDocMessage> GetBoletines();
        IList<GestDocMessage> GetMayores52();
        GestDocMessage GetDetailMessage(int messageId);

        FakeResponse1 DummyRequestSvc1();
        FakeResponse2 DummyRequestSvc2();
    }
}
