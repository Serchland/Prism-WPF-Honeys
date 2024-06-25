using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsSgdaMetadata
    {
        public string Tipologia { get; set; }
        public string NombreTipologia  { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Propiedad  { get; set; }
        public string NombrePropiedad  { get; set; }
        public string Naturaleza  { get; set; }
        public string NombreNaturaleza  { get; set; }
        public string NivelLOPD  { get; set; }
        public string Titulo  { get; set; }
        public string NombreFichero  { get; set; }
        public string DocumentalType  { get; set; }
        public SgdaOprtnType? Operation { get; set; }
    }
}
