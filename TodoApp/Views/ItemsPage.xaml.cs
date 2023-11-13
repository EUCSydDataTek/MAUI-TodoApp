using TodoApp.ViewModels;

namespace TodoApp.Views;

public partial class ItemsPage : ContentPage
{
    ItemsPageViewModel vm;
    public ItemsPage(ItemsPageViewModel vm)
    {
        InitializeComponent();
        this.vm = vm;
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        vm.GetTodoItemsCommand.Execute(null);
    }
}

