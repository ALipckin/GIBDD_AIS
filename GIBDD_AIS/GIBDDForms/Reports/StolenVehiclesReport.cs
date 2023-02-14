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
    public partial class StolenVehiclesReport : Form
    {
        private DataBase _dataBase = new DataBase();
        public StolenVehiclesReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            _dataBase.openConnection();

            string queryString = "SELECT * FROM VEHICLES WHERE Wanted = 1";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, _dataBase.GetConnection());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            StolenVehiclesCrustalReport newReport = new StolenVehiclesCrustalReport();
            newReport.SetDataSource(dataSet.Tables["table"]);
            mainCrystalReportViewer.ReportSource = newReport;
        }

        private void StolenAuto_ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {   
            string searchNumber = searchTextBox.Text;
            string queryString;
            if (searchNumber.Length == 0)
            {
                queryString = "SELECT * FROM VEHICLES WHERE Wanted = 1";
            }
            else
            {
                queryString = $"SELECT * FROM VEHICLES WHERE Number = '{searchNumber}' AND Wanted = 1";
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, _dataBase.GetConnection());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            StolenVehiclesCrustalReport newReport = new StolenVehiclesCrustalReport();
            newReport.SetDataSource(dataSet.Tables["table"]);
            mainCrystalReportViewer.ReportSource = newReport;
        }
    }
}
