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
using MessageBox = PMS.Toast.MessageBox;

namespace PMS
{
    public partial class ViewSaleIitems : Form
    {
        SaleRepository _repository;
        List<SaleItemDTO> saleItems;
        int saleId;
        public ViewSaleIitems(int saleId)
        {
            InitializeComponent();
            this.saleId = saleId;
            _repository = SaleRepository.Instance;
        }

        private void ViewSaleIitems_Load(object sender, EventArgs e)
        {
            RefreshDataTable();
        }

        void RefreshDataTable()
        {
            saleItems = _repository.GetSaleItemsBySaleId(this.saleId);
            saleItemGridView.Rows.Clear();
            foreach (var saleItem in saleItems)
            {
                saleItemGridView.Rows.Add(saleItem.Id, saleItem.Name, saleItem.Quantity, saleItem.PricePerUnit, saleItem.TotalPrice);
            }
        }
    }
}
