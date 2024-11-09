using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SueldoDeEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string cargo;
            cargo = cmbCargo.Text;
            if (cargo == "Gerente")
            {
                txtSueldo.Text = "12,500";
            }
            if (cargo == "Administrador")
            {
                txtSueldo.Text = "10,000";
            }
            if (cargo == "Secretaria")
            {
                txtSueldo.Text = "5,500";
            }
            if (cargo == "Contador")
            {
                txtSueldo.Text = "6,000";
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbCargo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
