namespace Expander;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ExpanderFrame();
	}
}
