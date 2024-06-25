using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums
{
    public enum RequireStampMetadata
    {
        None = 0,
        CA = 1,
        WithHash = 2,
        OnlyMetadata = 3,
        OnlySignature = 4
    }
}
