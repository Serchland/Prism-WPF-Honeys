using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsFieldBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ColumnName { get; set; }
        public bool IsRequired { get; set; }
        public bool IsEditable { get; set; }
        public string RegexPattern { get; set; }
        public int MaxLength { get; set; }
    }
}
