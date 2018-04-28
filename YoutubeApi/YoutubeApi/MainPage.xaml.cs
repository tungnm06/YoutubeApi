using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using YoutubeApi.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace YoutubeApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String channelID;
        String idchannel = null;
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            channelID = e.Parameter as String;
            GetVideo(channelID);
            idchannel = channelID;


           // base.OnNavigatedTo(e);

        }
        private YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey= "AIzaSyALuDo5Y9Z3qu3ivnAQvWCFQcLJBORx16Q",
            ApplicationName= "youtube"
        });
        List<Video> ListVideo = new List<Video>();
        private string TokenNextPage = null, TokenPrivPage = null;

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        public class DataPage
        {
            public string idChannel { get; set; }
            public string idVideo { get; set; }
        }



        private async void GetVideo(string channelID1)
        {
            string PageToken = null;
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    var Request = youtubeService.Search.List("snippet");
                    Request.ChannelId = channelID1;

                    Request.MaxResults = 25;
                    Request.Type = "video";
                    Request.Order = SearchResource.ListRequest.OrderEnum.Date;
                    Request.PageToken = PageToken;
                    var Result = await Request.ExecuteAsync();
                    if (Result.NextPageToken != null)
                        TokenNextPage = Result.NextPageToken;
                    if (Result.PrevPageToken != null)
                        TokenPrivPage = Result.PrevPageToken;

                    foreach (var item in Result.Items)
                    {
                        ListVideo.Add(new Video
                        {
                            Title = item.Snippet.Title,
                            Id = item.Id.VideoId,
                            Img = item.Snippet.Thumbnails.Default__.Url

                        });
                    }
                    lv.ItemsSource = null;
                    lv.ItemsSource = ListVideo;
                }
                else
                {
                    MessageDialog message = new MessageDialog("You are not connection Internet! ");
                    await message.ShowAsync();
                }
            }
            catch { }
       



        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChannelPage), new object());

        }

        private void lv_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Video video = e.ClickedItem as Video;
            DataPage datapage = new DataPage();
            datapage.idVideo = video.Id;
            datapage.idChannel = idchannel;
            Frame.Navigate(typeof(PlayVideo), datapage);

        }


    }
}
