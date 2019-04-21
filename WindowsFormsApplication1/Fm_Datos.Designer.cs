namespace WindowsFormsApplication1
{
    partial class Fm_datos
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
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(33, 399);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 35);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Regresar";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_personal
            // 
            this.btn_personal.Location = new System.Drawing.Point(439, 18);
            this.btn_personal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(153, 35);
            this.btn_personal.TabIndex = 7;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseVisualStyleBackColor = true;
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(12, 18);
            this.btn_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(153, 35);
            this.btn_inventario.TabIndex = 5;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(11, 69);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 314);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Fm_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 457);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_personal);
            this.Controls.Add(this.btn_inventario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm_datos";
            this.Text = "Fm_Datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.ListView listView1;
    }
}