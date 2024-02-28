using Application;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class TodoListService : ITodoListService
    {
        private readonly ITodoListRepository _todoListRepository;

        public TodoListService(ITodoListRepository todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        public async Task<IEnumerable<TodoList>> GetAllTodoListsAsync()
        {
            return await _todoListRepository.GetAllTodoListsAsync();
        }
    }

}
