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

namespace Zad2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int f(int x)
        {
            int a = x / 100;
            int b = (x / 10) % 10;
            int c = x % 10;

            return c * 100 + b * 10 + a;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(inputTextBox.Text);
            int result = f(input);

            resultLabel.Content = $"Результат: {result}";
        }
    }


}
