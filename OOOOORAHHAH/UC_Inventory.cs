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
            using (StreamReader sr = new StreamReader("H:/Programming/OOOOORAHHAH/OOOOORAHHAH/test - Sheet1.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    invform.Add(line);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
