using AlbertoValverdeHamburguesa.Models;
namespace AlbertoValverdeHamburguesa.Views;

public partial class BurgerListPage : ContentPage
{    
    public BurgerListPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnUpdate(object sender, EventArgs e)
    {
        //fetch new items and update the Burgers property
        List<Burger> newBurgers = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
    }
    

    public void OnItemAdded(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] =  new Burger()
        });
    }

    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdate(sender, e);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<Burger> newBurgers = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Burger burgers = e.CurrentSelection.FirstOrDefault() as Burger;
        if (burgers == null)
            return;
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            {"Item", burgers}

        });
        ((CollectionView)sender).SelectedItem = null;
    }
}
