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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calcularButton.IsEnabled = false;
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            double resultado = 0;
            try
            {
                if (operadorTextBox.Text.Equals("+"))
                {
                    resultado = double.Parse(operando1TextBox.Text) + double.Parse(operando2TextBox.Text);
                }
                else if (operadorTextBox.Text.Equals("-"))
                {
                    resultado = double.Parse(operando1TextBox.Text) - double.Parse(operando2TextBox.Text);
                }
                else if (operadorTextBox.Text.Equals("*"))
                {
                    resultado = double.Parse(operando1TextBox.Text) * double.Parse(operando2TextBox.Text);
                }
                else if (operadorTextBox.Text.Equals("/"))
                {
                    resultado = double.Parse(operando1TextBox.Text) / double.Parse(operando2TextBox.Text);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error. Introduzca unos datos validos");
            }
            resultadoTextBox.Text = resultado.ToString();
        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operadorTextBox.Text.Equals("+") || operadorTextBox.Text.Equals("-") || 
                operadorTextBox.Text.Equals("*") || operadorTextBox.Text.Equals("/"))
            {
                calcularButton.IsEnabled = true;

            }
            else
            {
                calcularButton.IsEnabled = false;

            }

        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operadorTextBox.Text = "";
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            resultadoTextBox.Text = "";
        }
    }
}
