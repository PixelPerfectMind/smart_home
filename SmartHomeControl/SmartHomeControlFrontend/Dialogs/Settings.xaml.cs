using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SmartHomeControlFrontend.Dialogs
{
    /// <summary>
    /// Interaktionslogik für Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            txt_brokerAddress.Text = Properties.Settings.Default.BrokerAddress;
            txt_brokerPort.Text = Properties.Settings.Default.BrokerPort.ToString();
            txt_clientName.Text = Properties.Settings.Default.ClientName;
        }

        private async void ell_closeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(200);
            Close();
        }

        private void txt_windowTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ell_minimizeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.BrokerAddress = txt_brokerAddress.Text;
            Properties.Settings.Default.BrokerPort = int.Parse(txt_brokerPort.Text);
            Properties.Settings.Default.ClientName = txt_clientName.Text;
            Properties.Settings.Default.Save();
            await Task.Delay(200);
            Close();
        }

        private void txt_generateGuid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_clientName.Text = Guid.NewGuid().ToString();
        }
    }
}
