using HTTPClient.ViewModels;
using Microsoft.Maui.Controls;

namespace HTTPClient.Views;

public partial class TodosView : ContentPage
{
	public TodosView()
	{
		InitializeComponent();
		BindingContext = new TodosViewModel();
	}
}