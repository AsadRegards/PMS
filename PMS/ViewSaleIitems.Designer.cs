namespace PMS
{
    partial class ViewSaleIitems
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
            saleItemGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)saleItemGridView).BeginInit();
            SuspendLayout();
            // 
            // saleItemGridView
            // 
            saleItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleItemGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Item, Quantity, UnitPrice, totalPrice });
            saleItemGridView.Location = new Point(12, 12);
            saleItemGridView.Name = "saleItemGridView";
            saleItemGridView.RowHeadersWidth = 51;
            saleItemGridView.Size = new Size(978, 764);
            saleItemGridView.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Item
            // 
            Item.HeaderText = "Item Name";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 550;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Unit Price";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 125;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "Total Price";
            totalPrice.MinimumWidth = 6;
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Width = 125;
            // 
            // ViewSaleIitems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 788);
            Controls.Add(saleItemGridView);
            Name = "ViewSaleIitems";
            Text = "ViewSaleIitems";
            Load += ViewSaleIitems_Load;
            ((System.ComponentModel.ISupportInitialize)saleItemGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView saleItemGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn totalPrice;
    }
}