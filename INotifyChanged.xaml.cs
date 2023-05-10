namespace MauiApp1;

public partial class INotifyChanged : ContentPage
{
	Model.Employee obj= new Model.Employee();
	public INotifyChanged()
	{
		InitializeComponent();
		obj= new Model.Employee()
		{
			Id=1,
			Name = "Prince",
			Age= 32
		};
		BindingContext = obj;
	 }

    private void Button_Clicked(object sender, EventArgs e)
    {
		obj.Id = 1;
		obj.Name = "Shidharth";
		obj.Age = 27;
    }
}