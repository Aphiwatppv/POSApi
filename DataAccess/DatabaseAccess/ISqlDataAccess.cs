
namespace DataAccess.DatabaseAccess;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U Parameters, string connectionString = "Default");
    Task SaveData<T>(string storedProcedure, T Parameters, string connectionString = "Default");
}