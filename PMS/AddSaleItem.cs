using PMS.PMS.Data.Repositories;
using PMS.PMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class AddSaleItem : Form
    {
        public List<SaleItem> saleItems { get; set; }
        private ItemRepository _repository;
        private UserRepository _userRepository;
        private SaleRepository _saleRepository;
        List<Item> ItemList = new();
        public AddSaleItem()
        {
            InitializeComponent();
            saleItems = new List<SaleItem>();
            _repository = ItemRepository.Instance;
            _userRepository = UserRepository.Instance;
            _saleRepository = SaleRepository.Instance;
        }

        private void saleItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == saleItemGridView.Rows.Count - 1)
                return;

            if (e.ColumnIndex == 5) //Delete Button
            {
                saleItemGridView.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Item Deleted From Sale");
                updateTotalPrice();
            }

        }

        private void saleItemGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == saleItemGridView.Rows.Count - 1 || e.RowIndex == -1)
                return;
            if (e.ColumnIndex == 1) //quantity
            { 
                int newQuantity = 0;
                var cellValue = saleItemGridView.Rows[e.RowIndex].Cells[1].Value?.ToString();
                var ItemName = saleItemGridView.Rows[e.RowIndex].Cells[0].Value?.ToString();
                var availableQuantity = Convert.ToInt32(saleItemGridView.Rows[e.RowIndex].Cells["availableQuantity"].Value);
                if (!int.TryParse(cellValue, out newQuantity) || newQuantity <=0)
                {
                    saleItemGridView.Rows[e.RowIndex].Cells[1].Value = 1;
                    saleItemGridView.Rows[e.RowIndex].Cells[4].Value = saleItemGridView.Rows[e.RowIndex].Cells[2].Value;
                    MessageBox.Show("Please enter correct value for Quantity");
                }
                else if(newQuantity > availableQuantity)
                {
                    saleItemGridView.Rows[e.RowIndex].Cells[1].Value = 1;
                    saleItemGridView.Rows[e.RowIndex].Cells[4].Value = saleItemGridView.Rows[e.RowIndex].Cells[2].Value;
                    MessageBox.Show($"{ItemName} are only {availableQuantity} left in stock");
                }
                else
                {
                    var unitPriceOfTheItemOfWhichQuantityUpdated = Convert.ToInt32(saleItemGridView.Rows[e.RowIndex].Cells[2].Value);
                    saleItemGridView.Rows[e.RowIndex].Cells[4].Value = newQuantity * unitPriceOfTheItemOfWhichQuantityUpdated;
                }
                updateTotalPrice();
            }
        }

        private int totalSalePrice;
        private int discountAmount;
        private void updateTotalPrice()
        {
            totalSalePrice = 0;
            foreach (DataGridViewRow row in saleItemGridView.Rows)
            {
                totalSalePrice += Convert.ToInt32(row?.Cells[4]?.Value);
            }
            totalAmountLabel.Text = (totalSalePrice - discountAmount).ToString();
        }

        private void discountFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (!discountFlag.Checked)
            {
                percentDiscount.Enabled = percentDiscount.Checked = false;
                fixedDiscount.Enabled = fixedDiscount.Checked =  false;
                discountValue.Enabled = false;
                discountValue.Text = "";
                discountValue_TextChanged(null, null);
            }
            else
            {
                percentDiscount.Enabled = true;
                fixedDiscount.Enabled = true;
                fixedDiscount.Checked = true; //checking fixed discount by default
                discountValue.Enabled = true;
            }
        }

        int checkItemInGridView(string itemName)
        {

            for (int i = 0; i < saleItemGridView.Rows.Count; i++)
            {
                if (saleItemGridView.Rows.Count == 1 || i == saleItemGridView.Rows.Count - 1)
                {
                    break;
                }
                if (saleItemGridView.Rows[i].Cells[0].Value.ToString() == itemName)
                {
                    return i;
                }
            }

            return -1;
        }

        private void AddSaleItem_Load(object sender, EventArgs e)
        {
            ItemList = _repository.GetAllItems(useCache:false);
            filterItemList.Items.AddRange(ItemList.Select(x => x.Name).ToArray());
            discountFlag_CheckedChanged(null, null);
            currentUser.Text = _userRepository.CurrentUser.Name;
            currentDateTime.Text = DateTime.Now.ToString("F");
        }

        private void filterItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                var itemToAdd = ItemList.FirstOrDefault(x => x.Name == filterItemList.SelectedItem?.ToString());
                if(itemToAdd == null)
                {
                    return;
                }
                if (itemToAdd?.Stock > 0)
                {
                    var existingIndex = checkItemInGridView(itemToAdd.Name);

                    if (existingIndex > -1)
                    {
                        saleItemGridView.Rows[existingIndex].Cells[1].Value = Convert.ToInt32(saleItemGridView.Rows[existingIndex].Cells[1].Value) + 1;
                        saleItemGridView.ClearSelection();
                        saleItemGridView.Rows[existingIndex].Selected = true;
                        
                    }
                    else
                    {
                        saleItemGridView.Rows.Add(itemToAdd.Name, 1, itemToAdd.CurrentPricePerUnit,itemToAdd.Stock,itemToAdd.CurrentPricePerUnit); //Initially adding only 1 quantity for each item user can edit direclty in grid view.

                    }
                    Console.Beep();
                }
                else
                {
                    MessageBox.Show($"Item {itemToAdd.Name} is out of stock, Please ReStock");
                }
                updateTotalPrice();
                filterItemList.Text = "";
            }
        }

        #region Discount Calculation

        private DiscountType discountType = DiscountType.None;
        private void discountOption_CheckedChanged(object sender, EventArgs e)
        {
            discountType = DiscountType.None;   
            if (fixedDiscount.Checked)
            {
                discountType = DiscountType.fixedAmount;
            }
            else if (percentDiscount.Checked)
            {
                discountType = DiscountType.percentage;
            }

            discountValue_TextChanged(null, null);
        }


        private void discountValue_TextChanged(object sender, EventArgs e)
        {
            int _discount = 0;
            if (!int.TryParse(discountValue.Text, out _discount) && _discount <= 0)
            {
                if (sender != null && discountFlag.Checked)
                {
                    MessageBox.Show("Please Enter Correct Discount Value");
                }
            }

            if (discountType == DiscountType.None)
                discountAmount = 0;
            else if (discountType == DiscountType.fixedAmount)
                discountAmount = _discount;
            else
                discountAmount = (int)((Math.Min(_discount, 100) / 100.0) * totalSalePrice);

            totalAmountLabel.Text = (totalSalePrice - discountAmount).ToString();


        }

        #endregion

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            var errorMessage = ValidateSale();
            if (!string.IsNullOrEmpty(errorMessage)) { 
                MessageBox.Show(errorMessage);
                return;
            }
            int totalSalePrice = 0;
            for (int i = 0; i < saleItemGridView.Rows.Count; i++) {
                if (saleItemGridView.Rows.Count == 1 || i == saleItemGridView.Rows.Count - 1)
                {
                    break;
                }
                SaleItem item =  new SaleItem();
                item.ItemId = ItemList.Where(x => x.Name == saleItemGridView.Rows[i].Cells[0].Value.ToString()).FirstOrDefault().Id;
                item.Quantity = Convert.ToInt32(saleItemGridView.Rows[i].Cells[1].Value);
                item.PricePerUnit = Convert.ToInt32(saleItemGridView.Rows[i].Cells[2].Value);
                totalSalePrice += (item.PricePerUnit * item.Quantity);
                saleItems.Add(item);
            }
            Sale sale = new();
            sale.Status = Status.Success;
            sale.SaleItems = saleItems;
            sale.UserId = _userRepository.CurrentUser.Id;   
            sale.SaleDate = DateTime.Now;
            sale.Discount = discountAmount;
            sale.DiscountType = discountType;
            sale.Amount = totalSalePrice - discountAmount;
            _saleRepository.SaveSale(sale);
            MessageBox.Show("Sale Added succesfully");
            Dashboard.ShowNewFormInPanel(new ViewAllItems());
            
            
        }

        private string ValidateSale() //currently no validation as such added method to add future validations if any
        {
            return "";
        }
    }
}
