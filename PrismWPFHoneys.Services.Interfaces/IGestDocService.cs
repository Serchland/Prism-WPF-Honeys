using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Business.fakeObjects.svcFake2;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Services.Interfaces
{
    public interface IGestDocService
    {
        IList<GestDocMessage> GetItem1();
        IList<GestDocMessage> GetItem2();
        IList<GestDocMessage> GetItem3();
        GestDocMessage GetDetailMessage(int messageId);

        FakeResponse1 DummyRequestSvc1();
        FakeResponse2 DummyRequestSvc2();
    }
}
