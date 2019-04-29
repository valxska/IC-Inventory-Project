namespace QRbackend
{
    partial class AddDeviceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.serialbox = new System.Windows.Forms.TextBox();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.qrButton = new System.Windows.Forms.Button();
            this.qrText = new System.Windows.Forms.Label();
            this.brandbox = new System.Windows.Forms.ComboBox();
            this.categorybox = new System.Windows.Forms.ComboBox();
            this.estatebox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Brand:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Intel Clear Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(321, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 62);
            this.label8.TabIndex = 7;
            this.label8.Text = "Add Device";
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.insertButton.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(780, 575);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(84, 44);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backbutton.Font = new System.Drawing.Font("Intel Clear Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(44, 559);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(107, 44);
            this.backbutton.TabIndex = 9;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(620, 266);
            this.pricebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(230, 26);
            this.pricebox.TabIndex = 10;
            // 
            // serialbox
            // 
            this.serialbox.Location = new System.Drawing.Point(637, 161);
            this.serialbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serialbox.Name = "serialbox";
            this.serialbox.Size = new System.Drawing.Size(213, 26);
            this.serialbox.TabIndex = 11;
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(201, 436);
            this.descriptionbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionbox.Multiline = true;
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(234, 98);
            this.descriptionbox.TabIndex = 12;
            this.descriptionbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(126, 272);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(292, 26);
            this.namebox.TabIndex = 13;
            // 
            // qrButton
            // 
            this.qrButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.qrButton.Font = new System.Drawing.Font("Intel Clear", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrButton.Location = new System.Drawing.Point(314, 175);
            this.qrButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qrButton.Name = "qrButton";
            this.qrButton.Size = new System.Drawing.Size(105, 36);
            this.qrButton.TabIndex = 14;
            this.qrButton.Text = "Add Qr";
            this.qrButton.UseVisualStyleBackColor = false;
            this.qrButton.Click += new System.EventHandler(this.qrButton_Click);
            // 
            // qrText
            // 
            this.qrText.AutoSize = true;
            this.qrText.Location = new System.Drawing.Point(122, 186);
            this.qrText.Name = "qrText";
            this.qrText.Size = new System.Drawing.Size(153, 20);
            this.qrText.TabIndex = 15;
            this.qrText.Text = "....................................";
            this.qrText.Click += new System.EventHandler(this.qrText_Click);
            // 
            // brandbox
            // 
            this.brandbox.FormattingEnabled = true;
            this.brandbox.Location = new System.Drawing.Point(620, 362);
            this.brandbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brandbox.Name = "brandbox";
            this.brandbox.Size = new System.Drawing.Size(230, 28);
            this.brandbox.TabIndex = 16;
            this.brandbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // categorybox
            // 
            this.categorybox.FormattingEnabled = true;
            this.categorybox.Location = new System.Drawing.Point(156, 346);
            this.categorybox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(262, 28);
            this.categorybox.TabIndex = 17;
            // 
            // estatebox
            // 
            this.estatebox.FormattingEnabled = true;
            this.estatebox.Location = new System.Drawing.Point(620, 459);
            this.estatebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.estatebox.Name = "estatebox";
            this.estatebox.Size = new System.Drawing.Size(230, 28);
            this.estatebox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estate:";
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 634);
            this.Controls.Add(this.estatebox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.brandbox);
            this.Controls.Add(this.qrText);
            this.Controls.Add(this.qrButton);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.serialbox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddDeviceForm";
            this.Text = "AddDeviceForm";
            this.Load += new System.EventHandler(this.AddDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.TextBox serialbox;
        private System.Windows.Forms.TextBox descriptionbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button qrButton;
        private System.Windows.Forms.Label qrText;
        private System.Windows.Forms.ComboBox brandbox;
        private System.Windows.Forms.ComboBox categorybox;
        private System.Windows.Forms.ComboBox estatebox;
        private System.Windows.Forms.Label label9;
    }
}