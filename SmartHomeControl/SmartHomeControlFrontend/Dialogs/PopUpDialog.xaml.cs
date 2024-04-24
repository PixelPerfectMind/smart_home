using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace SmartHomeControlFrontend.Dialogs
{
    public partial class PopUpDialog : Window
    {
        public PopUpDialog(string message, string title="", PopUpDialogKind? popUpDialogKind=PopUpDialogKind.None)
        {
            InitializeComponent();
            txt_message.Text = message;
            if(!string.IsNullOrEmpty(title)) txt_windowTitle.Text = title;
            if (popUpDialogKind == PopUpDialogKind.None) img_symbol.Visibility = Visibility.Collapsed;
            else
            {
                img_symbol.Visibility = Visibility.Visible;
                switch (popUpDialogKind)
                {
                    case PopUpDialogKind.Question:
                        img_symbol.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Image/qestion-mark.png"));
                        
                        break;
                    case PopUpDialogKind.Information:
                        img_symbol.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Image/information.png"));
                        btn_yes.Content = "OK";
                        btn_no.Visibility = Visibility.Collapsed;
                        break;
                    case PopUpDialogKind.Warning:
                        img_symbol.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Image/warning.png"));
                        btn_yes.Content = "OK";
                        btn_no.Visibility = Visibility.Collapsed;
                        break;
                    case PopUpDialogKind.Error:
                        img_symbol.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Image/error.png"));
                        btn_yes.Content = "OK";
                        btn_no.Visibility = Visibility.Collapsed;
                        break;
                }
            }
        }

        public enum PopUpDialogKind
        {
            None,
            Question,
            Information,
            Warning,
            Error
        }

        private void txt_windowTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        public bool Result { get; set; } = false;

        private async void btn_no_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
            await Task.Delay(150);
            Close();
        }

        private async void btn_yes_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
            await Task.Delay(150);
            Close();
        }
    }
}
