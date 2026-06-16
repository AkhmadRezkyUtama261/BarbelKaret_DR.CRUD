using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Report : Form
    {
        static string connectionString = "Data Source=EKYYY\\REZKY;Initial Catalog=DBAkademikADO;User ID=sa;Password=123456";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        ListMahasiswa listMahasiswa = new ListMahasiswa();

        string prodi { get; set; }
        DateTime tglmasuk { get; set; }

        public Report(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();

            prodi = Prodi;
            tglmasuk = TglMasuk;

            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // ✅ Samakan tipe parameter dengan Form2 (VarChar)
                cmd.Parameters.Add("@inProdi", SqlDbType.VarChar, 50).Value = prodi;
                cmd.Parameters.Add("@inTglMsuk", SqlDbType.VarChar, 4).Value = tglmasuk.Year.ToString();

                da = new SqlDataAdapter(cmd);
                dtMahasiswa = new DataTable();
                da.Fill(dtMahasiswa);

                if (dtMahasiswa.Rows.Count > 0)
                {
                    listMahasiswa.SetDataSource(dtMahasiswa);
                    crystalReportViewer1.ReportSource = listMahasiswa;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("Tidak ada data untuk ditampilkan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load report: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}