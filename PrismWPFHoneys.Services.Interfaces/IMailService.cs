using PrismWPFHoneys.Business;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Business.fakeObjects.svcFake2;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Services.Interfaces
{
    public interface IMailService
    {
        IList<MailMessage> GetInboxItems();
        IList<MailMessage> GetOutboxItems();
        IList<MailMessage> GetDraftItems();
        MailMessage GetDetailMessage(int messageId);

        FakeResponse1 DummyRequestSvc1();
        FakeResponse2 DummyRequestSvc2();
    }
}
