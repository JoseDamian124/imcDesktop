using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace imcDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Brush SetColorEstadoNutricional(decimal imc)
        {
        if (imc < 18.5M)
            {
                return Brushes.Yellow;
            }
        else if (imc < 25.0M)
            {
                return Brushes.Green;
            }
        else if (imc < 30.0M)
            {
                return Brushes.Yellow;
            }
        else if (imc < 40.0M)
            {
                return Brushes.Orange;
            }
            else
            {
                return Brushes.Red;
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            pesotextbox.Focus();
        }

        private void calculadoraButton_Click(object sender, RoutedEventArgs e)
        {
            string s = pesotextbox.Text;
            decimal peso = Convert.ToDecimal(s);
            s = Estaturatextbox.Text;
            decimal estatura = Convert.ToDecimal(s);
            decimal imc = peso / (estatura * estatura);
            imcTextBlock.Text = string.Format("{0:.0000}", imc);
            imcTextBlock.Foreground = SetColorEstadoNutricional(imc);
            situacionTextBlock.Text = EstadoNutricional(imc);
            situacionTextBlock.Foreground = SetColorEstadoNutricional(imc);
            limpiarButton.Focus();


        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            pesotextbox.Text = "";
            Estaturatextbox.Text = "";
            imcTextBlock.Text = "0.0";
            imcTextBlock.Foreground = Brushes.Black;
            situacionTextBlock.Text = "";
            situacionTextBlock.Foreground = Brushes.Black;
            pesotextbox.Focus();
                
        }

        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private string EstadoNutricional(decimal imc)
        {
            if(imc < 18.5M)
            {
                return "peso bajo";

            }
            else if (imc < 25.0M)
            {
                return "peso normal";
            }
            else if (imc < 30.0M)
            {
                return "Sobrepeso";
            }
            else if (imc < 40.0M)
            {
                return "Obesidad";

            }
            else
            {
                return "Obesisdad extrema";
            }
        }





    }
}
