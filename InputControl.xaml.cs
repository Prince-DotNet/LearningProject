using System.Diagnostics;

namespace MauiApp1;

public partial class InputControl : ContentPage
{
	public InputControl()
	{
		InitializeComponent();
	}

    private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		resultSlider.Text=Slider1.Value.ToString();
    }

    private void Steper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if(Steper1 != null)
        {
            resultSlider.Text = Steper1.Value.ToString();
        }
    }

    private void UserTxt_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(UserTxt.Text);
    }

    private void UserTxt_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(UserTxt.Text);
    }
}