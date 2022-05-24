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

namespace MTKrusheelHirpara
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int t, t1, t2, t3, t4, t5;
        public MainWindow()
        {
            InitializeComponent();
            int.TryParse(textBox.ToString(),out t);
        }


        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            label2.Content = "Gross Sales :";
            label3.Content = "Comission Rate :";
            label3.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            label2.Content = "Weekly Salary :";
            label3.Visibility = Visibility.Hidden;
            textBox2.Visibility = Visibility.Hidden;
        }

        private void radioButton_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton.IsChecked == true)
            {
                label2.Content = "Hours Worked :";
                label3.Content = "Hourly Wage :";
                label3.Visibility = Visibility.Visible;
                textBox2.Visibility = Visibility.Visible;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            radioButton.IsChecked = true;
            label2.Content = "Gross Sales :";
            label3.Content = "Comission Rate :";
            label3.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            textBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton.IsChecked == true)
            {
                HourlyEmployee HE = new HourlyEmployee();
                HE.Show_Calculation();
                textBox.Text = t.ToString();
            }
        }
    }
}
