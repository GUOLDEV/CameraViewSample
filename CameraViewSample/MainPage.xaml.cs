using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CameraViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(async ()=> await LongProcessTask());
		}

        private async Task LongProcessTask()
        {
            await Task.Delay(TimeSpan.FromMinutes(1));
        }

        public async void CameraButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CameraPage());
        }
    }
}
