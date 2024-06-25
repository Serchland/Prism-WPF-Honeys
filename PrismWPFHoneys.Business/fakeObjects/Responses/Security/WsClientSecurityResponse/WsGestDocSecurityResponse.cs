using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsGestDocSecurityResponse : BaseSecurityResponse
    {
       
        public bool UsuarioAdministrador { get; set; }
        public IdocSystemProfile Profile { get; set; }
        public bool PrintPermission { get; set; }
        public bool PrintAllPermission { get; set; }
        public bool LopdAccessPermission { get; set; }
        public bool DeleteAccessPermission { get; set; }
        public bool CreatePersonPermission { get; set; }
        public bool UpdatePersonPermission { get; set; }
        public bool RemovePersonPermission { get; set; }
        public bool GenerateEejDocumentPermission { get; set; }
        public List<AppPerm> Applications { get; set; }
        public string BatchDirPath { get; set; }
        public int MaxFileUploadSize { get; set; }
        public bool GenerateCAPermission { get; set; }
        public bool HasEniPermission { get; set; }
        public bool EessiPermission { get; set; }
        public IdocUserStat State { get; set; }
        public bool GenerateEniPermission { get; set; }
        public string UserName { get; set; }
        public UnitsAccessProfile UnitsAccessProfile { get; set; }
        public List<WsRelatedUnit> RelatedUnits { get; set; }
        public bool GestDocActive { get; set; }
        public bool NotificationPermission { get; set; }
        public bool CommunicationPermission { get; set; }

        public WsGestDocSecurityResponse() : base()
        {

        }
    }
}
