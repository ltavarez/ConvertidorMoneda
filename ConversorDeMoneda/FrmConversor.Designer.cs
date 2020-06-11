namespace ConversorDeMoneda
{
    partial class FrmConversor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.lblCantidadConvertir = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cbxMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.cbxMonedaDestino = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaOrigen.Location = new System.Drawing.Point(54, 36);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(128, 20);
            this.lblMonedaOrigen.TabIndex = 0;
            this.lblMonedaOrigen.Text = "Moneda origen";
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaDestino.Location = new System.Drawing.Point(45, 77);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(137, 20);
            this.lblMonedaDestino.TabIndex = 1;
            this.lblMonedaDestino.Text = "Moneda destino";
            // 
            // lblCantidadConvertir
            // 
            this.lblCantidadConvertir.AutoSize = true;
            this.lblCantidadConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConvertir.Location = new System.Drawing.Point(12, 122);
            this.lblCantidadConvertir.Name = "lblCantidadConvertir";
            this.lblCantidadConvertir.Size = new System.Drawing.Size(170, 20);
            this.lblCantidadConvertir.TabIndex = 2;
            this.lblCantidadConvertir.Text = "Cantidad a convertir";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(91, 161);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 122);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(171, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(210, 163);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(171, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // cbxMonedaOrigen
            // 
            this.cbxMonedaOrigen.FormattingEnabled = true;
            this.cbxMonedaOrigen.Location = new System.Drawing.Point(210, 38);
            this.cbxMonedaOrigen.Name = "cbxMonedaOrigen";
            this.cbxMonedaOrigen.Size = new System.Drawing.Size(171, 21);
            this.cbxMonedaOrigen.TabIndex = 1;
            this.cbxMonedaOrigen.SelectedIndexChanged += new System.EventHandler(this.cbxMonedaOrigen_SelectedIndexChanged);
            // 
            // cbxMonedaDestino
            // 
            this.cbxMonedaDestino.FormattingEnabled = true;
            this.cbxMonedaDestino.Location = new System.Drawing.Point(210, 77);
            this.cbxMonedaDestino.Name = "cbxMonedaDestino";
            this.cbxMonedaDestino.Size = new System.Drawing.Size(171, 21);
            this.cbxMonedaDestino.TabIndex = 2;
            this.cbxMonedaDestino.SelectedIndexChanged += new System.EventHandler(this.cbxMonedaDestino_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(169, 213);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // FrmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 280);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cbxMonedaDestino);
            this.Controls.Add(this.cbxMonedaOrigen);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCantidadConvertir);
            this.Controls.Add(this.lblMonedaDestino);
            this.Controls.Add(this.lblMonedaOrigen);
            this.Name = "FrmConversor";
            this.Text = "Convertidor de moneda";
            this.Load += new System.EventHandler(this.FrmConversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.Label lblCantidadConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cbxMonedaOrigen;
        private System.Windows.Forms.ComboBox cbxMonedaDestino;
        private System.Windows.Forms.Button btnConvertir;
    }
}

