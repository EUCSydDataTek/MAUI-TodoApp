using CommunityToolkit.Mvvm.ComponentModel;
using TodoApp.Models;

namespace TodoApp.ViewModels;

// https://docs.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation#process-navigation-data-using-query-property-attributes
[QueryProperty(nameof(TodoItem), "item")]
public partial class ItemDetailViewModel: ObservableObject
{
    [ObservableProperty]
    TodoItem todoItem;
}
