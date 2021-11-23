using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using ServerManager;
using ServerManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App10.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainWindow.frame.Navigate(typeof(ServerPage), "lol", new DrillInNavigationTransitionInfo());
        }
    }

    public class ServerItem
    {

        public String Name { get; set; }
        public String Description { get; set; }


        public ServerItem(String name, String description)
        {
            this.Name = name;
            this.Description = description;
        }

    }

    public class ServerItemList : ObservableCollection<ServerItem>
    {
        public ServerItemList()
        {
            Add(new ServerItem("Server with my Friends", "Description"));
            Add(new ServerItem("Server with my Friends", "Description"));
            Add(new ServerItem("Server with my Friends", "Description"));
        }
    }

}


