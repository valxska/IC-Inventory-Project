namespace WindowsFormsApplication1
{
    partial class Fm_main
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
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.Location = new System.Drawing.Point(115, 64);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(153, 35);
            this.btn_prestamo.TabIndex = 0;
            this.btn_prestamo.Text = "Prestamo";
            this.btn_prestamo.UseVisualStyleBackColor = true;
            this.btn_prestamo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(292, 119);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(153, 35);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Administrar";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_datos
            // 
            this.btn_datos.Location = new System.Drawing.Point(292, 64);
            this.btn_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(153, 35);
            this.btn_datos.TabIndex = 2;
            this.btn_datos.Text = "Visualizar datos";
            this.btn_datos.UseVisualStyleBackColor = true;
            this.btn_datos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Location = new System.Drawing.Point(115, 119);
            this.btn_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(153, 35);
            this.btn_devolucion.TabIndex = 1;
            this.btn_devolucion.Text = "Devolución";
            this.btn_devolucion.UseVisualStyleBackColor = true;
            this.btn_devolucion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(231, 195);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Regresar";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 320);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_datos);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.btn_prestamo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm_main";
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Button btn_exit;
    }
}

