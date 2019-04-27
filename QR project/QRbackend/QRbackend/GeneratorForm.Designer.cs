namespace QRbackend
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
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.generatebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qrtext = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(199, 35);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(305, 264);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(457, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generatebutton
            // 
            this.generatebutton.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebutton.Location = new System.Drawing.Point(457, 449);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(146, 36);
            this.generatebutton.TabIndex = 2;
            this.generatebutton.Text = "Generate";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qr Text:";
            // 
            // qrtext
            // 
            this.qrtext.Location = new System.Drawing.Point(99, 435);
            this.qrtext.Multiline = true;
            this.qrtext.Name = "qrtext";
            this.qrtext.Size = new System.Drawing.Size(212, 27);
            this.qrtext.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(25, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.qrtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturebox);
            this.Name = "GeneratorForm";
            this.Text = "GeneratorForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qrtext;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button2;
    }
}