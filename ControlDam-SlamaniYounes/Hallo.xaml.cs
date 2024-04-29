using static Android.Webkit.ConsoleMessage;

namespace ControlDam_SlamaniYounes;

public partial class Hallo : ContentPage
{

    string Loginpassword = "DAM2024";
    public int nb = 0;
    public static int LoginSuccessCounter { get; set; } = 1;

    public Hallo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
     

    }

    private  async void OnSubmitClicked(object sender, EventArgs e)
    {
        if (passwordEntry.Text == Loginpassword)
        {
            nb++;
            this.Navigation.PushAsync(new Bravo(nb));
            
        }
        else
        {
            await DisplayAlert("Error password", "Password not valid", "Ok");
        }
    }
}