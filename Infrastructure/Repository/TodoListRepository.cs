using Application;
using Dapper;
using Domain.Entities;
using Npgsql;

namespace Infrastructure.Repository
{
    public class TodoListRepository : ITodoListRepository
    {
        private readonly IDataAcess _dataAccess;

        public TodoListRepository(IDataAcess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<TodoList>> GetAllTodoListsAsync()
        {
            string query = "SELECT * FROM \"TodoLists\"";
            return await _dataAccess.GetData<TodoList, dynamic>(query, new { });
        }

    }
}
