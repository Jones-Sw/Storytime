namespace StoryTime;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void onclick_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stories());
    }
}