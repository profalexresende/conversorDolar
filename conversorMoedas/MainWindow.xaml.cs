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

namespace conversorMoedas
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

        private void btnConverter_Click(object sender, RoutedEventArgs e)
        {
            double dolares, reais,vDolar;
                     
            //entrada de dados
            dolares = Convert.ToDouble(txtValorDolares.Text);
            vDolar = Convert.ToDouble(txtVDolar.Text);

            //conversão
            reais = dolares * vDolar;

            //saída
            lblValorReais.Content = "R$" + reais.ToString("0.00");//arredondar casas
        }
    }
}
