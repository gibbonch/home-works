using System;
namespace CodeLocker.Resources.Styles
{
	public class ImagesViewModel
	{
        public ObservableCollection<Image> Images { get; set; }

        public ImagesViewModel()
		{
            Images = new ObservableCollection<Image>
            {
                new Image
                {
                    Name = "icon.png",
                    Caption = "Reboot",
                    TapClickEventHandler = OnTapped
                }
            }
        }

        int taps = 0;

        void OnTapped(object sender, EventArgs e)
        {
            taps++;
            var img = (Image)sender;
        }
	}
}

