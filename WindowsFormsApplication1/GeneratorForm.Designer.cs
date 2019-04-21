namespace Qr_Code_Generator
{
    partial class GeneratorForm
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
            this.btnQr = new System.Windows.Forms.Button();
            this.txtQr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgQr = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btm_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQr
            // 
            this.btnQr.Font = new System.Drawing.Font("Intel Clear", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQr.Location = new System.Drawing.Point(379, 325);
            this.btnQr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(117, 48);
            this.btnQr.TabIndex = 1;
            this.btnQr.Text = "Generar";
            this.btnQr.UseVisualStyleBackColor = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(79, 326);
            this.txtQr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQr.Multiline = true;
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(283, 45);
            this.txtQr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qr";
            // 
            // imgQr
            // 
            this.imgQr.Location = new System.Drawing.Point(79, 15);
            this.imgQr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgQr.Name = "imgQr";
            this.imgQr.Size = new System.Drawing.Size(284, 272);
            this.imgQr.TabIndex = 4;
            this.imgQr.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btm_save
            // 
            this.btm_save.Location = new System.Drawing.Point(377, 407);
            this.btm_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btm_save.Name = "btm_save";
            this.btm_save.Size = new System.Drawing.Size(119, 48);
            this.btm_save.TabIndex = 6;
            this.btm_save.Text = "Guardar";
            this.btm_save.UseVisualStyleBackColor = true;
            this.btm_save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 481);
            this.Controls.Add(this.btm_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgQr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQr);
            this.Controls.Add(this.btnQr);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneratorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQr;
        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgQr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btm_save;
    }
}

