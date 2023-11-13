using TodoApp.ViewModels;

namespace TodoApp.Views;

public partial class MainPage : ContentPage
{
    MainPageViewModel vm;
    public MainPage(MainPageViewModel vm)
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

