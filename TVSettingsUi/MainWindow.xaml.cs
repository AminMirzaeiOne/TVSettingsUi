using System;
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
    }
}
