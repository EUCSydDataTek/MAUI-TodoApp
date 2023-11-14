using TodoApp.ViewModels;

namespace TodoApp.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(ItemDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}