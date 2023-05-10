namespace MauiApp1;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (EditorControl.FontAttributes.HasFlag(FontAttributes.Bold))
        {
            EditorControl.FontAttributes &= ~FontAttributes.Bold;
        }
        else
        {
            EditorControl.FontAttributes |= FontAttributes.Bold;
        }

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (EditorControl.FontAttributes.HasFlag(FontAttributes.Italic))
        {
            EditorControl.FontAttributes &= ~FontAttributes.Italic;
        }
        else
        {
            EditorControl.FontAttributes |= FontAttributes.Italic;
        }
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        if (EditorControl.FontAttributes.HasFlag(FontAttributes.None))
        {
            EditorControl.FontAttributes &= ~FontAttributes.None;
        }
        else
        {
            EditorControl.FontAttributes |= FontAttributes.None;
        }

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        EditorControl.FontSize += 2;
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        EditorControl.FontSize -= 2;
    }
}