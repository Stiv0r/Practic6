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

namespace Zad3
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
        private double TriangleB(double a, double h)
        {
            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
            return b;
        }

        private double TriangleP(double a, double h)
        {
            double b = TriangleB(a, h);
            double p = 2 * b + a;
            return p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(aTextBox.Text);
            double h = double.Parse(hTextBox.Text);
            double p = TriangleP(a, h);

            resultLabel.Content = $"Периметр: {p}";
        }
    }

}

