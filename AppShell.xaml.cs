using AlbertoValverdeHamburguesa.Views;

namespace AlbertoValverdeHamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
    }
}
