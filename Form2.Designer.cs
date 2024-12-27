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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasket).BeginInit();
            SuspendLayout();
            // 
            // backToForm1
            // 
            backToForm1.BackColor = Color.Goldenrod;
            backToForm1.Location = new Point(127, 31);
            backToForm1.Name = "backToForm1";
            backToForm1.Size = new Size(262, 46);
            backToForm1.TabIndex = 0;
            backToForm1.Text = "Back to main";
            backToForm1.UseVisualStyleBackColor = false;
            backToForm1.Click += buttonBack_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = Color.Salmon;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(127, 105);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RightToLeft = RightToLeft.No;
            dataGridViewProducts.RowHeadersWidth = 82;
            dataGridViewProducts.Size = new Size(1122, 318);
            dataGridViewProducts.TabIndex = 1;
            // 
            // deleteGoodsFromShop
            // 
            deleteGoodsFromShop.Location = new Point(663, 31);
            deleteGoodsFromShop.Name = "deleteGoodsFromShop";
            deleteGoodsFromShop.Size = new Size(150, 46);
            deleteGoodsFromShop.TabIndex = 2;
            deleteGoodsFromShop.Text = "Delete";
            deleteGoodsFromShop.UseVisualStyleBackColor = true;
            deleteGoodsFromShop.Click += deleteGoodsFromShop_Click;
            // 
            // saveToFile
            // 
            saveToFile.Location = new Point(851, 31);
            saveToFile.Name = "saveToFile";
            saveToFile.Size = new Size(150, 46);
            saveToFile.TabIndex = 3;
            saveToFile.Text = "Save";
            saveToFile.UseVisualStyleBackColor = true;
            saveToFile.Click += saveToFile_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(1043, 31);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 46);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(127, 505);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 82;
            dataGridViewUsers.Size = new Size(1122, 384);
            dataGridViewUsers.TabIndex = 5;
            // 
            // deleteUserFromList
            // 
            deleteUserFromList.Location = new Point(663, 453);
            deleteUserFromList.Name = "deleteUserFromList";
            deleteUserFromList.Size = new Size(150, 46);
            deleteUserFromList.TabIndex = 6;
            deleteUserFromList.Text = "Delete";
            deleteUserFromList.UseVisualStyleBackColor = true;
            deleteUserFromList.Click += deleteUserFromList_Click;
            // 
            // saveUsersToFile
            // 
            saveUsersToFile.Location = new Point(851, 453);
            saveUsersToFile.Name = "saveUsersToFile";
            saveUsersToFile.Size = new Size(150, 46);
            saveUsersToFile.TabIndex = 7;
            saveUsersToFile.Text = "Save";
            saveUsersToFile.UseVisualStyleBackColor = true;
            saveUsersToFile.Click += saveUsersToFile_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1043, 453);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonUsersRefresh_Click;
            // 
            // dataGridViewBasket
            // 
            dataGridViewBasket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBasket.Location = new Point(127, 1035);
            dataGridViewBasket.Name = "dataGridViewBasket";
            dataGridViewBasket.RowHeadersWidth = 82;
            dataGridViewBasket.Size = new Size(1122, 384);
            dataGridViewBasket.TabIndex = 5;
            // 
            // deleteProductFromBasket
            // 
            deleteProductFromBasket.Location = new Point(381, 967);
            deleteProductFromBasket.Name = "deleteProductFromBasket";
            deleteProductFromBasket.Size = new Size(150, 46);
            deleteProductFromBasket.TabIndex = 6;
            deleteProductFromBasket.Text = "Delete";
            deleteProductFromBasket.UseVisualStyleBackColor = true;
            deleteProductFromBasket.Click += deleteProductFromBasket_Click;
            // 
            // saveProductsToBascketFile
            // 
            saveProductsToBascketFile.Location = new Point(569, 967);
            saveProductsToBascketFile.Name = "saveProductsToBascketFile";
            saveProductsToBascketFile.Size = new Size(150, 46);
            saveProductsToBascketFile.TabIndex = 7;
            saveProductsToBascketFile.Text = "Save";
            saveProductsToBascketFile.UseVisualStyleBackColor = true;
            saveProductsToBascketFile.Click += saveProductsToBascketFile_Click;
            // 
            // RefreshBasketProductsGrid
            // 
            RefreshBasketProductsGrid.Location = new Point(761, 967);
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
            comboBoxFilter.Location = new Point(1007, 967);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(242, 40);
            comboBoxFilter.TabIndex = 9;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1974, 1515);
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
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasket).EndInit();
            ResumeLayout(false);
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
    }
}