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

namespace gitTaak1
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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Color color = Colors.Red;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            colorCodeTextBox.Text = colorCode;
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Color color = Colors.Yellow;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            colorCodeTextBox.Text = colorCode;
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Color color= Colors.Green;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            colorCodeTextBox.Text = colorCode;
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            Color color = Colors.Blue;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            colorCodeTextBox.Text = colorCode;
        }
    }
}