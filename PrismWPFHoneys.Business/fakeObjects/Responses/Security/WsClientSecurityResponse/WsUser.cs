using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsUser
    {
        public Nullable<int> SicresId { get; set; }
        public Nullable<int> GissId { get; set; }
        public Perfil ProfileSicres { get; set; }
        public Nullable<int> SartidoId { get; set; }
        public IdocSystemProfile Profile { get; set; }
        public IdocUserStat GestDocState { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Departamento { get; set; }
        public Nullable<bool> HasAccessExpedientes { get; set; } = default(Boolean?);
        public Nullable<bool> HasAccessAllExpedientesBatches { get; set; } = default(Boolean?);
        public Nullable<bool> HasAccessCciu { get; set; } = default(Boolean?);
        public Nullable<bool> HasAccessAllCciuBatches { get; set; } = default(Boolean?);
        public Nullable<bool> HasAccessRegistro { get; set; } = default(Boolean?);
        public Nullable<bool> HasAccessAllRegistroBatches { get; set; } = default(Boolean?);
        public Nullable<bool> UsuarioAdministrador { get; set; } = default(Boolean?);
        public Nullable<bool> GestDocActive { get; set; } = default(Boolean?);
    }

}
