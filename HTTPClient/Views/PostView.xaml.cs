using HTTPClient.ViewModels;
using Microsoft.Maui.Controls;

namespace HTTPClient.Views;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		BindingContext = new PostViewModel();		
	}
}