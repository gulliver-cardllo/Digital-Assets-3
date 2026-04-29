using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// testing pull
namespace OOOOORAHHAH
{


    public partial class Form1 : Form
    {

        List<string> emoji = new List<string>();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("C:/Users/0408428/Downloads/emoji.csv"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Inventory());
        }
        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }
            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }
    }
}
