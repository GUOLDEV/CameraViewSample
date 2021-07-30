using System;
using Xamarin.Forms;

namespace CameraViewSample
{
    public partial class SegmentedControlPage : ContentPage
    {
        public SegmentedControlPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if(sender is Label label)
            {
                Grid.SetColumn(frame, Grid.GetColumn(label));
            }
        }
    }
}
