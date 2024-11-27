namespace Activity_01_Lab
{
    partial class frmCustomerPreview
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hobby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(173, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "label6";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(173, 183);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(35, 13);
            this.lblHobby.TabIndex = 8;
            this.lblHobby.Text = "label7";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(173, 143);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "label8";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(173, 108);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(35, 13);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label10";
            // 
            // frmCustomerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 314);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerPreview";
            this.Load += new System.EventHandler(this.frmCustomerPreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblName;
    }
}