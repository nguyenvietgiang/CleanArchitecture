using Domain.Entities;

namespace Application
{
    public interface ITodoRepository
    {
        Task<TodoList> GetTodoListAsync(int todoListId);
        Task<List<TodoList>> GetAllTodoListsAsync();
        Task AddTodoListAsync(TodoList todoList);
        Task UpdateTodoListAsync(TodoList todoList);
        Task DeleteTodoListAsync(int todoListId);
    }
}
