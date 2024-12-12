namespace FormMarket
{
    partial class Form1
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
            toForm2 = new Button();
            loginField = new TextBox();
            passwordField = new TextBox();
            loginbutton = new Button();
            SuspendLayout();
            // 
            // toForm2
            // 
            toForm2.Location = new Point(85, 81);
            toForm2.Name = "toForm2";
            toForm2.Size = new Size(230, 46);
            toForm2.TabIndex = 0;
            toForm2.Text = "Switch to shop";
            toForm2.UseVisualStyleBackColor = true;
            toForm2.Click += buttonSwitch_Click;
            // 
            // loginField
            // 
            loginField.Location = new Point(491, 81);
            loginField.Name = "loginField";
            loginField.Size = new Size(728, 39);
            loginField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(491, 219);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(728, 39);
            passwordField.TabIndex = 1;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginbutton.Location = new Point(721, 323);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(288, 46);
            loginbutton.TabIndex = 2;
            loginbutton.Text = "LogIn";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 929);
            Controls.Add(loginbutton);
            Controls.Add(passwordField);
            Controls.Add(loginField);
            Controls.Add(toForm2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toForm2;
        private TextBox loginField;
        private TextBox passwordField;
        private Button loginbutton;
    }
}