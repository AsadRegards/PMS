namespace PMS
{
    partial class ViewAllItems
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            itemBindingSource = new BindingSource(components);
            DGV_ViewAllItems = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            Item_description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            stock_last_updated = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            itemBindingSource1 = new BindingSource(components);
            label2 = new Label();
            inputItemNameFilter = new TextBox();
            inputStkLessThanFilter = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_ViewAllItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // DGV_ViewAllItems
            // 
            DGV_ViewAllItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ViewAllItems.Columns.AddRange(new DataGridViewColumn[] { Id, item_name, Item_description, price, stock, stock_last_updated, edit, delete });
            DGV_ViewAllItems.Location = new Point(12, 99);
            DGV_ViewAllItems.Name = "DGV_ViewAllItems";
            DGV_ViewAllItems.RowHeadersWidth = 51;
            DGV_ViewAllItems.Size = new Size(1254, 655);
            DGV_ViewAllItems.TabIndex = 0;
            DGV_ViewAllItems.CellContentClick += DGV_ViewAllItems_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // item_name
            // 
            item_name.HeaderText = "Item Name";
            item_name.MinimumWidth = 6;
            item_name.Name = "item_name";
            item_name.Width = 125;
            // 
            // Item_description
            // 
            Item_description.HeaderText = "Item Description";
            Item_description.MinimumWidth = 6;
            Item_description.Name = "Item_description";
            Item_description.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.Width = 125;
            // 
            // stock_last_updated
            // 
            stock_last_updated.HeaderText = "Stock Last Updated";
            stock_last_updated.MinimumWidth = 6;
            stock_last_updated.Name = "stock_last_updated";
            stock_last_updated.Width = 125;
            // 
            // edit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.ForeColor = Color.White;
            edit.DefaultCellStyle = dataGridViewCellStyle1;
            edit.FlatStyle = FlatStyle.Popup;
            edit.HeaderText = "Edit";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Text = "EDIT";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 125;
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.ForeColor = Color.White;
            delete.DefaultCellStyle = dataGridViewCellStyle2;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "Delete";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "DELETE";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 36);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 10;
            label2.Text = "Item Name";
            // 
            // inputItemNameFilter
            // 
            inputItemNameFilter.Location = new Point(194, 34);
            inputItemNameFilter.Name = "inputItemNameFilter";
            inputItemNameFilter.Size = new Size(299, 27);
            inputItemNameFilter.TabIndex = 11;
            inputItemNameFilter.TextChanged += inputItemNameFilter_TextChanged;
            // 
            // inputStkLessThanFilter
            // 
            inputStkLessThanFilter.Location = new Point(791, 37);
            inputStkLessThanFilter.Name = "inputStkLessThanFilter";
            inputStkLessThanFilter.Size = new Size(299, 27);
            inputStkLessThanFilter.TabIndex = 13;
            inputStkLessThanFilter.TextChanged += inputStkLessThanFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(638, 36);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 12;
            label1.Text = "Stock Less Than";
            // 
            // ViewAllItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 779);
            Controls.Add(inputStkLessThanFilter);
            Controls.Add(label1);
            Controls.Add(inputItemNameFilter);
            Controls.Add(label2);
            Controls.Add(DGV_ViewAllItems);
            Name = "ViewAllItems";
            Text = "ViewAllItems";
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_ViewAllItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastStockedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentPricePerUnitDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Column1;
        private DataGridView DGV_ViewAllItems;
        private BindingSource itemBindingSource1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn Item_description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn stock_last_updated;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Label label2;
        private TextBox inputItemNameFilter;
        private TextBox inputStkLessThanFilter;
        private Label label1;
    }
}