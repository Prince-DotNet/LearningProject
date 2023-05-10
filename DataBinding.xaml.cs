using MauiApp1.Model;

namespace MauiApp1;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MauiApp1.Model.Employee emp = new MauiApp1.Model.Employee()
		{
			Id = 1,
			Name = "Prince",
			Age = 32
		};
		//Binding empBinding= new Binding();
		//empBinding.Source = obj;
		//empBinding.Path = "Name";
		//EmployeLbl.SetBinding(Label.TextProperty, empBinding);
		//BindingContext = obj;
		EmployeLbl.BindingContext = emp;
		EmployeLbl.SetBinding(Label.TextProperty, "Name");
    }
}