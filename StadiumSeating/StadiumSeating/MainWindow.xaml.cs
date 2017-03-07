using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StadiumSeating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {           int classA=0;
                int classB = 0;
                int classC = 0;
                int total = 0;  
        public MainWindow()
        {
            InitializeComponent();
        }
    private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                classA = int.Parse(textBox.Text) * 15;
                label.Content = classA;
                classB = int.Parse(textBox1.Text) * 10;
                label1.Content = classB;
                classC = int.Parse(textBox2.Text) * 9;
                label2.Content = classC;
                total = classA + classB + classC;
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a number");
            }
            label3.Content = total;
        }
    }
}
