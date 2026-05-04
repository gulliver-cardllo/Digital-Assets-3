namespace OOOOORAHHAH
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncart = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(583, 311);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 31);
            this.label.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btncart);
            this.groupBox1.Controls.Add(this.btninventory);
            this.groupBox1.Controls.Add(this.btnmenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btncart
            // 
            this.btncart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btncart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncart.Location = new System.Drawing.Point(3, 121);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(191, 52);
            this.btncart.TabIndex = 2;
            this.btncart.Text = "Cart";
            this.btncart.UseVisualStyleBackColor = false;
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btninventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninventory.Location = new System.Drawing.Point(3, 69);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(191, 52);
            this.btninventory.TabIndex = 1;
            this.btninventory.Text = "Inventory";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu.Location = new System.Drawing.Point(3, 17);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(191, 52);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.Text = "Main Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(761, 450);
            this.pnlContent.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncart;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Panel pnlContent;
    }
}

