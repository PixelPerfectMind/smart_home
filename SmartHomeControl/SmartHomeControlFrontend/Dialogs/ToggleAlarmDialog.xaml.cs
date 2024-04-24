using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SmartHomeControlFrontend.Dialogs
{
    public partial class ToggleAlarmDialog : Window
    {
        public bool Result { get; private set; } = false;

        public ToggleAlarmDialog()
        {
            InitializeComponent();
        }

        private async void btn_no_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
            await Task.Delay(200);
            Close();
        }

        private async void btn_yes_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
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
    }
}
