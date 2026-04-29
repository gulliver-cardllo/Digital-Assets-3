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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameclm,
            this.quantityclm,
            this.priceclm,
            this.itemidclm});
            this.dataGridView1.Location = new System.Drawing.Point(245, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameclm
            // 
            this.nameclm.Frozen = true;
            this.nameclm.HeaderText = "Name";
            this.nameclm.Name = "nameclm";
            // 
            // quantityclm
            // 
            this.quantityclm.Frozen = true;
            this.quantityclm.HeaderText = "Quantity";
            this.quantityclm.Name = "quantityclm";
            // 
            // priceclm
            // 
            this.priceclm.Frozen = true;
            this.priceclm.HeaderText = "Price EA";
            this.priceclm.Name = "priceclm";
            // 
            // itemidclm
            // 
            this.itemidclm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemidclm.HeaderText = "Item ID";
            this.itemidclm.Name = "itemidclm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(27, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(778, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameclm;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityclm;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceclm;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidclm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
