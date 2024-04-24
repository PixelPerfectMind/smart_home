using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace SmartHomeControlFrontend.Dialogs
{
    /// <summary>
    /// Interaktionslogik für ConnectingIndicator.xaml
    /// </summary>
    public partial class ConnectingIndicator : Window
    {
        public ConnectingIndicator()
        {
            InitializeComponent();
        }

        private void txt_windowTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        public async void CloseWindow()
        {
            // Perform button click
            btn_close.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

            await Task.Delay(150);
            Close();
        }
    }
}
