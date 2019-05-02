namespace QRbackend
{
    partial class AddPersonForm
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
            this.createbutton = new System.Windows.Forms.Button();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.typebox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.createbutton.Font = new System.Drawing.Font("Intel Clear Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.Location = new System.Drawing.Point(681, 475);
            this.createbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(131, 50);
            this.createbutton.TabIndex = 5;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(585, 275);
            this.phonebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonebox.Multiline = true;
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(208, 38);
            this.phonebox.TabIndex = 6;
            this.phonebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(211, 163);
            this.emailbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailbox.Multiline = true;
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(208, 34);
            this.emailbox.TabIndex = 7;
            // 
            // lastnamebox
            // 
            this.lastnamebox.Location = new System.Drawing.Point(211, 286);
            this.lastnamebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastnamebox.Multiline = true;
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(208, 33);
            this.lastnamebox.TabIndex = 8;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(585, 166);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namebox.Multiline = true;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(208, 36);
            this.namebox.TabIndex = 9;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(211, 401);
            this.idbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idbox.Multiline = true;
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(208, 36);
            this.idbox.TabIndex = 10;
            // 
            // typebox
            // 
            this.typebox.FormattingEnabled = true;
            this.typebox.Location = new System.Drawing.Point(585, 401);
            this.typebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(208, 28);
            this.typebox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Intel Clear Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(289, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 69);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add Person";
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.lastnamebox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPersonForm";
            this.Text = "AddPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.TextBox phonebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.ComboBox typebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}