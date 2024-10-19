using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControleStructuren5__Machtsverheffing
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextbox.Text, out int number);

            for (int i = 1; i <= 10; i++) 
            {
                resultTextbox.Text += $"Macht {i} van {number} is {Math.Pow(number, i)}\n";
            }




        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextbox.Clear();
            resultTextbox.Clear() ;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}