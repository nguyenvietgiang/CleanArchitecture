using Domain.Entities;

namespace Application
{
    internal interface ITodoService
    {
        Task<List<TodoItem>> GetAllItemsAsync();
        Task<TodoItem> GetItemByIdAsync(int id);
        Task<TodoItem> CreateItemAsync(TodoItem item);
        Task UpdateItemAsync(int id, TodoItem item);
        Task DeleteItemAsync(int id);
    }
}
