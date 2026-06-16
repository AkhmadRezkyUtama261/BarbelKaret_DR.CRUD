using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CRUDMahasiswaADO
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();

            dtpTanggalMasuk.MinDate = new DateTime(2000, 1, 1);
            dtpTanggalMasuk.Format = DateTimePickerFormat.Custom;
            dtpTanggalMasuk.CustomFormat = "yyyy";
            dtpTanggalMasuk.ShowUpDown = true;
            dtpTanggalMasuk.MaxDate = DateTime.Now;

            cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList;
            var items = new List<KeyValuePair<string, SeriesChartType>>
            {
            new KeyValuePair<string, SeriesChartType>("Kolom", SeriesChartType.Column),
            new KeyValuePair<string, SeriesChartType>("Pie", SeriesChartType.Pie)
             };

            isInitializing = true;

            cmbTipe.DataSource = items;
            cmbTipe.DisplayMember = "Key";
            cmbTipe.ValueMember = "Value";
            cmbTipe.SelectedIndex = 0;

            isInitializing = false;
            loadDataChart();

        }

        DAL dbLogic = new DAL();
        bool isInitializing = true;
        DataTable dt;
        int button = 0;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            button = 1;
            loadDataChart();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            button = 0;
            loadDataChart();
        }

        private void btnDataMahasiswa_Click(object sender, EventArgs e)
        {
            btnDataMahasiswa frm1 = new DataMahasiswa();
            frm1.Show();
            this.Hide();
        }
    }

    
}
