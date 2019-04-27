namespace QRbackend
{
    partial class Menu
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(335, 361);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 44);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Back";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_admin.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(421, 235);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(207, 55);
            this.btn_admin.TabIndex = 8;
            this.btn_admin.Text = "Manage inventory";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_datos
            // 
            this.btn_datos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_datos.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos.Location = new System.Drawing.Point(421, 166);
            this.btn_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(207, 55);
            this.btn_datos.TabIndex = 7;
            this.btn_datos.Text = "View Data";
            this.btn_datos.UseVisualStyleBackColor = false;
            this.btn_datos.Click += new System.EventHandler(this.btn_datos_Click);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_devolucion.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion.Location = new System.Drawing.Point(143, 235);
            this.btn_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(207, 55);
            this.btn_devolucion.TabIndex = 6;
            this.btn_devolucion.Text = "Return";
            this.btn_devolucion.UseVisualStyleBackColor = false;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click);
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_prestamo.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prestamo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_prestamo.Location = new System.Drawing.Point(143, 166);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(207, 55);
            this.btn_prestamo.TabIndex = 5;
            this.btn_prestamo.Text = "Lend";
            this.btn_prestamo.UseVisualStyleBackColor = false;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_prestamo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(774, 541);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_datos);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.btn_prestamo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Button btn_prestamo;
    }
}