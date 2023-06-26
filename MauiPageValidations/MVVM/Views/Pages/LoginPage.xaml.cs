using MauiPageValidations.MVVM.ViewModels;

namespace MauiPageValidations.MVVM.Views.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}