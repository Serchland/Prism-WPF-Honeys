using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class TipoMetadatos
    {
        public string VersionNti { get; set; }
        public string Identificador { get; set; }
        public IList<string> Organo { get; set; }
        public DateTime FechaCaptura { get; set; }
        public TipoEstadoElaboracion EstadoElaboracion { get; set; }
        public TipoDocumental TipoDocumental { get; set; }
        public string Id { get; set; }
    }
}
