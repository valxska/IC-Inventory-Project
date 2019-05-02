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
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addpersonbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_admin.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(393, 234);
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
            this.btn_datos.Location = new System.Drawing.Point(393, 130);
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
            this.btn_devolucion.Location = new System.Drawing.Point(115, 234);
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
            this.btn_prestamo.Location = new System.Drawing.Point(115, 130);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(207, 55);
            this.btn_prestamo.TabIndex = 5;
            this.btn_prestamo.Text = "Lend";
            this.btn_prestamo.UseVisualStyleBackColor = false;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_prestamo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(35, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addpersonbutton
            // 
            this.addpersonbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addpersonbutton.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpersonbutton.Location = new System.Drawing.Point(257, 333);
            this.addpersonbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addpersonbutton.Name = "addpersonbutton";
            this.addpersonbutton.Size = new System.Drawing.Size(207, 55);
            this.addpersonbutton.TabIndex = 10;
            this.addpersonbutton.Text = "Add Person";
            this.addpersonbutton.UseVisualStyleBackColor = false;
            this.addpersonbutton.Click += new System.EventHandler(this.addpersonbutton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.addpersonbutton);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addpersonbutton;
    }
}