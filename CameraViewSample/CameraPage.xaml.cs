using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace CameraViewSample
{
    public partial class CameraPage : ContentPage
    {
		int counter = 0;
		public CameraPage()
		{
			InitializeComponent();
		}

		public void CameraView_OnAvailable(object sender, bool e)
		{
			shutterButton.IsEnabled = e;
		}

		public void CameraView_MediaCaptured(object sender, MediaCapturedEventArgs e)
		{
			shutterButton.Text = $"{++counter}";
			previewPicture.Source = e.Image;
			previewPicture.Rotation = e.Rotation;
		}
	}
}
