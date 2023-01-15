namespace SalesLibrary.Services
{
    public interface IMySQLDataAccessService
    {
        Task CUDData<T>(string sql, T parameters);
        Task<List<T>> ReadData<T, U>(string sql, U parameters);
    }
}
