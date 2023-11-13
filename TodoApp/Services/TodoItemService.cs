using TodoApp.Models;

namespace TodoApp.Services;
public class TodoItemService : ITodoItemService
{
    public TodoItemService()
    {
        LoadTodoItems();
    }

    private List<TodoItem> todoItems;

    private void LoadTodoItems()
    {
        todoItems = new List<TodoItem>
        {
            new TodoItem { Id = 1, Description = "First item", Completed = false, CreatedTime = DateTime.Now, Priority = PriorityLevel.Low },
            new TodoItem { Id = 2, Description = "Second item", Completed = false, CreatedTime = DateTime.Now, Priority = PriorityLevel.Normal },
            new TodoItem { Id = 3, Description = "Third item", Completed = false, CreatedTime = DateTime.Now, Priority = PriorityLevel.High }
        };
    }

    public IEnumerable<TodoItem> GetAllTodoItemsAsync()
    {
        return todoItems;
    }
}
