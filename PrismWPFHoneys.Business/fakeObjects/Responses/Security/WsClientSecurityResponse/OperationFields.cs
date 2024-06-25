using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class OperationFields
    {
        public string DocumentalType { get; set; }
       
        // Uso interno
        public string DocumentalTypeDescription { get; set; }
        public string DocTitle { get; set; }
        public SgdaOprtnType Operation { get; set; }
        public string SartidoCode { get; set; }
        public int? Naturaleza { get; set; }

    }
}
