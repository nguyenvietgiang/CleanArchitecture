

namespace Application
{
    public interface IDataAcess
    {
        Task<IEnumerable<T>> GetData<T, P>(string query, P parameters);
        Task ExecuteCommand<P>(string command, P parameters);
    }
}
