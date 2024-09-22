using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRangoInicial.Text, out int x) && int.TryParse(txtRangoFin.Text, out int y))
            {
                lstNumeros.Items.Clear();
                if (x <= y)
                {
                    for (int i = x; i <= y; i++)
                    {
                        lstNumeros.Items.Add(i.ToString());
                    }
                }
                else
                {
                    for (int i = y; i <= x; i++)
                    {
                        lstNumeros.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce numeros validos para x e y");
                txtRangoInicial.Text = string.Empty;
                txtRangoFin.Text = string.Empty;
                lstNumeros.Items.Clear ();
                txtRangoInicial.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRangoInicial.Text = string.Empty;
            txtRangoFin.Text = string.Empty;
            lstNumeros.Items.Clear();
            txtRangoInicial.Focus();
        }
    }
}
