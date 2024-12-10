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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toForm2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button toForm2;
    }
}