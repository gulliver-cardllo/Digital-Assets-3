namespace OOOOORAHHAH
{
    partial class UC_Inventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pricelbl);
            this.groupBox1.Controls.Add(this.quantitylbl);
            this.groupBox1.Controls.Add(this.namelbl);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Inventory";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(26, 224);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(157, 23);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(107, 195);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(75, 23);
            this.removebtn.TabIndex = 9;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(26, 195);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item ID";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(23, 120);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(31, 13);
            this.pricelbl.TabIndex = 6;
            this.pricelbl.Text = "Price";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Location = new System.Drawing.Point(23, 83);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(46, 13);
            this.quantitylbl.TabIndex = 5;
            this.quantitylbl.Text = "Quantity";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(23, 44);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 4;
            this.namelbl.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvName,
            this.InvQuantity,
            this.InvPrice,
            this.InvID});
            this.dataGridView1.Location = new System.Drawing.Point(245, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InvName
            // 
            this.InvName.DataPropertyName = "InvName";
            this.InvName.Frozen = true;
            this.InvName.HeaderText = "Name";
            this.InvName.Name = "InvName";
            this.InvName.ReadOnly = true;
            // 
            // InvQuantity
            // 
            this.InvQuantity.DataPropertyName = "InvQuantity ";
            this.InvQuantity.Frozen = true;
            this.InvQuantity.HeaderText = "Quantity";
            this.InvQuantity.Name = "InvQuantity";
            this.InvQuantity.ReadOnly = true;
            // 
            // InvPrice
            // 
            this.InvPrice.DataPropertyName = "InvPrice";
            this.InvPrice.Frozen = true;
            this.InvPrice.HeaderText = "Price EA";
            this.InvPrice.Name = "InvPrice";
            this.InvPrice.ReadOnly = true;
            // 
            // InvID
            // 
            this.InvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InvID.DataPropertyName = "InvID";
            this.InvID.Frozen = true;
            this.InvID.HeaderText = "Item ID";
            this.InvID.Name = "InvID";
            this.InvID.ReadOnly = true;
            this.InvID.Width = 131;
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(778, 477);
            this.Load += new System.EventHandler(this.UC_Inventory_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvID;
    }
}
