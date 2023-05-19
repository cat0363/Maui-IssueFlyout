using System.Collections.ObjectModel;

namespace Maui_IssueFlyout;

public partial class FlyoutMenu : ContentView
{
	ObservableCollection<MenuItem> pMenuItems = new ObservableCollection<MenuItem>();

    public event EventHandler<MenuTappedEventArgs> MenuTapped;

    public FlyoutMenu()
	{
		InitializeComponent();
        pMenuItems.Add(new MenuItem() { MenuId = 1, MenuName = "Menu1" });
        pMenuItems.Add(new MenuItem() { MenuId = 2, MenuName = "Menu2" });
        pMenuItems.Add(new MenuItem() { MenuId = 3, MenuName = "Menu3" });
        pMenuItems.Add(new MenuItem() { MenuId = 4, MenuName = "Menu4" });

		BindableLayout.SetItemsSource(slMenuList, pMenuItems);
    }

    private void gdMenu_Tapped(object sender, TappedEventArgs e)
    {
        MenuItem menuItem = (sender as Grid).BindingContext as MenuItem;
        EventHandler<MenuTappedEventArgs> raiseEvent = MenuTapped;
        if (raiseEvent != null)
        {
            raiseEvent(sender, new MenuTappedEventArgs() { MenuItem = menuItem });
        }
    }
}

public class MenuTappedEventArgs : EventArgs
{
    public MenuItem MenuItem { get; set; }
}

public class MenuItem
{
	public short MenuId { get; set; }
	public string MenuName { get; set; }
}