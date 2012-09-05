using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SoftDustMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri("http://blog.ianlee.info/p/projects.html?m=1", UriKind.Absolute));
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri("http://blog.ianlee.info/?m=1", UriKind.Absolute));
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri("http://blog.ianlee.info/p/contact-me.html?m=1", UriKind.Absolute));
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/YourLastAboutDialog;component/AboutPage.xaml", UriKind.Relative));
        }
    }
}