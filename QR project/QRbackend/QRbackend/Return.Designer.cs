namespace QRbackend
{
    partial class Return
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
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Intel Clear Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(54, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 42);
            this.label8.TabIndex = 15;
            this.label8.Text = "Return";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Back.Location = new System.Drawing.Point(82, 392);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(95, 40);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Send.Location = new System.Drawing.Point(537, 392);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(95, 40);
            this.btn_Send.TabIndex = 18;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(286, 139);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(214, 26);
            this.text_ID.TabIndex = 22;
            this.text_ID.TextChanged += new System.EventHandler(this.text_ID_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(286, 208);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(214, 65);
            this.Description.TabIndex = 26;
            this.Description.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Intel Clear Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label8);
            this.Name = "Return";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label7;
    }
}