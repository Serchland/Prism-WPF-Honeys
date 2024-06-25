using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsControlDocumentFields
    {
        public long AccessCount { get; set; }
        public DateTime AccessDate { get; set; }
        public WsUser AccessUser { get; set; }
        public DateTime CreationDate { get; set; }
        public WsUser CreatorUser { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
        public WsUser UpdateUser { get; set; }
    }
}
