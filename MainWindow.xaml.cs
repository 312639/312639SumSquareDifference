/* Cameron Heinz
 * Project Euler Problem # 6
 * Sum Square Difference
 * June 17,2019*/
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

namespace _312639SumSquareDifference
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double sum = 0;
            double squared = 0;
            double result = 0;

            const int i = 100;

            sum = i * (i + 1) / 2;
            squared = (i * (i + 1) * (2 * i + 1)) / 6;

            result = sum * sum - squared;

            lblOutput.Content = result;




        }
    }
}
