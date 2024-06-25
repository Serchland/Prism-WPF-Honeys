using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsMetadatosEniSignature
    {
        public int _eniDataId{get; set;}
        public string _emisorCertificado{get; set;}
        public DateTime _fechaFirma{get; set;}
        public string _nombreCompletoFirmante{get; set;}
        public bool _valido{get; set;}
        public TipoFirmaType _tipoFirma{get; set;}
        public byte[] _contenido{get; set;}
        public string _valorCsv{get; set;}
        public string _regulacionGeneracionCSV{get; set;}
    }
}
