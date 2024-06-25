using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsPersonFisDefinition
    {
        public Dictionary<FieldPersonFisKey, WsPersonField> Fields { get; set; }
        public List<WsPersonIpType> IpfTypes { get; set; }
    }
}
