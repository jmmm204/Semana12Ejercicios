using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoBonificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txtSueldo.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
        }

        // Validacion para permitir solo numeros
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validacion para permitir solo letras
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parsear el sueldo basico
                decimal sueldoBasico = decimal.Parse(txtSueldo.Text);

                // Calcular la bonificacion segun el porcentaje seleccionado
                decimal porcentajeBonificacion = ObtenerBonificacionPorcentaje();
                decimal bonificacion = sueldoBasico * porcentajeBonificacion;
                txtBonificacion.Text = bonificacion.ToString("F2");

                // Calcular la retencion (5%) solo si el sueldo basico es >= 10000
                decimal retencion = sueldoBasico >= 10000 ? sueldoBasico * 0.05M : 0;
                txtRetencion.Text = retencion.ToString("F2");

                // Calcular el total a recibir
                decimal totalRecibir = sueldoBasico + bonificacion - retencion;
                txtTotal.Text = totalRecibir.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funcion para obtener el porcentaje de bonificacion
        private decimal ObtenerBonificacionPorcentaje()
        {
            if (rad10.Checked) return 0.10M;
            if (rad20.Checked) return 0.20M;
            if (rad35.Checked) return 0.35M;
            return 0.0M;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSueldo.Clear();
            txtBonificacion.Clear();
            txtRetencion.Clear();
            txtTotal.Clear();

            rad10.Checked = false;
            rad20.Checked = false;
            rad35.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string nombreCompleto = "Jose Maria Moncada Maya";
            string fecha = DateTime.Now.ToString("06/11/2024");

            MessageBox.Show($"Nombre: {nombreCompleto}\nFecha: {fecha}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}