﻿namespace QRbackend
{
    partial class Lector
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
            this.txtQR = new System.Windows.Forms.TextBox();
            this.devices_box = new System.Windows.Forms.ComboBox();
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.picture_cam = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cam)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQR
            // 
            this.txtQR.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtQR.Font = new System.Drawing.Font("Intel Clear Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQR.Location = new System.Drawing.Point(34, 574);
            this.txtQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(750, 28);
            this.txtQR.TabIndex = 11;
            // 
            // devices_box
            // 
            this.devices_box.Font = new System.Drawing.Font("Intel Clear Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devices_box.FormattingEnabled = true;
            this.devices_box.Location = new System.Drawing.Point(201, 615);
            this.devices_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devices_box.Name = "devices_box";
            this.devices_box.Size = new System.Drawing.Size(393, 29);
            this.devices_box.TabIndex = 10;
            // 
            // btn_init
            // 
            this.btn_init.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_init.Font = new System.Drawing.Font("Intel Clear Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_init.Location = new System.Drawing.Point(618, 615);
            this.btn_init.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(146, 38);
            this.btn_init.TabIndex = 9;
            this.btn_init.Text = "Start";
            this.btn_init.UseVisualStyleBackColor = false;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_regresar.Font = new System.Drawing.Font("Intel Clear Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(34, 615);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(146, 38);
            this.btn_regresar.TabIndex = 8;
            this.btn_regresar.Text = "Back";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // picture_cam
            // 
            this.picture_cam.Location = new System.Drawing.Point(34, 14);
            this.picture_cam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_cam.Name = "picture_cam";
            this.picture_cam.Size = new System.Drawing.Size(750, 551);
            this.picture_cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_cam.TabIndex = 7;
            this.picture_cam.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(806, 664);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.devices_box);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.picture_cam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lector";
            this.Text = "Lector";
            this.Load += new System.EventHandler(this.Lector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.ComboBox devices_box;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_regresar;
        internal System.Windows.Forms.PictureBox picture_cam;
        private System.Windows.Forms.Timer timer1;
    }
}