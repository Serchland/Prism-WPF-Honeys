using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsDivider
    {
        public long Id { get; set; }
        public long FolderTreeId { get; set; }
        public string Name { get; set; }
        public string NamefromDb { get; set; }
        public long ParentId { get; set; }
        public bool Restricted { get; set; }
        public bool CreateSub { get; set; }
        public bool CanAccess { get; set; }
        public bool CreateDoc { get; set; }
        public EditFlag EditState { get; set; }
        public string RegexPattern { get; set; }
        public List<WsDivider> Dividers { get; set; }
        public List<WsDocument> Documents { get; set; }
        public int TotalDividers { get; set; }
        public int TotalDividersWAccess { get; set; }
        public int TotalDocuments { get; set; }
        public int TotalDocumentsWAccess { get; set; }
        public DividerType Type { get; set; }
        public bool CanRename { get; set; }
        public bool CanDelete { get; set; }
        public bool CanMove { get; set; }
        public bool CanPrintSeparatorSheet { get; set; }
        public bool CanSendToJusticia { get; set; }
    }
}
