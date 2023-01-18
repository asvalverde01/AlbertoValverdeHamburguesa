namespace AlbertoValverdeHamburguesa;
using AlbertoValverdeHamburguesa.Models;
using AlbertoValverdeHamburguesa.Data;


public partial class App : Application
{
    public static BurgerDatabase BurgerRepo { get; set; }
    public App(BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

        BurgerRepo = repo;
        
	}
}
