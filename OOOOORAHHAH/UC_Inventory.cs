using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace OOOOORAHHAH
{

    public partial class UC_Inventory : UserControl
    {
 
        public UC_Inventory()
        {
            InitializeComponent();
            
            
        }

        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        public string csvpath = "./products.csv";
        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            int itemid = _inventoryList.Count + 1000;
            string name = boxName.Text;
            double price = double.Parse(boxPrice.Text);
            int quantity = int.Parse(boxQuantity.Text);

            Product newProduct = new Product(name, quantity, price, itemid);
            _bindingSource.ResetBindings(false);
            _inventoryList.Add(newProduct);
            ClearTxt();

            try
            {
                List<Product> listToSave = _inventoryList.ToList();
                ItemService.SaveCSV(csvpath, listToSave);
                MessageBox.Show("Item Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(boxName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                return false;
            }
            if (!decimal.TryParse(boxPrice.Text, out decimal price) || price < 0)
            {
                return false;
            }
            if (!int.TryParse(boxQuantity.Text, out int qty) || qty < 0)
            {
                return false;
            }
            return true;
        }

        private void ClearTxt()
        {
            boxID.Clear();
            boxName.Clear();
            boxPrice.Clear();
            boxQuantity.Clear();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(boxID.Text, out int idToUpdate))
            {
                return;
            }
            else
            {
                var productToUpdate = _inventoryList.FirstOrDefault(p => p.InvID == idToUpdate);
                if (productToUpdate != null)
                {
                    if (ValidateInputs())
                    {

                        productToUpdate.InvName = boxName.Text;
                        productToUpdate.InvQuantity = int.Parse(boxQuantity.Text);
                        productToUpdate.InvPrice = double.Parse(boxPrice.Text);
                        productToUpdate.InvID = int.Parse(boxID.Text);

                        _bindingSource.ResetBindings(false);
                        dataGridView1.Refresh();
                        ClearTxt();

                    }
                }
            }


        }

        private void UC_Inventory_Load_1(object sender, EventArgs e)
        {
            string path = csvpath;


            var tempData = ItemService.LoadFromCSV(path);


            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _inventoryList;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                boxName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                boxID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                boxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                boxQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();

            }
        }
    }

}

