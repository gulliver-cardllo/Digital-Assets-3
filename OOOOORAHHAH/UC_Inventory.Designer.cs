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
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.boxQuantity = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.boxID);
            this.groupBox1.Controls.Add(this.boxPrice);
            this.groupBox1.Controls.Add(this.boxQuantity);
            this.groupBox1.Controls.Add(this.boxName);
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
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(82, 156);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(100, 20);
            this.boxID.TabIndex = 3;
            // 
            // boxPrice
            // 
            this.boxPrice.Location = new System.Drawing.Point(82, 117);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(100, 20);
            this.boxPrice.TabIndex = 2;
            // 
            // boxQuantity
            // 
            this.boxQuantity.Location = new System.Drawing.Point(82, 80);
            this.boxQuantity.Name = "boxQuantity";
            this.boxQuantity.Size = new System.Drawing.Size(100, 20);
            this.boxQuantity.TabIndex = 1;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(82, 41);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 20);
            this.boxName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvName,
            this.InvQuantity,
            this.InvPrice,
            this.InvID});
            this.dataGridView1.Location = new System.Drawing.Point(273, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // InvName
            // 
            this.InvName.DataPropertyName = "InvName";
            this.InvName.HeaderText = "Item Name";
            this.InvName.Name = "InvName";
            // 
            // InvQuantity
            // 
            this.InvQuantity.DataPropertyName = "InvQuantity";
            this.InvQuantity.HeaderText = "Quantity";
            this.InvQuantity.Name = "InvQuantity";
            // 
            // InvPrice
            // 
            this.InvPrice.DataPropertyName = "InvPrice";
            this.InvPrice.HeaderText = "Item Price";
            this.InvPrice.Name = "InvPrice";
            // 
            // InvID
            // 
            this.InvID.DataPropertyName = "InvID";
            this.InvID.HeaderText = "Item ID";
            this.InvID.Name = "InvID";
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.TextBox boxQuantity;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvID;
    }
}
