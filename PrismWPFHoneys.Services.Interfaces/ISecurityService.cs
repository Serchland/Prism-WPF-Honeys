using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Services.Interfaces
{
    public interface ISecurityService
    {
        void GetAuthToken();
        void GetTokenFromAccessKey();
        void GetUserPerms();
    }
}
