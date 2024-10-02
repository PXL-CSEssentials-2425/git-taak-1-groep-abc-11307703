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
            string colorInfo = "Rood is de kleur van warmte";
            colorCodeTextBox.Text = colorCode;
            colorInfoTextBox.Text = colorInfo;
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Color color = Colors.Yellow;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            string colorInfo = "Geel is de kleur van levenslust";
            colorCodeTextBox.Text = colorCode;
            colorInfoTextBox.Text = colorInfo;
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Color color= Colors.Green;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            string colorInfo = "Groen is de kleur van genezing";

            colorInfoTextBox.Text = colorInfo;
            colorCodeTextBox.Text = colorCode;
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            Color color = Colors.Blue;
            string colorCode = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            string colorInfo = " Blauw is de kleur van intelligentie";

            colorCodeTextBox.Text = colorCode;
            colorInfoTextBox.Text = colorInfo;
        }
      

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Taak1.Background = new SolidColorBrush(Colors.White);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Taak1.Background = new SolidColorBrush(Colors.LightGray);
        }
    }
}