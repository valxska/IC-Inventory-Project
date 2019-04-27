namespace QRbackend
{
    partial class Pedidos
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
            this.Phone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.text_Phone = new System.Windows.Forms.TextBox();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.text_Description = new System.Windows.Forms.RichTextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(96, 199);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(56, 20);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Type ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(257, 82);
            this.text_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(191, 22);
            this.text_ID.TabIndex = 7;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(257, 110);
            this.text_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(191, 22);
            this.text_Name.TabIndex = 8;
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(257, 140);
            this.text_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(191, 22);
            this.text_LastName.TabIndex = 9;
            // 
            // text_Phone
            // 
            this.text_Phone.Location = new System.Drawing.Point(257, 198);
            this.text_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Phone.Name = "text_Phone";
            this.text_Phone.Size = new System.Drawing.Size(191, 22);
            this.text_Phone.TabIndex = 11;
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(257, 226);
            this.text_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(191, 22);
            this.text_Email.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Request";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(100, 334);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 32);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(443, 334);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(84, 32);
            this.btn_Send.TabIndex = 17;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_Description
            // 
            this.text_Description.Location = new System.Drawing.Point(257, 254);
            this.text_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Description.Name = "text_Description";
            this.text_Description.Size = new System.Drawing.Size(191, 53);
            this.text_Description.TabIndex = 18;
            this.text_Description.Text = "";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(257, 170);
            this.comboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(191, 24);
            this.comboType.TabIndex = 19;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(682, 491);
=======
            this.ClientSize = new System.Drawing.Size(606, 393);
>>>>>>> f4042adbb50826fb76cac7df83dbefd473c25348
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.text_Description);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_Email);
            this.Controls.Add(this.text_Phone);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pedidos";
            this.Text = "datosPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.TextBox text_Phone;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.RichTextBox text_Description;
        private System.Windows.Forms.ComboBox comboType;
    }
}