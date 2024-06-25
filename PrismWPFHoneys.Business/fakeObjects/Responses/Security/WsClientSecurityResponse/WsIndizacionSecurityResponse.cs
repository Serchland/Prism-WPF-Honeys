using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsIndizacionSecurityResponse : BaseSecurityResponse
    {

        public bool UsuarioAdministrador { get; set; }
        public bool HasExpedientesAccess { get; set; }
        public bool HasAccessAllExpedientesBatches { get; set; }
        public bool HasCCiuAccess { get; set; }
        public bool HasDocCiuAccess { get; set; }
        public bool HasAccessAllCCiuBatches { get; set; }
        public bool HasRegistroAccess { get; set; }
        public bool HasAccessAllRegistroBatches { get; set; }
        public string Path { get; set; }
        public int BatchMaxSize { get; set; }
        public int MaxFileUploadSize { get; set; }
        public List<WsArchiveDefinition> Definitions { get; set; }
        public PermisoRegistrar Registrar { get; set; }
        public PermisoModificacion Modificacion { get; set; }
    }
}
