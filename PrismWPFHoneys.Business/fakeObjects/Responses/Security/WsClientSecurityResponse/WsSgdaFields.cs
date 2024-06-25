using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsSgdaFields
    {
        public string SgdaDocumentId { get; set; }

        public string SgdaDocumentType { get; set; }

        public string SgdaExpedienteId { get; set; }

        public string SgdaExpedienteType { get; set; }

        public string Seguridad { get; set; }

        public int? LinkId { get; set; }

        public int? CopiedLinkID { get; set; }

        public string CiudadanosCode { get; set; }

        public LinkSgdaType Confirmed { get; set; }

        public string RochadeCode { get; set; }
    }
}
