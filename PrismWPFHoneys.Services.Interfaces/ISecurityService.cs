using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse;
using PrismWPFHoneys.Services.Responses.Security.WsTokenResponse;

namespace PrismWPFHoneys.Services.Interfaces
{
    public interface ISecurityService
    {
        WsTokenResponse GetAuthToken();
        WsTokenResponse GetTokenFromAccessKey();
        WsClientSecurityResponse GetUserPerms();
    }
}
