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

namespace OOOOORAHHAH
{
    public partial class UC_Inventory : UserControl
    {
        List<String> invform = new List<string>();
        public UC_Inventory()
        {
            InitializeComponent();
            
            
        }

        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        public string csvpath = "C:/Users/0408428/Downloads/goon11.csv";

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            string path = csvpath;

            
            var tempData = ItemService.LoadFromCSV(path);

            
            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            dataGridView1.DataSource = _inventoryList;
        }








        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

