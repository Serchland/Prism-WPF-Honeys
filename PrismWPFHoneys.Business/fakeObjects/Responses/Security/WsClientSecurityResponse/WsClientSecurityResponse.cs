using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsClientSecurityResponse
    {
        public string User { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Email { get; set; }
        public bool UploadLog { get; set; }
        public DateTime? LastLogin { get; set; }
        public Nullable<DateTime> UpdateDateBinding { get; set; }
        public bool UseCustomBindings { get; set; }
        public WsAdminSecurityResponse AdminSecurity { get; set; }
        public WsGestDocSecurityResponse GestDocSecurity { get; set; }
        public WsIndizacionSecurityResponse IndizacionSecurity { get; set; }
        public bool ActivateEmail { get; set; } = false;


    }
}
