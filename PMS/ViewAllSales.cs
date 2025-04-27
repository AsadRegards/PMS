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
    public partial class ViewAllSales : Form
    {
        SaleRepository _respository;
        List<Sale> sales;
        public ViewAllSales()
        {
            InitializeComponent();
            _respository = SaleRepository.Instance;
        }

        DateTime startDate = DateTime.Today.AddDays(-30);
        DateTime endDate = DateTime.Now;
        private void ViewAllSales_Load(object sender, EventArgs e)
        {
            RefreshDataTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                endDatePicker.Enabled = false;
                endDatePicker.Value = startDatePicker.Value;
            }
            else
            {
                endDatePicker.Enabled = true;
            }
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDate = startDatePicker.Value;
            RefreshDataTable();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDate = endDatePicker.Value;
            RefreshDataTable();
        }

        void RefreshDataTable()
        { 
            sales = _respository.GetAllSales(startDate, endDate);
            dataGridView1.Rows.Clear();
            foreach (var sale in sales)
            {
                dataGridView1.Rows.Add(sale.Id, sale.SaleDate, sale.DiscountType.ToString(), sale.Discount,sale.Amount);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.Rows.Count - 1 || e.RowIndex == -1)
                return;

            int saleId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if(e.ColumnIndex == 5) //View Sale Items Column
            {
                ViewSaleIitems vsi = new ViewSaleIitems(saleId);
                vsi.ShowDialog();
                RefreshDataTable();
                
            }
            else if (e.ColumnIndex == 6) //Return
            {
               
            }
        }
    }
}
