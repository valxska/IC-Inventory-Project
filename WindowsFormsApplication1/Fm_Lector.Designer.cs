namespace WindowsFormsApplication1
{
    partial class Fm_Lector
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
            this.components = new System.ComponentModel.Container();
            this.picture_cam = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.devices_box = new System.Windows.Forms.ComboBox();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cam)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_cam
            // 
            this.picture_cam.Location = new System.Drawing.Point(26, 11);
            this.picture_cam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture_cam.Name = "picture_cam";
            this.picture_cam.Size = new System.Drawing.Size(667, 441);
            this.picture_cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_cam.TabIndex = 1;
            this.picture_cam.TabStop = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(26, 492);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(130, 30);
            this.btn_regresar.TabIndex = 3;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(545, 492);
            this.btn_init.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(130, 30);
            this.btn_init.TabIndex = 4;
            this.btn_init.Text = "Iniciar";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // devices_box
            // 
            this.devices_box.FormattingEnabled = true;
            this.devices_box.Location = new System.Drawing.Point(174, 492);
            this.devices_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devices_box.Name = "devices_box";
            this.devices_box.Size = new System.Drawing.Size(350, 24);
            this.devices_box.TabIndex = 5;
            // 
            // txtQR
            // 
            this.txtQR.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtQR.Location = new System.Drawing.Point(26, 459);
            this.txtQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(667, 22);
            this.txtQR.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fm_Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 532);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.devices_box);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.picture_cam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm_Lector";
            this.Text = "Fm_Lector";
            this.Load += new System.EventHandler(this.Fm_Lector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picture_cam;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.ComboBox devices_box;
        public System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Timer timer1;
    }
}