namespace Formulario_1
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
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnMotocicleta = new System.Windows.Forms.Button();
            this.btnCuatrimoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(343, 63);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(89, 48);
            this.btnVehiculo.TabIndex = 0;
            this.btnVehiculo.Text = "Vehiculo ";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnMotocicleta
            // 
            this.btnMotocicleta.Location = new System.Drawing.Point(343, 117);
            this.btnMotocicleta.Name = "btnMotocicleta";
            this.btnMotocicleta.Size = new System.Drawing.Size(89, 44);
            this.btnMotocicleta.TabIndex = 1;
            this.btnMotocicleta.Text = "Motocicleta ";
            this.btnMotocicleta.UseVisualStyleBackColor = true;
            this.btnMotocicleta.Click += new System.EventHandler(this.btnMotocicleta_Click_1);
            // 
            // btnCuatrimoto
            // 
            this.btnCuatrimoto.Location = new System.Drawing.Point(343, 167);
            this.btnCuatrimoto.Name = "btnCuatrimoto";
            this.btnCuatrimoto.Size = new System.Drawing.Size(89, 47);
            this.btnCuatrimoto.TabIndex = 2;
            this.btnCuatrimoto.Text = "Cuatrimoto ";
            this.btnCuatrimoto.UseVisualStyleBackColor = true;
            this.btnCuatrimoto.Click += new System.EventHandler(this.btnCuatrimoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCuatrimoto);
            this.Controls.Add(this.btnMotocicleta);
            this.Controls.Add(this.btnVehiculo);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnMotocicleta;
        private System.Windows.Forms.Button btnCuatrimoto;
    }
}

