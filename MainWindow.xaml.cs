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

namespace Practic6Pav
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
        private int min(int a, int b)
        {
            return (a < b) ? a : b;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(xTextBox.Text);
            int y = int.Parse(yTextBox.Text);
            int z = int.Parse(zTextBox.Text);
            int v = int.Parse(vTextBox.Text);

            int min1 = min(x, y);
            int min2 = min(z, v);
            int result = min(min1, min2);

            resultLabel.Content = $"Минимальное значение: {result}";
        }
    }
}