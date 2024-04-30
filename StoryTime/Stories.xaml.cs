namespace StoryTime;

public partial class Stories : ContentPage
{
	public Stories()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new البقرة_ريري());
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
       
    }

    private async void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new العملاق_الشقي_وملك_الأقزام());
    }

    private async void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new يحيا_العدل());
    }
}