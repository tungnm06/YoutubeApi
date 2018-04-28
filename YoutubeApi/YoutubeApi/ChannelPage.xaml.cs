using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace YoutubeApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChannelPage : Page
    {
        public string kidChannel = "UCGk3yw5k_xQUS_KSDCC6Nhw";
        public string babyChannel = "UCVA9wu4h1lLIPQo9wkJdg7w";
        public string phimhaiChannel = "UC85--fF4Z_BKqXx-xB50L6A";
        public string hanhdongChannel = "UCvgbP5jsSQM8OgYqOSjXYCg";
        public string bigbangChannel = "UCOaNiYRtB7EN6XLJQ8JcsVw";
        public string zingChannel = "UCKaO3GcTYEZbaSuPXYMvnCQ";
        public string tintucChannel = "UC8dJFta6zfvkY2LklEcYoQg";
        public string sportChannel = "UCIWo7q6irZUBaoPOrlf5IVw";
        public string vtvnewChannel = "UCCZZuYT8pZED_3bNasz7RdA";
        public string thoisuChannel = "UCAjyH5D6veXBQanc8GPCDrg";
        
        public ChannelPage()
        {
            this.InitializeComponent();
        }

        private void btnKid_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), kidChannel);

        }

        private void btnBaby_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), babyChannel);

        }

        private void btnBigBang_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), bigbangChannel);

        }

        private void btnZing_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), zingChannel);

        }

        private void btnPhimHai_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), phimhaiChannel);
        }

        private void btnHanhDong_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), hanhdongChannel);

        }

        private void btnTinTuc_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), tintucChannel);

        }

        private void btnOnSport_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), sportChannel);
        }

        private void btnVtvNews_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), vtvnewChannel);

        }

        private void btnThoiSu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), thoisuChannel);

        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PlayVideo2));

        }
    }
}
