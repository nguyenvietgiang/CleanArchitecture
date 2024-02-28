using Domain.Entities;

namespace Application
{
    public interface ITodoListService
    {
        Task<IEnumerable<TodoList>> GetAllTodoListsAsync();
    }
}
