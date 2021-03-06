using App10.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ServerManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ServerPage : Page
    {
        public String id;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.id = (String)e.Parameter;
            NavView.Header = this.id;
            base.OnNavigatedTo(e);
        }

        public ServerPage()
        {
            this.InitializeComponent();

        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            String name = (String)args.SelectedItemContainer.Content;
            NavView.Header = name;
            switch (name)
            {
                case "Configuration":
                    NavigateTo(typeof(Views.Server.HomePage));
                    break;
                case "Worlds":

                    break;
                case "Plugins":

                    break;

            }
        }

        private void NavigateTo(Type type)
        {
            ContentFrame.Navigate(type,null, new DrillInNavigationTransitionInfo());
        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            MainWindow.NavigateTo(typeof(MainPage));
        }
    }



}
