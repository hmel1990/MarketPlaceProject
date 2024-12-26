namespace FormMarket
{
    partial class Form3
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
            buttonSwitchToMain = new Button();
            dataGridViewProducts = new DataGridView();
            dataGridViewBasket = new DataGridView();
            deleteGoodsFromShop = new Button();
            saveProductsToFile = new Button();
            buttonRefreshProdutcs = new Button();
            deleteProductFromBasket = new Button();
            saveUsersToFile = new Button();
            RefreshBasketProductsGrid = new Button();
            comboBoxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasket).BeginInit();
            SuspendLayout();
            // 
            // buttonSwitchToMain
            // 
            buttonSwitchToMain.Location = new Point(77, 60);
            buttonSwitchToMain.Name = "buttonSwitchToMain";
            buttonSwitchToMain.Size = new Size(222, 52);
            buttonSwitchToMain.TabIndex = 0;
            buttonSwitchToMain.Text = "Back to Main";
            buttonSwitchToMain.UseVisualStyleBackColor = true;
            buttonSwitchToMain.Click += buttonSwitchToMain_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(77, 220);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 82;
            dataGridViewProducts.Size = new Size(1444, 354);
            dataGridViewProducts.TabIndex = 1;
            // 
            // dataGridViewBasket
            // 
            dataGridViewBasket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBasket.Location = new Point(77, 670);
            dataGridViewBasket.Name = "dataGridViewBasket";
            dataGridViewBasket.RowHeadersWidth = 82;
            dataGridViewBasket.Size = new Size(1444, 354);
            dataGridViewBasket.TabIndex = 1;
            // 
            // deleteGoodsFromShop
            // 
            deleteGoodsFromShop.Location = new Point(77, 142);
            deleteGoodsFromShop.Name = "deleteGoodsFromShop";
            deleteGoodsFromShop.Size = new Size(222, 46);
            deleteGoodsFromShop.TabIndex = 2;
            deleteGoodsFromShop.Text = "Delete";
            deleteGoodsFromShop.UseVisualStyleBackColor = true;
            deleteGoodsFromShop.Click += deleteGoodsFromShop_Click;
            // 
            // saveProductsToFile
            // 
            saveProductsToFile.Location = new Point(365, 142);
            saveProductsToFile.Name = "saveProductsToFile";
            saveProductsToFile.Size = new Size(222, 46);
            saveProductsToFile.TabIndex = 2;
            saveProductsToFile.Text = "Save";
            saveProductsToFile.UseVisualStyleBackColor = true;
            saveProductsToFile.Click += saveProductsToFile_Click;
            // 
            // buttonRefreshProdutcs
            // 
            buttonRefreshProdutcs.Location = new Point(633, 142);
            buttonRefreshProdutcs.Name = "buttonRefreshProdutcs";
            buttonRefreshProdutcs.Size = new Size(222, 46);
            buttonRefreshProdutcs.TabIndex = 2;
            buttonRefreshProdutcs.Text = "Refresh";
            buttonRefreshProdutcs.UseVisualStyleBackColor = true;
            buttonRefreshProdutcs.Click += buttonRefreshProdutcs_Click;
            // 
            // deleteProductFromBasket
            // 
            deleteProductFromBasket.Location = new Point(77, 602);
            deleteProductFromBasket.Name = "deleteProductFromBasket";
            deleteProductFromBasket.Size = new Size(222, 46);
            deleteProductFromBasket.TabIndex = 2;
            deleteProductFromBasket.Text = "Delete";
            deleteProductFromBasket.UseVisualStyleBackColor = true;
            deleteProductFromBasket.Click += deleteProductFromBasket_Click;
            // 
            // saveUsersToFile
            // 
            saveUsersToFile.Location = new Point(365, 602);
            saveUsersToFile.Name = "saveUsersToFile";
            saveUsersToFile.Size = new Size(222, 46);
            saveUsersToFile.TabIndex = 2;
            saveUsersToFile.Text = "Save";
            saveUsersToFile.UseVisualStyleBackColor = true;
            saveUsersToFile.Click += saveUsersToFile_Click;
            // 
            // RefreshBasketProductsGrid
            // 
            RefreshBasketProductsGrid.Location = new Point(633, 602);
            RefreshBasketProductsGrid.Name = "RefreshBasketProductsGrid";
            RefreshBasketProductsGrid.Size = new Size(222, 46);
            RefreshBasketProductsGrid.TabIndex = 2;
            RefreshBasketProductsGrid.Text = "Refresh";
            RefreshBasketProductsGrid.UseVisualStyleBackColor = true;
            RefreshBasketProductsGrid.Click += RefreshBasketProductsGrid_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(952, 609);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(242, 40);
            comboBoxFilter.TabIndex = 3;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 1097);
            Controls.Add(comboBoxFilter);
            Controls.Add(RefreshBasketProductsGrid);
            Controls.Add(buttonRefreshProdutcs);
            Controls.Add(saveUsersToFile);
            Controls.Add(saveProductsToFile);
            Controls.Add(deleteProductFromBasket);
            Controls.Add(deleteGoodsFromShop);
            Controls.Add(dataGridViewBasket);
            Controls.Add(dataGridViewProducts);
            Controls.Add(buttonSwitchToMain);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSwitchToMain;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewBasket;
        private Button deleteGoodsFromShop;
        private Button saveProductsToFile;
        private Button buttonRefreshProdutcs;
        private Button deleteProductFromBasket;
        private Button saveUsersToFile;
        private Button RefreshBasketProductsGrid;
        private ComboBox comboBoxFilter;
    }
}