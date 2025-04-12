using PMS.PMS.Data.Repositories;
using PMS.PMS.Model;

namespace PMS
{
    public partial class AddNewItem : Form
    {
        private ItemRepository _respository;
        private static bool isEditItem = false;
        public static int editItemId = 0;
        public AddNewItem()
        {
            InitializeComponent();
            InitializeItemTypeComboBox();
            _respository = ItemRepository.Instance;
        }

        public AddNewItem(Item item) {
            InitializeComponent();
            InitializeItemTypeComboBox();
            _respository = ItemRepository.Instance;
            PopulateItemFields(item);
        }

        private void PopulateItemFields(Item item)
        {
            inputItemName.Text = item.Name;
            inputItemDescription.Text = item.Description;
            inputItemPrice.Text = item.CurrentPricePerUnit.ToString();
            inputItemStock.Text = item.Stock.ToString();
            itemTypeCombo.SelectedText = item.Type;
            isEditItem = true;
            editItemId = item.Id;

        }

        private void InitializeItemTypeComboBox()
        {
            List<string> itemTypes = new List<string>
            {
                "Prescription Medications",
                "Over-the-Counter Medications",
                "Vitamins & Supplements",
                "Personal Care Products",
                "Beauty & Skin Care",
                "Health & Wellness",
                "First Aid",
                "Medical Equipment",
                "Herbal Remedies",
                "Baby Care",
                "Dental Care",
                "Cold & Flu",
                "Pain Relief",
                "Eye & Ear Care",
                "Diabetes Care",
                "Nutritional Products",
                "Foot Care",
                "Incontinence Products",
                "Wound Care",
                "Anti-Allergy"
            };

            itemTypeCombo.DataSource = itemTypes;
        }

        private void addNewItemBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateNewItem(inputItemName.Text, inputItemPrice.Text, inputItemStock.Text))
            {
                return;
            }
            Item item = new Item()
            {
                Name = inputItemName.Text,
                Description = inputItemDescription.Text,
                CurrentPricePerUnit = Convert.ToInt32(inputItemPrice.Text),
                Stock = Convert.ToInt32(inputItemStock.Text),
                Type = itemTypeCombo.SelectedText

            };
            if (_respository.SaveItem(item,isEditItem,editItemId))
            {
                MessageBox.Show($"Item Saved Successfully");
                isEditItem = false;
                editItemId = 0;
                Dashboard.ShowNewFormInPanel(new ViewAllItems());
                this.Hide();
            }
            else
                MessageBox.Show("Unable to add Item at this time");
        }

        private bool ValidateNewItem(string itemName, string itemPrice, string itemStock)
        {
            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Please enter Valid Item Name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(itemPrice) || !int.TryParse(itemPrice,out _))
            {
                MessageBox.Show("Please enter Valid Item Price");
                return false;
            }
            if (string.IsNullOrWhiteSpace(itemStock) || !int.TryParse(itemStock, out _))
            {
                MessageBox.Show("Please enter Valid # of Item Stock");
                return false;
            }
            return true;
        }
    }
}
