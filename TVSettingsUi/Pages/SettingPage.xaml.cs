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

namespace TVSettingsUi.Pages
{
    /// <summary>
    /// Interaction logic for SettingPage.xaml
    /// </summary>
    public partial class SettingPage : UserControl
    {
        private MainWindow window;


        public SettingPage()
        {
            InitializeComponent();
        }


        private void LoadWindow()
        {
            if (window == null)
            {
                window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            }
        }
        private void NetworkSetting_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Network);
        }

        private void Time_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Time);
        }

    }
}
