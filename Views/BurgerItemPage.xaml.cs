using AlbertoValverdeHamburguesa.Models;
using AlbertoValverdeHamburguesa.Data;

namespace AlbertoValverdeHamburguesa.Views;

[QueryProperty("Item", "Item")]
public partial class BurgerItemPage : ContentPage
{
    public Burger Item
    {
        get => BindingContext as Burger;
        set => BindingContext = value;
    }

    public BurgerItemPage()
    {

        InitializeComponent();
        BindingContext = Item;
        

    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
       //Item.Name = nameB.Text;
       //Item.Description = descB.Text;
       //Item.WithExtraCheese = _flag;
        
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
        //MessagingCenter.Send(this, "itemAdded", true);
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender,
   CheckedChangedEventArgs e)
    {
       // _flag = e.Value;
    }

    private void OnDeletedClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteItem(Item);
        Shell.Current.GoToAsync("..");
    }
}