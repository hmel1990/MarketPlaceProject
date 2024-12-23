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
            dataGridView1 = new DataGridView();
            buttonToBuy = new Button();
            RegistrationButton = new Button();
            comboBoxFilter = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            ResetButton = new Button();
            comboBoxSort = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toForm2
            // 
            toForm2.Location = new Point(85, 81);
            toForm2.Name = "toForm2";
            toForm2.Size = new Size(230, 46);
            toForm2.TabIndex = 0;
            toForm2.Text = "AdminMode";
            toForm2.UseVisualStyleBackColor = true;
            toForm2.Click += buttonSwitch_Click;
            // 
            // loginField
            // 
            loginField.Location = new Point(657, 167);
            loginField.Name = "loginField";
            loginField.Size = new Size(728, 39);
            loginField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(657, 305);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(728, 39);
            passwordField.TabIndex = 1;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginbutton.Location = new Point(657, 417);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(288, 46);
            loginbutton.TabIndex = 2;
            loginbutton.Text = "LogIn";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1712, 744);
            dataGridView1.TabIndex = 3;
            // 
            // buttonToBuy
            // 
            buttonToBuy.Location = new Point(85, 167);
            buttonToBuy.Name = "buttonToBuy";
            buttonToBuy.Size = new Size(233, 46);
            buttonToBuy.TabIndex = 4;
            buttonToBuy.Text = "buy";
            buttonToBuy.UseVisualStyleBackColor = true;
            buttonToBuy.Click += buttonToBuy_Click;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegistrationButton.Location = new Point(1097, 417);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(288, 46);
            RegistrationButton.TabIndex = 2;
            RegistrationButton.Text = "Registration";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(80, 606);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(242, 40);
            comboBoxFilter.TabIndex = 5;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(96, 384);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(233, 46);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(56, 305);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Введите текст для поиска";
            textBoxSearch.Size = new Size(299, 39);
            textBoxSearch.TabIndex = 6;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(96, 460);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(233, 46);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(73, 798);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(242, 40);
            comboBoxSort.TabIndex = 7;
            comboBoxSort.SelectedIndexChanged += ComboBoxSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 751);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 8;
            label1.Text = "Сортировка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 571);
            label2.Name = "label2";
            label2.Size = new Size(295, 32);
            label2.TabIndex = 8;
            label2.Text = "Фильтр по имени бренда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 257);
            label3.Name = "label3";
            label3.Size = new Size(281, 32);
            label3.TabIndex = 8;
            label3.Text = "Поиск по содержимому";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(89, 892);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(229, 40);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2396, 1107);
            Controls.Add(buttonRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxSort);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxFilter);
            Controls.Add(ResetButton);
            Controls.Add(buttonSearch);
            Controls.Add(buttonToBuy);
            Controls.Add(dataGridView1);
            Controls.Add(RegistrationButton);
            Controls.Add(loginbutton);
            Controls.Add(passwordField);
            Controls.Add(loginField);
            Controls.Add(toForm2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toForm2;
        private TextBox loginField;
        private TextBox passwordField;
        private Button loginbutton;
        private DataGridView dataGridView1;
        private Button buttonToBuy;
        private Button RegistrationButton;
        private ComboBox comboBoxFilter;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Button ResetButton;
        private ComboBox comboBoxSort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRefresh;
    }
}