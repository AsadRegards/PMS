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
    public partial class ViewAllItems : Form
    {
        private ItemRepository _repository;


        public ViewAllItems()
        {
            InitializeComponent();
            _repository = ItemRepository.Instance;
            PopulateDataGridView();

        }

        private void PopulateDataGridView(string itemNameFilter = "", int StockLessThanFilter = 0)
        {
            var itemList = _repository.GetAllItems(itemNameFilter, StockLessThanFilter);
            DGV_ViewAllItems.Rows.Clear();
            foreach (var item in itemList)
            {
                DGV_ViewAllItems.Rows.Add(item.ToString().Split('|'));
            }
        }

        private void DGV_ViewAllItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DGV_ViewAllItems.Rows.Count - 1)
                return;
            var rowIndex = e.RowIndex;
            var columnIndex = e.ColumnIndex;
            switch (columnIndex)
            {
                case 6: //Edit Item
                    EditItem(DGV_ViewAllItems.Rows[rowIndex].Cells[0].Value);
                    break;
                case 7: //Delete Item
                    DeleteItem(DGV_ViewAllItems.Rows[rowIndex].Cells[0].Value);
                    break;
            }
        }

        private void DeleteItem(object itemId)
        {
            int _itemId;
            if (!int.TryParse(itemId?.ToString(), out _itemId))
            {
                MessageBox.Show("Unable to Edit this Item");
                return;
            }
            else
            {
                var IsDeleted = _repository.DeleteItemById(_itemId);
                var Message = IsDeleted ? "Item Deleted" : "Unable to delete Item";
                MessageBox.Show(Message);
                PopulateDataGridView(ItemNameFilter,StockLessThanFilter);
            }
        }

        private void EditItem(object itemId)
        {
            int _itemId;
            if (!int.TryParse(itemId?.ToString(), out _itemId))
            {
                MessageBox.Show("Unable to Edit this Item");
                return;
            }
            else
            {
                var editItem = _repository.GetItemById(_itemId);
                AddNewItem addNewItem = new AddNewItem(editItem);
                addNewItem.ShowDialog();
            }

        }

        private string ItemNameFilter = "";
        private int StockLessThanFilter = 0;
        private void inputItemNameFilter_TextChanged(object sender, EventArgs e)
        {
            ItemNameFilter = inputItemNameFilter.Text;
            PopulateDataGridView(ItemNameFilter, StockLessThanFilter);
        }

        private void inputStkLessThanFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputStkLessThanFilter.Text) && !int.TryParse(inputStkLessThanFilter.Text, out _))
                return;
            StockLessThanFilter = inputStkLessThanFilter.Text == string.Empty ? 0 : Convert.ToInt32(inputStkLessThanFilter.Text);
            PopulateDataGridView(ItemNameFilter, StockLessThanFilter);
        }
    }
}
