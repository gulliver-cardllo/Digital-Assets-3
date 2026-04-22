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
            this.button1 = new System.Windows.Forms.Button();
            this.POKIES = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "EMOJI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // POKIES
            // 
            this.POKIES.AutoSize = true;
            this.POKIES.Font = new System.Drawing.Font("Felix Titling", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POKIES.Location = new System.Drawing.Point(452, 198);
            this.POKIES.Name = "POKIES";
            this.POKIES.Size = new System.Drawing.Size(291, 39);
            this.POKIES.TabIndex = 1;
            this.POKIES.Text = "SLOT MACHINES";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 82);
            this.button2.TabIndex = 2;
            this.button2.Text = "COLOUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.POKIES);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label POKIES;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label;
    }
}

