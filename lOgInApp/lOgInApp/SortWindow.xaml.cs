using lOgInApp;
using System.Windows;

namespace LogInAp
{
    /// <summary>
    /// Interaction logic for SortWindow.xaml
    /// </summary>
    public partial class SortWindow : Window
    {
        public SortWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sort.InsertionSort(Input, Output);
        }
    }
}
