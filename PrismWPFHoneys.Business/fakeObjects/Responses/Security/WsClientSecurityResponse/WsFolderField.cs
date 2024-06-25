using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsFolderField
    {
        public string FolderTypeCode { get; set; }
        public Dictionary<FieldKey, WsArchiveField> Fields { get; set; }
        public WsFolderField(string code, Dictionary<FieldKey, WsArchiveField> fields)
        {
            this.FolderTypeCode = code;
            this.Fields = fields;
        }
        public WsFolderField(Dictionary<FieldKey, WsArchiveField> fields)
        {
            this.Fields = fields;
        }
    }
}
