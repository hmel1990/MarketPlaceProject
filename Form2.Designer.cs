namespace FormMarket
{
    partial class Form2
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
            backToForm1 = new Button();
            dataGridViewProducts = new DataGridView();
            deleteGoodsFromShop = new Button();
            saveToFile = new Button();
            buttonRefresh = new Button();
            dataGridViewUsers = new DataGridView();
            deleteUserFromList = new Button();
            saveUsersToFile = new Button();
            button3 = new Button();
            dataGridViewBasket = new DataGridView();
            deleteProductFromBasket = new Button();
            saveProductsToBascketFile = new Button();
            RefreshBasketProductsGrid = new Button();
            comboBoxFilter = new ComboBox();
            labelFilteredSum = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasket).BeginInit();
            SuspendLayout();
            // 
            // backToForm1
            // 
            backToForm1.BackColor = Color.Goldenrod;
            backToForm1.Location = new Point(61, 37);
            backToForm1.Name = "backToForm1";
            backToForm1.Size = new Size(262, 46);
            backToForm1.TabIndex = 0;
            backToForm1.Text = "Back to main";
            backToForm1.UseVisualStyleBackColor = false;
            backToForm1.Click += buttonBack_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.Gainsboro;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(1644, 348);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RightToLeft = RightToLeft.No;
            dataGridViewProducts.RowHeadersWidth = 82;
            dataGridViewProducts.Size = new Size(1294, 876);
            dataGridViewProducts.TabIndex = 1;
            // 
            // deleteGoodsFromShop
            // 
            deleteGoodsFromShop.Location = new Point(1644, 269);
            deleteGoodsFromShop.Name = "deleteGoodsFromShop";
            deleteGoodsFromShop.Size = new Size(150, 46);
            deleteGoodsFromShop.TabIndex = 2;
            deleteGoodsFromShop.Text = "Delete";
            deleteGoodsFromShop.UseVisualStyleBackColor = true;
            deleteGoodsFromShop.Click += deleteGoodsFromShop_Click;
            // 
            // saveToFile
            // 
            saveToFile.Location = new Point(1832, 269);
            saveToFile.Name = "saveToFile";
            saveToFile.Size = new Size(150, 46);
            saveToFile.TabIndex = 3;
            saveToFile.Text = "Save";
            saveToFile.UseVisualStyleBackColor = true;
            saveToFile.Click += saveToFile_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(2028, 271);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 46);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.Gainsboro;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(1009, 1395);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 82;
            dataGridViewUsers.Size = new Size(1294, 453);
            dataGridViewUsers.TabIndex = 5;
            // 
            // deleteUserFromList
            // 
            deleteUserFromList.Location = new Point(1353, 1323);
            deleteUserFromList.Name = "deleteUserFromList";
            deleteUserFromList.Size = new Size(150, 46);
            deleteUserFromList.TabIndex = 6;
            deleteUserFromList.Text = "Delete";
            deleteUserFromList.UseVisualStyleBackColor = true;
            deleteUserFromList.Click += deleteUserFromList_Click;
            // 
            // saveUsersToFile
            // 
            saveUsersToFile.Location = new Point(1541, 1323);
            saveUsersToFile.Name = "saveUsersToFile";
            saveUsersToFile.Size = new Size(150, 46);
            saveUsersToFile.TabIndex = 7;
            saveUsersToFile.Text = "Save";
            saveUsersToFile.UseVisualStyleBackColor = true;
            saveUsersToFile.Click += saveUsersToFile_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1733, 1323);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonUsersRefresh_Click;
            // 
            // dataGridViewBasket
            // 
            dataGridViewBasket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBasket.BackgroundColor = Color.Gainsboro;
            dataGridViewBasket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBasket.Location = new Point(256, 348);
            dataGridViewBasket.Name = "dataGridViewBasket";
            dataGridViewBasket.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewBasket.Size = new Size(1294, 876);
            dataGridViewBasket.TabIndex = 5;
            // 
            // deleteProductFromBasket
            // 
            deleteProductFromBasket.Location = new Point(256, 269);
            deleteProductFromBasket.Name = "deleteProductFromBasket";
            deleteProductFromBasket.Size = new Size(150, 46);
            deleteProductFromBasket.TabIndex = 6;
            deleteProductFromBasket.Text = "Delete";
            deleteProductFromBasket.UseVisualStyleBackColor = true;
            deleteProductFromBasket.Click += deleteProductFromBasket_Click;
            // 
            // saveProductsToBascketFile
            // 
            saveProductsToBascketFile.Location = new Point(444, 269);
            saveProductsToBascketFile.Name = "saveProductsToBascketFile";
            saveProductsToBascketFile.Size = new Size(150, 46);
            saveProductsToBascketFile.TabIndex = 7;
            saveProductsToBascketFile.Text = "Save";
            saveProductsToBascketFile.UseVisualStyleBackColor = true;
            saveProductsToBascketFile.Click += saveProductsToBascketFile_Click;
            // 
            // RefreshBasketProductsGrid
            // 
            RefreshBasketProductsGrid.Location = new Point(636, 269);
            RefreshBasketProductsGrid.Name = "RefreshBasketProductsGrid";
            RefreshBasketProductsGrid.Size = new Size(150, 46);
            RefreshBasketProductsGrid.TabIndex = 8;
            RefreshBasketProductsGrid.Text = "Refresh";
            RefreshBasketProductsGrid.UseVisualStyleBackColor = true;
            RefreshBasketProductsGrid.Click += RefreshBasketProductsGrid_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(924, 269);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(242, 40);
            comboBoxFilter.TabIndex = 9;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // labelFilteredSum
            // 
            labelFilteredSum.AutoSize = true;
            labelFilteredSum.Location = new Point(1341, 271);
            labelFilteredSum.Name = "labelFilteredSum";
            labelFilteredSum.Size = new Size(109, 32);
            labelFilteredSum.TabIndex = 10;
            labelFilteredSum.Text = "Sum in $";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 255);
            ClientSize = new Size(3362, 1814);
            Controls.Add(labelFilteredSum);
            Controls.Add(comboBoxFilter);
            Controls.Add(RefreshBasketProductsGrid);
            Controls.Add(saveProductsToBascketFile);
            Controls.Add(button3);
            Controls.Add(deleteProductFromBasket);
            Controls.Add(saveUsersToFile);
            Controls.Add(deleteUserFromList);
            Controls.Add(dataGridViewBasket);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonRefresh);
            Controls.Add(saveToFile);
            Controls.Add(deleteGoodsFromShop);
            Controls.Add(dataGridViewProducts);
            Controls.Add(backToForm1);
            ForeColor = SystemColors.HotTrack;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToForm1;
        private DataGridView dataGridViewProducts;
        private Button deleteGoodsFromShop;
        private Button saveToFile;
        private Button buttonRefresh;
        private DataGridView dataGridViewUsers;
        private Button deleteUserFromList;
        private Button saveUsersToFile;
        private Button button3;
        private DataGridView dataGridViewBasket;
        private Button deleteProductFromBasket;
        private Button saveProductsToBascketFile;
        private Button RefreshBasketProductsGrid;
        private ComboBox comboBoxFilter;
        private Label labelFilteredSum;
    }
}