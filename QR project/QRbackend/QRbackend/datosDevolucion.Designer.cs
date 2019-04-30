namespace QRbackend
{
    partial class DatosDevolucion
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
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.comboB = new System.Windows.Forms.ComboBox();
            this.text_Description = new System.Windows.Forms.RichTextBox();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Send.Font = new System.Drawing.Font("Intel Clear Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(518, 318);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(94, 40);
            this.btn_Send.TabIndex = 19;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.Font = new System.Drawing.Font("Intel Clear Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(132, 318);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(94, 40);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // comboB
            // 
            this.comboB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboB.FormattingEnabled = true;
            this.comboB.Location = new System.Drawing.Point(339, 106);
            this.comboB.Name = "comboB";
            this.comboB.Size = new System.Drawing.Size(214, 28);
            this.comboB.TabIndex = 34;
            // 
            // text_Description
            // 
            this.text_Description.Location = new System.Drawing.Point(339, 200);
            this.text_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Description.Name = "text_Description";
            this.text_Description.Size = new System.Drawing.Size(214, 65);
            this.text_Description.TabIndex = 32;
            this.text_Description.Text = "";
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(339, 154);
            this.text_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(214, 26);
            this.text_Email.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 27);
            this.label7.TabIndex = 27;
            this.label7.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Intel Clear Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(55, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 42);
            this.label8.TabIndex = 35;
            this.label8.Text = "Return";
            // 
            // DatosDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 398);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboB);
            this.Controls.Add(this.text_Description);
            this.Controls.Add(this.text_Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Back);
            this.Name = "DatosDevolucion";
            this.Text = "datosDevolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox comboB;
        private System.Windows.Forms.RichTextBox text_Description;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}