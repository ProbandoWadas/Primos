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

namespace Primos
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

        private void btnProcesar_Click(object sender, RoutedEventArgs e)
        {
            var numeroMayor = Convert.ToInt32(txtNumeroMayor.Text);
            var retorno = new List<int>();

            for (var i = 1; i <= numeroMayor; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        continue;
                    }
                    if (i % j == 0)
                    {
                    }
                    retorno.Add(i);
                }
            }
            dgPrimos.ItemsSource = retorno;
        }
    }
}
