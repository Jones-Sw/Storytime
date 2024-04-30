using static System.Net.Mime.MediaTypeNames;

namespace StoryTime;

public partial class العملاق_الشقي_وملك_الأقزام : ContentPage
{
    private int currentIndex = 0;
    public العملاق_الشقي_وملك_الأقزام()
	{
		InitializeComponent();
	}

    private void prev_Clicked(object sender, EventArgs e)
    {  //prev

        nex.IsEnabled = true;
        // lw.Text = "-->";
        if (currentIndex > 1)
        {
            currentIndex--;
            uc();
            a.Source = "Resources/Images/bi" + currentIndex + "g.png";

        }
        else
        {
            prev.IsEnabled = false;
            us();
            a.Source = "Resources/Images/big.png";


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
                a.Source = "Resources/Images/bi" + currentIndex + "g.png";


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