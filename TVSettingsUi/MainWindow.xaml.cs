﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TVSettingsUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// init all pages just one time 
        /// </summary>
        private Pages.SettingPage settingPage = new Pages.SettingPage();
        private Pages.AboutPage aboutPage = new Pages.AboutPage();
        private Pages.StoragePage storagePage = new Pages.StoragePage();
        private Pages.TimePage timePage = new Pages.TimePage();
        private Pages.NetworkPage networkPage = new Pages.NetworkPage();

        public MainWindow()
        {
            InitializeComponent();
        }
        public void ExecutePage(AppPages page)
        {
            backButton.Visibility = Visibility.Visible;

            switch (page)
            {
                case AppPages.About:
                    container.Content = aboutPage;
                    titleText.Text = "About Us";
                    break;
                case AppPages.Setting:
                    container.Content = settingPage;
                    titleText.Text = "Settings";
                    break;
                case AppPages.Storage:
                    container.Content = storagePage;
                    titleText.Text = "Storage";
                    break;
                case AppPages.Time:
                    container.Content = timePage;
                    titleText.Text = "Time Settings";
                    break;
                case AppPages.Network:
                    container.Content = networkPage;
                    titleText.Text = "Network Settings";
                    break;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            container.Content = settingPage;
            backButton.Visibility = Visibility.Collapsed;
            titleText.Text = "Settings";
        }

    }
}
