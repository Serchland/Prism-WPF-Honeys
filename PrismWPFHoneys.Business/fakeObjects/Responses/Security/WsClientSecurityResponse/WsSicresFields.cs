using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsSicresFields
    {
        public int? LinkId { get; set; }
        public int PageId { get; set; }
        public int BookId { get; set; }
        public int DocId { get; set; }
        public int FdrId { get; set; }
        public string RegisterNumber { get; set; }
        public RegisterType RegisterType { get; set; }
        public LinkSicresType Type { get; set; }
        public int? CopiedLinkID { get; set; }
        public StateTransact? StateTransact { get; set; }
        public string SGDADocumentId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public bool CanTryTransact { get; set; }
        public string MatterType { get; set; }
    }
}