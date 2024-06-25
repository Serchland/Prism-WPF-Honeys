using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsFolderType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int FieldDefinitionId { get; set; }
        public bool Restricted { get; set; }
        public bool CanAccess { get; set; }
    }
}
