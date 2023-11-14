using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TodoApp.Models;
using TodoApp.Services;
using TodoApp.Views;

namespace TodoApp.ViewModels;
public partial class ItemsPageViewModel : ObservableObject
{
    private readonly ITodoItemService service;

    public ItemsPageViewModel(ITodoItemService service)
    {
        this.service = service;
    }
    public ObservableCollection<TodoItem> TodoItemsCollection { get; } = new();

    [RelayCommand]
    void GetTodoItems()
    {
        IEnumerable<TodoItem> todoItems = service.GetAllTodoItemsAsync();
        TodoItemsCollection.Clear();

        foreach (var item in todoItems)
        {
            TodoItemsCollection.Add(item);
        }
    }

    // new code
    [RelayCommand]
    async Task GoToDetails(TodoItem todoItem)
    {
        await Shell.Current.GoToAsync(nameof(DetailsPage), new Dictionary<string, object>
        {
            {"item", todoItem }
        });
    }
}
