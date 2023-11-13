using TodoApp.Models;

namespace TodoApp.Services;
public interface ITodoItemService
{
    IEnumerable<TodoItem> GetAllTodoItemsAsync();
}
