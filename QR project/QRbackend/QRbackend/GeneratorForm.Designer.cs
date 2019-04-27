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
            this.picturebox.Location = new System.Drawing.Point(224, 44);
            this.picturebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(343, 330);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
<<<<<<< HEAD
            this.button1.UseVisualStyleBackColor = false;
=======
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
>>>>>>> f4042adbb50826fb76cac7df83dbefd473c25348
            // 
            // generatebutton
            // 
            this.generatebutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generatebutton.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebutton.Location = new System.Drawing.Point(514, 561);
            this.generatebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(164, 45);
            this.generatebutton.TabIndex = 2;
            this.generatebutton.Text = "Generate";
            this.generatebutton.UseVisualStyleBackColor = false;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qr Text:";
            // 
            // qrtext
            // 
            this.qrtext.Location = new System.Drawing.Point(111, 544);
            this.qrtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qrtext.Multiline = true;
            this.qrtext.Name = "qrtext";
            this.qrtext.Size = new System.Drawing.Size(238, 33);
            this.qrtext.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backButton.Location = new System.Drawing.Point(28, 29);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 29);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(816, 636);
=======
            this.ClientSize = new System.Drawing.Size(725, 509);
            this.Controls.Add(this.button2);
>>>>>>> f4042adbb50826fb76cac7df83dbefd473c25348
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.qrtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturebox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneratorForm";
            this.Text = "GeneratorForm";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
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