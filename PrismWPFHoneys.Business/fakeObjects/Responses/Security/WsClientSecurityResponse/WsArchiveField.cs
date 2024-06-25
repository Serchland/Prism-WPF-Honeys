using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsArchiveField : WsFieldBase
    {
        public long IdocId { get; set; }
        public object Value { get; set; }
        public FieldDataType DataType { get; set; }
        public FieldDbType DbType { get; set; }
        public FieldPersonType PersonType { get; set; }
        public List<WsConditionalBehaviourField> ConditionalBehaviourFields { get; set; }

    }
}
