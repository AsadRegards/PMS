namespace PMS
{
    partial class ViewAllSales
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
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label1 = new Label();
            label2 = new Label();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            orderId = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            discountType = new DataGridViewTextBoxColumn();
            discountValue = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            action = new DataGridViewLinkColumn();
            returnbtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 22, 59);
            label1.Location = new Point(61, 60);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 1;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 22, 59);
            label2.Location = new Point(503, 56);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 2;
            label2.Text = "End Date";
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(189, 60);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(250, 27);
            startDatePicker.TabIndex = 3;
            startDatePicker.ValueChanged += startDatePicker_ValueChanged;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(619, 60);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(250, 27);
            endDatePicker.TabIndex = 4;
            endDatePicker.ValueChanged += endDatePicker_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(512, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(216, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "End Date same as start date";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderId, orderDate, discountType, discountValue, amount, action, returnbtn });
            dataGridView1.Location = new Point(12, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1228, 575);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // orderId
            // 
            orderId.HeaderText = "Order Id";
            orderId.MinimumWidth = 6;
            orderId.Name = "orderId";
            orderId.ReadOnly = true;
            orderId.Width = 125;
            // 
            // orderDate
            // 
            orderDate.HeaderText = "Order Date";
            orderDate.MinimumWidth = 6;
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 325;
            // 
            // discountType
            // 
            discountType.HeaderText = "Discount Type";
            discountType.MinimumWidth = 6;
            discountType.Name = "discountType";
            discountType.ReadOnly = true;
            discountType.Width = 125;
            // 
            // discountValue
            // 
            discountValue.HeaderText = "Discount Value";
            discountValue.MinimumWidth = 6;
            discountValue.Name = "discountValue";
            discountValue.ReadOnly = true;
            discountValue.Width = 125;
            // 
            // amount
            // 
            amount.HeaderText = "Sale Amount";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 125;
            // 
            // action
            // 
            action.HeaderText = "";
            action.MinimumWidth = 6;
            action.Name = "action";
            action.ReadOnly = true;
            action.Text = "View Sale Items";
            action.UseColumnTextForLinkValue = true;
            action.Width = 225;
            // 
            // returnbtn
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            returnbtn.DefaultCellStyle = dataGridViewCellStyle1;
            returnbtn.FlatStyle = FlatStyle.Popup;
            returnbtn.HeaderText = "";
            returnbtn.MinimumWidth = 6;
            returnbtn.Name = "returnbtn";
            returnbtn.ReadOnly = true;
            returnbtn.Text = "Return";
            returnbtn.UseColumnTextForButtonValue = true;
            returnbtn.Width = 125;
            // 
            // ViewAllSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 779);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewAllSales";
            Text = "ViewAllSales";
            Load += ViewAllSales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label1;
        private Label label2;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderId;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn discountType;
        private DataGridViewTextBoxColumn discountValue;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewLinkColumn action;
        private DataGridViewButtonColumn returnbtn;
    }
}