using Xamarin.Forms;

namespace CameraViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
		}

        public async void CameraButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CameraPage());
        }
    }
}
