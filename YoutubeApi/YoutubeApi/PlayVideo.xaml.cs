using Google.Apis.YouTube.v3.Data;
using MyToolkit.Multimedia;
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
using static YoutubeApi.MainPage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace YoutubeApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlayVideo : Page
    {
      //  Video video;
        String id;
        String idchannel = null;
        String idvideo = null;
        public PlayVideo()
        {
            this.InitializeComponent();
        }
      

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            DataPage datapage = e.Parameter as DataPage;
          //  id = e.Parameter as String;
            var Url = await YouTube.GetVideoUriAsync(datapage.idVideo, YouTubeQuality.Quality1080P);
            Player.Source = Url.Uri;
            idchannel = datapage.idChannel;
        }
        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), idchannel);
        }
    }
}

