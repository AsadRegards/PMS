namespace PMS
{
    partial class AddSaleItem
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
            label2 = new Label();
            fixedDiscount = new RadioButton();
            percentDiscount = new RadioButton();
            discountFlag = new CheckBox();
            discountValue = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            totalAmountLabel = new Label();
            filterItemList = new ComboBox();
            addSaleBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            currentUser = new Label();
            currentDateTime = new Label();
            Item = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            availableQuantity = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)saleItemGridView).BeginInit();
            SuspendLayout();
            // 
            // saleItemGridView
            // 
            saleItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleItemGridView.Columns.AddRange(new DataGridViewColumn[] { Item, Quantity, UnitPrice, availableQuantity, totalPrice, delete });
            saleItemGridView.Location = new Point(12, 155);
            saleItemGridView.Name = "saleItemGridView";
            saleItemGridView.RowHeadersWidth = 51;
            saleItemGridView.Size = new Size(1103, 612);
            saleItemGridView.TabIndex = 0;
            saleItemGridView.CellContentClick += saleItemGridView_CellContentClick;
            saleItemGridView.CellValueChanged += saleItemGridView_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 11;
            label2.Text = "Item Name";
            // 
            // fixedDiscount
            // 
            fixedDiscount.AutoSize = true;
            fixedDiscount.Location = new Point(1139, 401);
            fixedDiscount.Name = "fixedDiscount";
            fixedDiscount.Size = new Size(127, 24);
            fixedDiscount.TabIndex = 12;
            fixedDiscount.TabStop = true;
            fixedDiscount.Text = "Fixed Discount";
            fixedDiscount.UseVisualStyleBackColor = true;
            fixedDiscount.CheckedChanged += discountOption_CheckedChanged;
            // 
            // percentDiscount
            // 
            percentDiscount.AutoSize = true;
            percentDiscount.Location = new Point(1300, 401);
            percentDiscount.Name = "percentDiscount";
            percentDiscount.Size = new Size(165, 24);
            percentDiscount.TabIndex = 13;
            percentDiscount.TabStop = true;
            percentDiscount.Text = "Percentage Discount";
            percentDiscount.UseVisualStyleBackColor = true;
            percentDiscount.CheckedChanged += discountOption_CheckedChanged;
            // 
            // discountFlag
            // 
            discountFlag.AutoSize = true;
            discountFlag.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountFlag.Location = new Point(1201, 341);
            discountFlag.Name = "discountFlag";
            discountFlag.Size = new Size(185, 35);
            discountFlag.TabIndex = 14;
            discountFlag.Text = "Give Discount";
            discountFlag.UseVisualStyleBackColor = true;
            discountFlag.CheckedChanged += discountFlag_CheckedChanged;
            // 
            // discountValue
            // 
            discountValue.Location = new Point(1240, 467);
            discountValue.Name = "discountValue";
            discountValue.Size = new Size(210, 27);
            discountValue.TabIndex = 15;
            discountValue.TextChanged += discountValue_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1147, 469);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 17;
            label3.Text = "Discount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1201, 580);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 18;
            label1.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(1240, 646);
            label4.Name = "label4";
            label4.Size = new Size(55, 37);
            label4.TabIndex = 19;
            label4.Text = "Rs.";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountLabel.ForeColor = Color.Blue;
            totalAmountLabel.Location = new Point(1291, 646);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(34, 37);
            totalAmountLabel.TabIndex = 20;
            totalAmountLabel.Text = "0";
            // 
            // filterItemList
            // 
            filterItemList.AutoCompleteMode = AutoCompleteMode.Suggest;
            filterItemList.AutoCompleteSource = AutoCompleteSource.ListItems;
            filterItemList.FormattingEnabled = true;
            filterItemList.Location = new Point(153, 64);
            filterItemList.Name = "filterItemList";
            filterItemList.Size = new Size(443, 28);
            filterItemList.TabIndex = 21;
            filterItemList.KeyDown += filterItemList_KeyDown;
            // 
            // addSaleBtn
            // 
            addSaleBtn.Location = new Point(1240, 67);
            addSaleBtn.Name = "addSaleBtn";
            addSaleBtn.Size = new Size(179, 89);
            addSaleBtn.TabIndex = 22;
            addSaleBtn.Text = "AddSale";
            addSaleBtn.UseVisualStyleBackColor = true;
            addSaleBtn.Click += addSaleBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(692, 41);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 23;
            label5.Text = "User:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(642, 88);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 24;
            label6.Text = "Date Time:";
            // 
            // currentUser
            // 
            currentUser.AutoSize = true;
            currentUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUser.ForeColor = Color.FromArgb(0, 192, 0);
            currentUser.Location = new Point(765, 41);
            currentUser.Name = "currentUser";
            currentUser.Size = new Size(133, 25);
            currentUser.TabIndex = 25;
            currentUser.Text = "[[User Name]]";
            // 
            // currentDateTime
            // 
            currentDateTime.AutoSize = true;
            currentDateTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentDateTime.ForeColor = Color.Blue;
            currentDateTime.Location = new Point(765, 88);
            currentDateTime.Name = "currentDateTime";
            currentDateTime.Size = new Size(127, 25);
            currentDateTime.TabIndex = 26;
            currentDateTime.Text = "[[Date Time]]";
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
            // AddSaleItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 779);
            Controls.Add(currentDateTime);
            Controls.Add(currentUser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(addSaleBtn);
            Controls.Add(filterItemList);
            Controls.Add(totalAmountLabel);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(discountValue);
            Controls.Add(discountFlag);
            Controls.Add(percentDiscount);
            Controls.Add(fixedDiscount);
            Controls.Add(label2);
            Controls.Add(saleItemGridView);
            Name = "AddSaleItem";
            Text = "AddSaleItem";
            Load += AddSaleItem_Load;
            ((System.ComponentModel.ISupportInitialize)saleItemGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView saleItemGridView;
        private Label label2;
        private RadioButton fixedDiscount;
        private RadioButton percentDiscount;
        private CheckBox discountFlag;
        private TextBox discountValue;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label totalAmountLabel;
        private ComboBox filterItemList;
        private Button addSaleBtn;
        private Label label5;
        private Label label6;
        private Label currentUser;
        private Label currentDateTime;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn availableQuantity;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewButtonColumn delete;
    }
}