using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsPersonJurDefinition
    {
        public Dictionary<FieldPersonJurKey, WsPersonField> Fields { get; set; }
        public List<WsPersonIpType> IpjTypes { get; set; }
    }
}
