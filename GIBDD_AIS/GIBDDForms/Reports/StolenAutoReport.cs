using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIBDD_AIS.GIBDDForms.Reports;

namespace GIBDD_AIS.GIBDDForms.ReportsForms
{
    public partial class StolenAutoReport : Form
    {
        DataBase dataBase = new DataBase();
        public StolenAutoReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            string querystring = "SELECT * FROM STOLEN_AUTOS";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            StolenAutosCrustalReport sr = new StolenAutosCrustalReport();
            sr.SetDataSource(s.Tables["table"]);
            mainCrystalReportViewer.ReportSource = sr;

        }

        private void StolenAuto_ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {   
            string SearchN = searchTextBox.Text;
            string querystring;
            if (SearchN.Length == 0)
            {
                querystring = "SELECT * FROM STOLEN_AUTOS";
            }
            else
            {
                querystring = $"SELECT * FROM STOLEN_AUTOS WHERE Number = '{SearchN}'";
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            StolenAutosCrustalReport SA = new StolenAutosCrustalReport();
            SA.SetDataSource(s.Tables["table"]);
            mainCrystalReportViewer.ReportSource = SA;

        }
    }
}
