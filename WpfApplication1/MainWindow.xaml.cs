using System.IO;
using System.Text;
using System.Windows;

namespace WpfApplication1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sr = new StreamReader(@"C:\Users\Ilya\Documents\GitHub\DataBase\UserName.txt", Encoding.ASCII);
            string text = sr.ReadToEnd();
            if (text == UserName.Text)
            {
                var window1 = new Window1();
                window1.Show(); //Navigation window call

                Close(); // close start window after call
            }
            else MessageBox.Show("Error!");

        }
    }
}
