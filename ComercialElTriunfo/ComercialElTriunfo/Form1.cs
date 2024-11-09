using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialElTriunfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asignar eventos KeyPress a los TextBox
            txtCodigo.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtPrecio.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtCantidad.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtNombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
        }

        // Funcion que solo permite numeros
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un dígito o una tecla de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Rechaza el carácter si no es número o control
            }
        }

        // Función que solo permite letras
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es una letra o una tecla de control (como Backspace o Espacio)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Rechaza el carácter si no es letra, espacio o control
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = "Jose Maria Moncada Maya";
            string fecha = DateTime.Now.ToString("06/11/2024");

            MessageBox.Show($"Nombre: {nombreCompleto}\nFecha: {fecha}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtIVA.Clear();
            txtTotal.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Declarar variables precio y cantidad
                decimal precio = decimal.Parse(txtPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                // Calcular subtotal
                decimal subtotal = precio * cantidad;
                txtSubtotal.Text = subtotal.ToString("F2");

                // Calcular descuento
                decimal porcentajeDescuento = ObtenerPorcentajeDescuento();
                decimal descuento = subtotal * porcentajeDescuento;
                txtDescuento.Text = descuento.ToString("F2");

                // Calcular IVA
                decimal iva = subtotal * 0.15M;
                txtIVA.Text = iva.ToString("F2");

                // Calcular total
                decimal total = subtotal - descuento + iva;
                txtTotal.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ObtenerPorcentajeDescuento()
        {
            if (rad0.Checked) return 0.0M;
            if (rad1.Checked) return 0.01M;
            if (rad5.Checked) return 0.05M;
            if (rad10.Checked) return 0.10M;
            if (rad15.Checked) return 0.15M;
            return 0.0M;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos leidos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}