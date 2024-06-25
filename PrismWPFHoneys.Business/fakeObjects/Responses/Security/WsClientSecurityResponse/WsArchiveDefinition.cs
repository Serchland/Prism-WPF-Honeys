using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsArchiveDefinition
    {
        public string _name { get; set; }
        public List<WsFolderTree> Trees { get; set; }
        public List<WsFolderType> FolderTypes { get; set; }
        public List<WsFolderField> FolderFields { get; set; }
        public WsPersonDefinition PersonDefinition { get; set; }
        public bool CanAccess { get; set; }
        public string BatchNamePrefix { get; set; }
        public List<WsCiudadanosCode> Cciucodes { get; set; }
        public bool CaActive { get; set; }
        public List<string> FileExtensions { get; set; }
        public List<string> FileExtensionsSICRES { get; set; }
        public List<string> FileExtensionsSGDA { get; set; }
        public bool AllowValueAcusePostal { get; set; }
        public float MaxAttachedmentSizeComu { get; set; }
        public float MaxAttachedmentSizeNoti { get; set; }
        public bool NotiSmsEnable { get; set; }
        public bool NotiEmailEnable { get; set; }
        public bool ComuSmsEnable { get; set; }
        public bool ComuEmailEnable { get; set; }
    }
    
}
