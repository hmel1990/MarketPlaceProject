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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            switchToAdminMode = new Button();
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
            switchToSellerMode = new Button();
            logOutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // switchToAdminMode
            // 
            switchToAdminMode.BackColor = Color.Moccasin;
            switchToAdminMode.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            switchToAdminMode.FlatAppearance.BorderSize = 2;
            switchToAdminMode.FlatStyle = FlatStyle.Flat;
            switchToAdminMode.Location = new Point(1592, 1185);
            switchToAdminMode.Name = "switchToAdminMode";
            switchToAdminMode.Size = new Size(230, 46);
            switchToAdminMode.TabIndex = 0;
            switchToAdminMode.Text = "AdminMode";
            switchToAdminMode.UseVisualStyleBackColor = false;
            switchToAdminMode.Click += switchToAdminMode_Click;
            // 
            // loginField
            // 
            loginField.Location = new Point(1413, 438);
            loginField.Name = "loginField";
            loginField.Size = new Size(728, 39);
            loginField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(1413, 576);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(728, 39);
            passwordField.TabIndex = 1;
            // 
            // loginbutton
            // 
            loginbutton.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            loginbutton.FlatAppearance.BorderSize = 2;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginbutton.ForeColor = Color.MediumSlateBlue;
            loginbutton.Location = new Point(1413, 688);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(288, 46);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "LogIn";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 46;
            dataGridView1.Location = new Point(890, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2234, 849);
            dataGridView1.TabIndex = 3;
            // 
            // buttonToBuy
            // 
            buttonToBuy.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            buttonToBuy.FlatAppearance.BorderSize = 2;
            buttonToBuy.FlatStyle = FlatStyle.Flat;
            buttonToBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonToBuy.ForeColor = Color.MediumSlateBlue;
            buttonToBuy.Location = new Point(1195, 203);
            buttonToBuy.Name = "buttonToBuy";
            buttonToBuy.Size = new Size(233, 59);
            buttonToBuy.TabIndex = 4;
            buttonToBuy.Text = "Buy";
            buttonToBuy.UseVisualStyleBackColor = true;
            buttonToBuy.Click += buttonToBuy_Click;
            // 
            // RegistrationButton
            // 
            RegistrationButton.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            RegistrationButton.FlatAppearance.BorderSize = 2;
            RegistrationButton.FlatStyle = FlatStyle.Flat;
            RegistrationButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegistrationButton.ForeColor = Color.MediumSlateBlue;
            RegistrationButton.Location = new Point(1853, 688);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(288, 46);
            RegistrationButton.TabIndex = 4;
            RegistrationButton.Text = "Registration";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.BackColor = SystemColors.Info;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(566, 698);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(295, 40);
            comboBoxFilter.TabIndex = 5;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            buttonSearch.FlatAppearance.BorderSize = 2;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.MediumSlateBlue;
            buttonSearch.Location = new Point(562, 452);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(299, 46);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = SystemColors.Info;
            textBoxSearch.Location = new Point(562, 381);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Введите текст для поиска";
            textBoxSearch.Size = new Size(299, 39);
            textBoxSearch.TabIndex = 6;
            // 
            // ResetButton
            // 
            ResetButton.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            ResetButton.FlatAppearance.BorderSize = 2;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResetButton.ForeColor = Color.MediumSlateBlue;
            ResetButton.Location = new Point(562, 547);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(299, 48);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // comboBoxSort
            // 
            comboBoxSort.BackColor = SystemColors.Info;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(562, 814);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(295, 40);
            comboBoxSort.TabIndex = 7;
            comboBoxSort.SelectedIndexChanged += ComboBoxSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(638, 779);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 8;
            label1.Text = "Сортировка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(566, 663);
            label2.Name = "label2";
            label2.Size = new Size(295, 32);
            label2.TabIndex = 8;
            label2.Text = "Фильтр по имени бренда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(566, 333);
            label3.Name = "label3";
            label3.Size = new Size(281, 32);
            label3.TabIndex = 8;
            label3.Text = "Поиск по содержимому";
            // 
            // buttonRefresh
            // 
            buttonRefresh.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            buttonRefresh.FlatAppearance.BorderSize = 2;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.MediumSlateBlue;
            buttonRefresh.Location = new Point(890, 206);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(229, 56);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // switchToSellerMode
            // 
            switchToSellerMode.BackColor = Color.Moccasin;
            switchToSellerMode.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            switchToSellerMode.FlatAppearance.BorderSize = 2;
            switchToSellerMode.FlatStyle = FlatStyle.Flat;
            switchToSellerMode.Location = new Point(1855, 1185);
            switchToSellerMode.Name = "switchToSellerMode";
            switchToSellerMode.Size = new Size(230, 46);
            switchToSellerMode.TabIndex = 0;
            switchToSellerMode.Text = "SellerMode";
            switchToSellerMode.UseVisualStyleBackColor = false;
            switchToSellerMode.Click += switchToSellerMode_Click;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Moccasin;
            logOutButton.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            logOutButton.FlatAppearance.BorderSize = 2;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Location = new Point(2111, 1185);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(230, 46);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "LogOut";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(3154, 1785);
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
            Controls.Add(RegistrationButton);
            Controls.Add(loginbutton);
            Controls.Add(passwordField);
            Controls.Add(loginField);
            Controls.Add(logOutButton);
            Controls.Add(switchToSellerMode);
            Controls.Add(switchToAdminMode);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button switchToAdminMode;
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
        private Button switchToSellerMode;
        private Button logOutButton;
    }
}