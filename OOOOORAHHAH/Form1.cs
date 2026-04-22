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
            using (StreamReader sr = new StreamReader("C:/Users/0408428/Downloads/emoji.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    emoji.Add(line);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            var value = rand.Next(emoji.Count());
            POKIES.Text = emoji[value];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int red = rand.Next(255);
            int blue = rand.Next(255);
            int green = rand.Next(255);



            POKIES.ForeColor = Color.FromArgb(red, blue, green);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
