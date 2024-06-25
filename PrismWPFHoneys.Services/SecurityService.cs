using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse;
using PrismWPFHoneys.Services.Interfaces;
using PrismWPFHoneys.Services.Responses.Security.WsTokenResponse;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PrismWPFHoneys.Services
{
    public class SecurityService : ISecurityService
    {
        private string _connectionString;
        public SecurityService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        }
        public WsTokenResponse GetAuthToken()
        {
            string query = "SELECT * FROM TableName WHERE ColumnName = @Param";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Param", SqlDbType.VarChar) { Value = "ValueToSearch" }
            };

            DataTable result = ExecuteQuery(query, parameters);

            return new WsTokenResponse();
            ////Procesar resultados
        }

        public WsTokenResponse GetTokenFromAccessKey()
        {
            return new WsTokenResponse();
        }

        public WsClientSecurityResponse GetUserPerms()
        {
            return new WsClientSecurityResponse();
        }

        private DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
