namespace penjualan
{
    partial class Form2
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
            this.barang = new System.Windows.Forms.DataGridView();
            this.tid = new System.Windows.Forms.TextBox();
            this.thb = new System.Windows.Forms.TextBox();
            this.tnb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thj = new System.Windows.Forms.TextBox();
            this.ts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barang
            // 
            this.barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.nb,
            this.hb,
            this.hj,
            this.s});
            this.barang.Location = new System.Drawing.Point(78, 284);
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(544, 234);
            this.barang.TabIndex = 0;
            this.barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barang_CellClick_1);
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(208, 60);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(174, 20);
            this.tid.TabIndex = 1;
            // 
            // thb
            // 
            this.thb.Location = new System.Drawing.Point(208, 138);
            this.thb.Name = "thb";
            this.thb.Size = new System.Drawing.Size(174, 20);
            this.thb.TabIndex = 3;
            // 
            // tnb
            // 
            this.tnb.Location = new System.Drawing.Point(208, 96);
            this.tnb.Name = "tnb";
            this.tnb.Size = new System.Drawing.Size(174, 20);
            this.tnb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Barang";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stok";
            // 
            // thj
            // 
            this.thj.Location = new System.Drawing.Point(208, 174);
            this.thj.Name = "thj";
            this.thj.Size = new System.Drawing.Size(174, 20);
            this.thj.TabIndex = 10;
            // 
            // ts
            // 
            this.ts.Location = new System.Drawing.Point(208, 213);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(174, 20);
            this.ts.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(19, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(78, 251);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(461, 20);
            this.tc.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Cari";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(257, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Barang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(409, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 194);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aksi";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 48);
            this.button5.TabIndex = 19;
            this.button5.Text = "Master Penjualan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(559, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 48);
            this.button6.TabIndex = 20;
            this.button6.Text = "Data Penjualan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.Name = "id_barang";
            // 
            // nb
            // 
            this.nb.DataPropertyName = "nama_barang";
            this.nb.HeaderText = "Nama Barang";
            this.nb.Name = "nb";
            // 
            // hb
            // 
            this.hb.DataPropertyName = "harga_beli";
            this.hb.HeaderText = "Harga Beli";
            this.hb.Name = "hb";
            // 
            // hj
            // 
            this.hj.DataPropertyName = "harga_jual";
            this.hj.HeaderText = "Harga Jual";
            this.hj.Name = "hj";
            // 
            // s
            // 
            this.s.DataPropertyName = "stok";
            this.s.HeaderText = "Stok";
            this.s.Name = "s";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 530);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.thj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnb);
            this.Controls.Add(this.thb);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView barang;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox thb;
        private System.Windows.Forms.TextBox tnb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ts;
        private System.Windows.Forms.TextBox thj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn hb;
        private System.Windows.Forms.DataGridViewTextBoxColumn hj;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
    }
}