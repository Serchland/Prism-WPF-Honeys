using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsPersonIpType
    {
       
        public int Id { get; set; }
       
        public string Code { get; set; }
       
        public string Description { get; set; }
       
       public string RegexPattern { get; set; }
        
        public int MaxLength { get; set; }
        
        public bool CanCreate { get; set; }
        
        public bool CanUpdate { get; set; }
        
        public bool CanUse { get; set; }
        
        public int FileId { get; set; }
    }
}
