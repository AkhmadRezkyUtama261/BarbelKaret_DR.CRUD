namespace CRUDMahasiswaADO
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dtpTanggalMasuk
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(284, 76);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalMasuk.TabIndex = 1;

            // cmbProdi
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Location = new System.Drawing.Point(72, 78);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(121, 24);
            this.cmbProdi.TabIndex = 2;

            // btnCetak
            this.btnCetak.Location = new System.Drawing.Point(678, 415);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 3;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(570, 75);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 301);
            this.dataGridView1.TabIndex = 5;

            // textBox2
            this.textBox2.Location = new System.Drawing.Point(310, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Rekap data Mahasiswa";

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Name = "Form2";
            this.Text = "Rekap Mahasiswa";
            // ✅ Event Load terdaftar di sini
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
    }
}