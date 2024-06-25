using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class ArchivePerms
    {
        public long Archid { get; set; }
        public string Name { get; set; }
        public bool QueryPerm { get; set; }
        public bool UpdatePerm { get; set; }
        public bool CreatePerm { get; set; }
        public bool DeletePerm { get; set; }
        public bool HasAccess { get; set; }
    }
}
