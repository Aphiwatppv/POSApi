using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace DataAccess.DatabaseAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _configuration; // use to read connection string from appsetting.json 

    public SqlDataAccess(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //Create Method for loading and saving

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U Parameters, string connectionString = "Default")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionString)); // Connect to database
        return await connection.QueryAsync<T>(storedProcedure, Parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedure, T Parameters, string connectionString = "Default")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionString)); // use IConfuguration (Microsoft.Extensions.Configuration) to get conectionstring then pass to the SqlConnection class
        await connection.ExecuteAsync(storedProcedure, Parameters, commandType: CommandType.StoredProcedure);
    }

}
