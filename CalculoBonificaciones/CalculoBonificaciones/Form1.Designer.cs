namespace CalculoBonificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.grpBonificacion = new System.Windows.Forms.GroupBox();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.rad35 = new System.Windows.Forms.RadioButton();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.lblRetencion = new System.Windows.Forms.Label();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.txtRetencion = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpBonificacion.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(184, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de Bonificaciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(62, 89);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(178, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del empleado:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(62, 128);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(122, 18);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo Basico:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(276, 88);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 21);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(276, 127);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 21);
            this.txtSueldo.TabIndex = 4;
            // 
            // grpBonificacion
            // 
            this.grpBonificacion.Controls.Add(this.rad35);
            this.grpBonificacion.Controls.Add(this.rad20);
            this.grpBonificacion.Controls.Add(this.rad10);
            this.grpBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBonificacion.Location = new System.Drawing.Point(64, 193);
            this.grpBonificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpBonificacion.Name = "grpBonificacion";
            this.grpBonificacion.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpBonificacion.Size = new System.Drawing.Size(144, 162);
            this.grpBonificacion.TabIndex = 5;
            this.grpBonificacion.TabStop = false;
            this.grpBonificacion.Text = "Bonificacion";
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad10.Location = new System.Drawing.Point(28, 32);
            this.rad10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(53, 19);
            this.rad10.TabIndex = 0;
            this.rad10.TabStop = true;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad20.Location = new System.Drawing.Point(28, 75);
            this.rad20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(53, 19);
            this.rad20.TabIndex = 1;
            this.rad20.TabStop = true;
            this.rad20.Text = "20%";
            this.rad20.UseVisualStyleBackColor = true;
            // 
            // rad35
            // 
            this.rad35.AutoSize = true;
            this.rad35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad35.Location = new System.Drawing.Point(28, 118);
            this.rad35.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rad35.Name = "rad35";
            this.rad35.Size = new System.Drawing.Size(53, 19);
            this.rad35.TabIndex = 2;
            this.rad35.TabStop = true;
            this.rad35.Text = "35%";
            this.rad35.UseVisualStyleBackColor = true;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnSalir);
            this.grpAcciones.Controls.Add(this.btnLimpiar);
            this.grpAcciones.Controls.Add(this.btnCalcular);
            this.grpAcciones.Location = new System.Drawing.Point(457, 193);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpAcciones.Size = new System.Drawing.Size(230, 162);
            this.grpAcciones.TabIndex = 6;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(40, 22);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 27);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(40, 68);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 27);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(40, 114);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 27);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonificacion.Location = new System.Drawing.Point(51, 380);
            this.lblBonificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(96, 16);
            this.lblBonificacion.TabIndex = 7;
            this.lblBonificacion.Text = "Bonificacion:";
            // 
            // lblRetencion
            // 
            this.lblRetencion.AutoSize = true;
            this.lblRetencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetencion.Location = new System.Drawing.Point(51, 416);
            this.lblRetencion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetencion.Name = "lblRetencion";
            this.lblRetencion.Size = new System.Drawing.Size(106, 16);
            this.lblRetencion.TabIndex = 8;
            this.lblRetencion.Text = "Retencion 5%:";
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Enabled = false;
            this.txtBonificacion.Location = new System.Drawing.Point(243, 377);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.ReadOnly = true;
            this.txtBonificacion.Size = new System.Drawing.Size(100, 21);
            this.txtBonificacion.TabIndex = 9;
            // 
            // txtRetencion
            // 
            this.txtRetencion.Enabled = false;
            this.txtRetencion.Location = new System.Drawing.Point(243, 413);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.ReadOnly = true;
            this.txtRetencion.Size = new System.Drawing.Size(100, 21);
            this.txtRetencion.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(40, 464);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 18);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total a recibir:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(243, 463);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(753, 501);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtRetencion);
            this.Controls.Add(this.txtBonificacion);
            this.Controls.Add(this.lblRetencion);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpBonificacion);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Comercial \"El Triunfo\"";
            this.grpBonificacion.ResumeLayout(false);
            this.grpBonificacion.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.GroupBox grpBonificacion;
        private System.Windows.Forms.RadioButton rad35;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label lblRetencion;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.TextBox txtRetencion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

