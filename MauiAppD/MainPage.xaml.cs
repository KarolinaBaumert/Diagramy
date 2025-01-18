namespace MauiAppD
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            if (LoginEntry.Text == "Pracownik1" && PasswordEntry.Text == "hasloP1") 
            { 
                Navigation.PushAsync(new NewPage1()); 
            } else 
            { 
                DisplayAlert("Błąd", "Nieprawidłowy login lub hasło.", "OK"); 
            }
        }
    }

}
