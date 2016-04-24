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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _50_Nursery_Rhymes_For_Kids
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private object playlistView;

        public int Assets { get; private set; }

        private void abcd_Click(object sender, RoutedEventArgs e)
        {
            var song6 = new SongModel();
            song6.Title = "song 6";
            song6.MediaUri = new Uri("Assets / song / abcdefg.mp3");
            playlistView.songs.Add(song6);




            

        }

        private void blacksheep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void chuby_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dingdong_Click(object sender, RoutedEventArgs e)
        {

        }

        private void earlytobed_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rusleeping_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }

