using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) && double.TryParse(txtNumero2.Text, out double numero2))
            {
                //MessageBox.Show("Los textBox tienen un numero");
                string operacion = cmbOperacion.SelectedItem.ToString();
                double resultado = 0;
                bool operacionValida = true;

                switch (operacion)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            MessageBox.Show("Error: no se puede dividir por cero");
                            operacionValida = false;
                            txtNumero2.Text = string.Empty;
                            txtNumero2.Focus();
                        }
                        break;
                    default:
                        MessageBox.Show("Seleccione una operacion valida");
                        operacionValida = false;
                        cmbOperacion.Focus();
                        break;

                }

                if (operacionValida)
                {
                    lblResultado.Text = "Resultado: " + resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce numeros validos");
                txtNumero1.Text = string.Empty;
                txtNumero2.Text = string.Empty;
                txtNumero1.Focus();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = "Resultado: ";
            txtNumero1.Focus();
        }
    }
}
