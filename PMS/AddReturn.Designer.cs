namespace PMS
{
    partial class AddReturn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            saleItemGridView = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            availableQuantity = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            label1 = new Label();
            labelOrderId = new Label();
            totalAmountLabel = new Label();
            label4 = new Label();
            label2 = new Label();
            completeSaleReturnBtn = new Button();
            returnSelectedBtn = new Button();
            exchangeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)saleItemGridView).BeginInit();
            SuspendLayout();
            // 
            // saleItemGridView
            // 
            saleItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleItemGridView.Columns.AddRange(new DataGridViewColumn[] { Item, Quantity, UnitPrice, availableQuantity, totalPrice, delete });
            saleItemGridView.Location = new Point(12, 208);
            saleItemGridView.Name = "saleItemGridView";
            saleItemGridView.RowHeadersWidth = 51;
            saleItemGridView.Size = new Size(1103, 612);
            saleItemGridView.TabIndex = 1;
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
            // availableQuantity
            // 
            availableQuantity.HeaderText = "Available Quantity";
            availableQuantity.MinimumWidth = 6;
            availableQuantity.Name = "availableQuantity";
            availableQuantity.ReadOnly = true;
            availableQuantity.Visible = false;
            availableQuantity.Width = 125;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "Total Price";
            totalPrice.MinimumWidth = 6;
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Width = 125;
            // 
            // delete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.ForeColor = Color.White;
            delete.DefaultCellStyle = dataGridViewCellStyle1;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(452, 37);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 13;
            label1.Text = "Returning Order # ";
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrderId.Location = new Point(621, 37);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(52, 25);
            labelOrderId.TabIndex = 14;
            labelOrderId.Text = "0001";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountLabel.ForeColor = Color.Blue;
            totalAmountLabel.Location = new Point(1301, 635);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(34, 37);
            totalAmountLabel.TabIndex = 23;
            totalAmountLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(1250, 635);
            label4.Name = "label4";
            label4.Size = new Size(55, 37);
            label4.TabIndex = 22;
            label4.Text = "Rs.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1147, 585);
            label2.Name = "label2";
            label2.Size = new Size(306, 37);
            label2.TabIndex = 21;
            label2.Text = "Total Return Amount";
            // 
            // completeSaleReturnBtn
            // 
            completeSaleReturnBtn.Location = new Point(1203, 51);
            completeSaleReturnBtn.Name = "completeSaleReturnBtn";
            completeSaleReturnBtn.Size = new Size(188, 29);
            completeSaleReturnBtn.TabIndex = 24;
            completeSaleReturnBtn.Text = "Return Complete Sale";
            completeSaleReturnBtn.UseVisualStyleBackColor = true;
            completeSaleReturnBtn.Click += completeSaleReturnBtn_Click;
            // 
            // returnSelectedBtn
            // 
            returnSelectedBtn.Location = new Point(1203, 86);
            returnSelectedBtn.Name = "returnSelectedBtn";
            returnSelectedBtn.Size = new Size(188, 29);
            returnSelectedBtn.TabIndex = 25;
            returnSelectedBtn.Text = "Return Selected Items";
            returnSelectedBtn.UseVisualStyleBackColor = true;
            returnSelectedBtn.Click += returnSelectedBtn_Click;
            // 
            // exchangeBtn
            // 
            exchangeBtn.Location = new Point(1203, 121);
            exchangeBtn.Name = "exchangeBtn";
            exchangeBtn.Size = new Size(188, 29);
            exchangeBtn.TabIndex = 26;
            exchangeBtn.Text = "Exchange";
            exchangeBtn.UseVisualStyleBackColor = true;
            exchangeBtn.Click += exchangeBtn_Click;
            // 
            // AddReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 832);
            Controls.Add(exchangeBtn);
            Controls.Add(returnSelectedBtn);
            Controls.Add(completeSaleReturnBtn);
            Controls.Add(totalAmountLabel);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelOrderId);
            Controls.Add(label1);
            Controls.Add(saleItemGridView);
            Name = "AddReturn";
            Text = "AddReturn";
            ((System.ComponentModel.ISupportInitialize)saleItemGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView saleItemGridView;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn availableQuantity;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewButtonColumn delete;
        private Label label1;
        private Label labelOrderId;
        private Label totalAmountLabel;
        private Label label4;
        private Label label2;
        private Button completeSaleReturnBtn;
        private Button returnSelectedBtn;
        private Button exchangeBtn;
    }
}