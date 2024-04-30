namespace StoryTime;

public partial class البقرة_ريري : ContentPage
{
    private int currentIndex = 0;
    public البقرة_ريري()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void prev_Clicked(object sender, EventArgs e)
    {
        //prev

        nex.IsEnabled = true;
        // lw.Text = "-->";
        if (currentIndex > 1)
        {
            currentIndex--;
            uc();
            a.Source = "Resources/Images/cow" + currentIndex + "s.png";

        }
        else
        {
            prev.IsEnabled = false;
            us();
            a.Source = "Resources/Images/cow.png";


        }
    }

    private void nex_Clicked(object sender, EventArgs e)
    {
        //next

        {
            prev.IsEnabled = true;
            if (currentIndex < 7)
            {
                currentIndex++;
                uc();
                a.Source = "Resources/Images/cow" + currentIndex + "s.png";


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