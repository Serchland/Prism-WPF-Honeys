using PrismWPFHoneys.Business;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Services.Interfaces
{
    public interface IMailService
    {
        IList<MailMessage> GetInboxItems();
        IList<MailMessage> GetOutboxItems();
        IList<MailMessage> GetDraftItems();
    }
}
