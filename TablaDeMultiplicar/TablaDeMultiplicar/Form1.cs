using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaDeMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asignar evento KeyPress al TextBox

            txtNumero.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
        }

        // Funcion que solo permite numeros
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, numero, resultado;
            numero = int.Parse(txtNumero.Text);
            for (i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                lstTabla.Items.Add(numero + " * " + i + "= " + resultado);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstTabla.Items.Clear();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
