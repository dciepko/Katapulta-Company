using System.Windows;
using System.Windows.Controls;

namespace LogInAp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (pass.Password == "test" && user.Text == "user")
            {
                SortWindow sortWindow = new SortWindow();
                sortWindow.Show();
            }
            else
            {
                MessageBox.Show("unaccteable username or password");
            }
        }
    }
}
