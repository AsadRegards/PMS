namespace PMS
{
    partial class AddNewItem
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            inputItemName = new TextBox();
            inputItemDescription = new RichTextBox();
            inputItemStock = new TextBox();
            inputItemPrice = new TextBox();
            itemTypeCombo = new ComboBox();
            label7 = new Label();
            addNewItemBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(378, 52);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 7;
            label2.Text = "Add New Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 135);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 10;
            label3.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 187);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 11;
            label1.Text = "Item Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 297);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 12;
            label4.Text = "Item Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 352);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 13;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 406);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 14;
            label6.Text = "Price Per Unit";
            // 
            // inputItemName
            // 
            inputItemName.Location = new Point(286, 135);
            inputItemName.Name = "inputItemName";
            inputItemName.Size = new Size(570, 27);
            inputItemName.TabIndex = 15;
            // 
            // inputItemDescription
            // 
            inputItemDescription.Location = new Point(286, 187);
            inputItemDescription.Name = "inputItemDescription";
            inputItemDescription.Size = new Size(570, 106);
            inputItemDescription.TabIndex = 16;
            inputItemDescription.Text = "";
            // 
            // inputItemStock
            // 
            inputItemStock.Location = new Point(286, 352);
            inputItemStock.Name = "inputItemStock";
            inputItemStock.Size = new Size(570, 27);
            inputItemStock.TabIndex = 17;
            // 
            // inputItemPrice
            // 
            inputItemPrice.Location = new Point(286, 404);
            inputItemPrice.Name = "inputItemPrice";
            inputItemPrice.Size = new Size(570, 27);
            inputItemPrice.TabIndex = 18;
            // 
            // itemTypeCombo
            // 
            itemTypeCombo.FormattingEnabled = true;
            itemTypeCombo.Location = new Point(286, 308);
            itemTypeCombo.Name = "itemTypeCombo";
            itemTypeCombo.Size = new Size(337, 28);
            itemTypeCombo.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 457);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(975, 28);
            label7.TabIndex = 20;
            label7.Text = "\"اگر آپ یہ آئٹم ایک گولی کے طور پر بیچ رہے ہیں تو براہ کرم ایک گولی کی قیمت درج کریں، ورنہ پوری بوتل/ڈبے کی قیمت درج کریں۔\"";
            // 
            // addNewItemBtn
            // 
            addNewItemBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewItemBtn.Location = new Point(462, 505);
            addNewItemBtn.Name = "addNewItemBtn";
            addNewItemBtn.Size = new Size(184, 67);
            addNewItemBtn.TabIndex = 21;
            addNewItemBtn.Text = "Add Item";
            addNewItemBtn.UseVisualStyleBackColor = true;
            addNewItemBtn.Click += addNewItemBtn_Click;
            // 
            // AddNewItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 631);
            Controls.Add(addNewItemBtn);
            Controls.Add(label7);
            Controls.Add(itemTypeCombo);
            Controls.Add(inputItemPrice);
            Controls.Add(inputItemStock);
            Controls.Add(inputItemDescription);
            Controls.Add(inputItemName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddNewItem";
            Text = "AddNewItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox inputItemName;
        private RichTextBox inputItemDescription;
        private TextBox inputItemStock;
        private TextBox inputItemPrice;
        private ComboBox itemTypeCombo;
        private Label label7;
        private Button addNewItemBtn;
    }
}