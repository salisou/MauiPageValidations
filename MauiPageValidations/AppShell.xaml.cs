using MauiPageValidations.MVVM.Views.Pages;

namespace MauiPageValidations;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
    }
}
