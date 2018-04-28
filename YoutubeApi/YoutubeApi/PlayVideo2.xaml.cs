using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
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
    public sealed partial class PlayVideo2 : Page
    {
        public PlayVideo2()
        {
            this.InitializeComponent();
           
        }
        private async void openFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var FileOpen = new FileOpenPicker();
                FileOpen.SuggestedStartLocation = PickerLocationId.MusicLibrary;
                FileOpen.FileTypeFilter.Add(".mp3");
                FileOpen.FileTypeFilter.Add(".mp4");

                FileOpen.FileTypeFilter.Add(".WMA");
                var File = await FileOpen.PickSingleFileAsync();
                var stream = await File.OpenAsync(Windows.Storage.FileAccessMode.Read);
                Myplayer.SetSource(stream, File.ContentType);
                Myplayer.Play();
                InitializePropertyValues();

            }
            catch (Exception ex)
            {

                MessageDialog message = new MessageDialog("Please select any media file !");
                message.ShowAsync();

            }
        }
        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChannelPage), new object());
        }
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Myplayer.Play();
            InitializePropertyValues();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            Myplayer.Pause();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Myplayer.Stop();
        }
        private void ChangeMediaVolume(object sender, RangeBaseValueChangedEventArgs e)
        {
            Myplayer.Volume = (double)volumeSlider.Value;
        }
        void InitializePropertyValues()
        {

            Myplayer.Volume = (double)volumeSlider.Value;
        }
    }
}
