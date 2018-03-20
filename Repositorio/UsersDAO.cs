using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using PROJETOJWT.Models;

namespace PROJETOJWT.Repositorio
{
    public class UsersDAO
    {
        private IConfiguration _configuration;
        public UsersDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public User Find(string userId){
            using(SqlConnection conexao = new SqlConnection(
                _configuration.GetConnectionString("ExemploJWT"))){
                return conexao.QueryFirstOrDefault<User>("Select UserID,AccessKey from Users Where UserID=@UserID",new{UserID = userId});
            }
        }
    }
}