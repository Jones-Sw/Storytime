using Android.Media;
using static System.Net.Mime.MediaTypeNames;


namespace StoryTime;

public partial class العملاق_الشقي_وملك_الأقزام : ContentPage
{
    private int currentIndex = 0;
    MediaPlayer player;
    public object CrossMediaManager { get; private set; }

    public العملاق_الشقي_وملك_الأقزام()
	{
		InitializeComponent();
        player = new MediaPlayer();
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

  

    private void Voice_Clicked_1(object sender, EventArgs e)
    {

        try
        {
            // Path to your audio file
            var audioFile = "ttsmaker-file-2024-5-16-3-10-59.mp3";

            // Play the audio file
            player.Reset(); // Reset player to clear any previous state
            var fd = global::Android.App.Application.Context.Assets.OpenFd(audioFile);
            player.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
            player.Prepare();
            player.Start();
        }
        catch (Exception ex)
        {
            // Handle exceptions, such as file not found or playback error
            Console.WriteLine($"Error playing audio: {ex.Message}");
        }
    }
}