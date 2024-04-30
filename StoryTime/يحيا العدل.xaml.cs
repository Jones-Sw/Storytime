namespace StoryTime;

public partial class يحيا_العدل : ContentPage
{
    private int currentIndex = 0;
    public يحيا_العدل()
	{
		InitializeComponent();
	}

    private void prev_Clicked(object sender, EventArgs e)
    {

    }

    private void prev_Clicked_1(object sender, EventArgs e)
    {
        //prev

        nex.IsEnabled = true;
        // lw.Text = "-->";
        if (currentIndex > 1)
        {
            currentIndex--;
            uc();
            a.Source = "Resources/Images/cats" + currentIndex + "s.png";

        }
        else
        {
            prev.IsEnabled = false;
            us();
            a.Source = "Resources/Images/catss.png";


        }
    }

    private void nex_Clicked(object sender, EventArgs e)
    {
        //next

        {
            prev.IsEnabled = true;
            if (currentIndex < 12)
            {
                currentIndex++;
                uc();
                a.Source = "Resources/Images/cats" + currentIndex + "s.png";


            }
            else
            {
                nex.IsEnabled = false;

                pages.Text = "نهاية القصة";
            }
        }
    }
    private void uc()
    {
        string c1 = currentIndex.ToString();
        pages.Text = "" + c1 + " الصفحة";

    }
    private void us()
    {
        nex.Text = "اقرأ";
    }



}