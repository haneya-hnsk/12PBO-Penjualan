namespace penjualan
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.tnb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tthj = new System.Windows.Forms.TextBox();
            this.tk = new System.Windows.Forms.TextBox();
            this.tthb = new System.Windows.Forms.TextBox();
            this.tj = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.barang = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Master Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Jual";
            // 
            // tid
            // 
            this.tid.Enabled = false;
            this.tid.Location = new System.Drawing.Point(117, 68);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(140, 20);
            this.tid.TabIndex = 4;
            // 
            // tnb
            // 
            this.tnb.Location = new System.Drawing.Point(117, 94);
            this.tnb.Name = "tnb";
            this.tnb.Size = new System.Drawing.Size(140, 20);
            this.tnb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Jual Barang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tthj);
            this.groupBox1.Controls.Add(this.tk);
            this.groupBox1.Controls.Add(this.tthb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(55, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 248);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penjualan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Keuntungan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Harga Beli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Harga Jual";
            // 
            // tthj
            // 
            this.tthj.Location = new System.Drawing.Point(43, 55);
            this.tthj.Name = "tthj";
            this.tthj.Size = new System.Drawing.Size(255, 23);
            this.tthj.TabIndex = 9;
            // 
            // tk
            // 
            this.tk.Location = new System.Drawing.Point(43, 196);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(255, 23);
            this.tk.TabIndex = 8;
            // 
            // tthb
            // 
            this.tthb.Location = new System.Drawing.Point(43, 124);
            this.tthb.Name = "tthb";
            this.tthb.Size = new System.Drawing.Size(255, 23);
            this.tthb.TabIndex = 7;
            // 
            // tj
            // 
            this.tj.Location = new System.Drawing.Point(117, 120);
            this.tj.Name = "tj";
            this.tj.Size = new System.Drawing.Size(255, 20);
            this.tj.TabIndex = 6;
            this.tj.TextChanged += new System.EventHandler(this.tj_TextChanged);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(424, 88);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(361, 20);
            this.tc.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(791, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // barang
            // 
            this.barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang.Location = new System.Drawing.Point(424, 118);
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(456, 317);
            this.barang.TabIndex = 11;
            this.barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barang_CellClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(886, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 43);
            this.button6.TabIndex = 22;
            this.button6.Text = "Data Penjualan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(886, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 43);
            this.button5.TabIndex = 21;
            this.button5.Text = "Data Barang";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 496);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tj);
            this.Controls.Add(this.tnb);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox tnb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tthj;
        private System.Windows.Forms.TextBox tk;
        private System.Windows.Forms.TextBox tthb;
        private System.Windows.Forms.TextBox tj;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView barang;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}