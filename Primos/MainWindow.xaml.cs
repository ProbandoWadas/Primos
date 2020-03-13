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

        #region Botones

        private void btnProcesar_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            var numeroMayor = Convert.ToInt32(txtNumeroMayor.Text);
            List<int> retorno = ObtienePrimos(numeroMayor).ToList();

            AgregarPrimosIniciales(ref retorno);
            cargarData(lista, retorno);
        }
        private void btnProcesar_Copy_Click(object sender, RoutedEventArgs e)
        {
            lista_Copy.Items.Clear();
            var numeroMayor = Convert.ToInt32(txtNumeroMayor_Copy.Text);
            List<int> retorno = ObtienePrimos(numeroMayor).ToList();

            AgregarPrimosIniciales(ref retorno);

            cargarData(lista_Copy, retorno);
        }
        #endregion

        #region Privados
        private void cargarData(ListBox lista, List<int> retorno)
        {
            retorno.ForEach(primo => lista.Items.Add(primo));
        }

        private ICollection<int> ObtienePrimos(int maximo)
        {
            var retorno = new List<int>();

            for (var i = 1; i <= maximo; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        continue;
                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (!retorno.Exists(x => x == i))
                    { retorno.Add(i); }
                }
            }
            return retorno;
        }
        private void AgregarPrimosIniciales(ref List<int> retorno)
        {
            retorno.Insert(0, 2);
            retorno.Insert(0, 1);
        }
        #endregion

    }
}
