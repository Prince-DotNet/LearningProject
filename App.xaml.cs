namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var NavPage= new NavigationPage(new MainPage());
		MainPage = new HtmlToMaui();
	}
}
