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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            itemBindingSource = new BindingSource(components);
            DGV_ViewAllItems = new DataGridView();
            itemBindingSource1 = new BindingSource(components);
            label2 = new Label();
            inputItemNameFilter = new TextBox();
            inputStkLessThanFilter = new TextBox();
            label1 = new Label();
            Id = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            Item_description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            stock_last_updated = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_ViewAllItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // DGV_ViewAllItems
            // 
            DGV_ViewAllItems.BackgroundColor = Color.FromArgb(248, 248, 248);
            DGV_ViewAllItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 94, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_ViewAllItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_ViewAllItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ViewAllItems.Columns.AddRange(new DataGridViewColumn[] { Id, item_name, Item_description, price, stock, stock_last_updated, edit, delete });
            DGV_ViewAllItems.EnableHeadersVisualStyles = false;
            DGV_ViewAllItems.Location = new Point(12, 66);
            DGV_ViewAllItems.Margin = new Padding(3, 2, 3, 2);
            DGV_ViewAllItems.Name = "DGV_ViewAllItems";
            DGV_ViewAllItems.RowHeadersWidth = 51;
            DGV_ViewAllItems.Size = new Size(942, 383);
            DGV_ViewAllItems.TabIndex = 0;
            DGV_ViewAllItems.CellContentClick += DGV_ViewAllItems_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 27);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 10;
            label2.Text = "Item Name";
            // 
            // inputItemNameFilter
            // 
            inputItemNameFilter.BackColor = Color.FromArgb(248, 248, 248);
            inputItemNameFilter.Location = new Point(170, 26);
            inputItemNameFilter.Margin = new Padding(3, 2, 3, 2);
            inputItemNameFilter.Name = "inputItemNameFilter";
            inputItemNameFilter.Size = new Size(262, 23);
            inputItemNameFilter.TabIndex = 11;
            inputItemNameFilter.TextChanged += inputItemNameFilter_TextChanged;
            // 
            // inputStkLessThanFilter
            // 
            inputStkLessThanFilter.BackColor = Color.FromArgb(248, 248, 248);
            inputStkLessThanFilter.Location = new Point(692, 28);
            inputStkLessThanFilter.Margin = new Padding(3, 2, 3, 2);
            inputStkLessThanFilter.Name = "inputStkLessThanFilter";
            inputStkLessThanFilter.Size = new Size(262, 23);
            inputStkLessThanFilter.TabIndex = 13;
            inputStkLessThanFilter.TextChanged += inputStkLessThanFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(558, 27);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 12;
            label1.Text = "Stock Less Than";
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.False;
            // 
            // item_name
            // 
            item_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_name.HeaderText = "Item Name";
            item_name.MinimumWidth = 6;
            item_name.Name = "item_name";
            // 
            // Item_description
            // 
            Item_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Item_description.HeaderText = "Item Description";
            Item_description.MinimumWidth = 6;
            Item_description.Name = "Item_description";
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // stock
            // 
            stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            // 
            // stock_last_updated
            // 
            stock_last_updated.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stock_last_updated.HeaderText = "Stock Last Updated";
            stock_last_updated.MinimumWidth = 6;
            stock_last_updated.Name = "stock_last_updated";
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.ForeColor = Color.White;
            edit.DefaultCellStyle = dataGridViewCellStyle2;
            edit.FlatStyle = FlatStyle.Popup;
            edit.HeaderText = "Edit";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Text = "EDIT";
            edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.ForeColor = Color.White;
            delete.DefaultCellStyle = dataGridViewCellStyle3;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "Delete";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "DELETE";
            delete.UseColumnTextForButtonValue = true;
            // 
            // ViewAllItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(969, 460);
            Controls.Add(inputStkLessThanFilter);
            Controls.Add(label1);
            Controls.Add(inputItemNameFilter);
            Controls.Add(label2);
            Controls.Add(DGV_ViewAllItems);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewAllItems";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label2;
        private TextBox inputItemNameFilter;
        private TextBox inputStkLessThanFilter;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn Item_description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn stock_last_updated;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}