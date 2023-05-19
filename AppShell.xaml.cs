namespace Maui_IssueFlyout;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private async void fmMenu_MenuTapped(object sender, MenuTappedEventArgs e)
	{
		switch (e.MenuItem.MenuId) 
		{
            case 1:
                await Shell.Current.Navigation.PushAsync(new Page1(), false);
                break;
            case 2:
                await Shell.Current.Navigation.PushAsync(new Page2(), false);
                break;
            case 3:
                await Shell.Current.Navigation.PushAsync(new Page3(), false);
                break;
            case 4:
                await Shell.Current.Navigation.PushAsync(new Page4(), false);
                break;
        }
        Shell.Current.FlyoutIsPresented = false;
    }
}
