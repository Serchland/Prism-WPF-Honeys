
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums
{
    public enum StateTransact
    {
        NoTransacted = 0,
        //Tramitado pero sólo en sicres
        Transacted = 1,
        NoTryTransact = 2,
        //Incluido el expediente SGDA (Pero puede ser documento de Sicres con SGDA)
        Associated = 3,
        //A partir de aqui está convertido a enlace SGDA
        SGDALinked = 4,
        SicresUnlinked = 5
    }
}
