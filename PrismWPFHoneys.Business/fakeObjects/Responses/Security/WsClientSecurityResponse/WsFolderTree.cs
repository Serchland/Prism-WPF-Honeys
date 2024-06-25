using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsFolderTree
    {
        public string FolderTypeCode { get; set; }
        public List<WsDivider> Dividers { get; set; }
        public List<WsDocument> Documents { get; set; }
        public string RegexPattern { get; set; }
        public bool CreateSub { get; set; }
        public string Title { get; set; }
    }
}
