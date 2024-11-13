namespace Exercise_9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Input = new TextBox();
            label_CharCount = new Label();
            SuspendLayout();
            // 
            // textBox_Input
            // 
            textBox_Input.Location = new Point(42, 21);
            textBox_Input.MaxLength = 160;
            textBox_Input.Multiline = true;
            textBox_Input.Name = "textBox_Input";
            textBox_Input.Size = new Size(228, 92);
            textBox_Input.TabIndex = 0;
            textBox_Input.TextChanged += textBox_Input_TextChanged;
            // 
            // label_CharCount
            // 
            label_CharCount.AutoSize = true;
            label_CharCount.Location = new Point(73, 138);
            label_CharCount.Name = "label_CharCount";
            label_CharCount.Size = new Size(83, 25);
            label_CharCount.TabIndex = 1;
            label_CharCount.Text = "character";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 251);
            Controls.Add(label_CharCount);
            Controls.Add(textBox_Input);
            Name = "Form1";
            Text = "Limit_Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Input;
        private Label label_CharCount;
    }
}
