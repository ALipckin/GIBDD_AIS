using GIBDD_AIS.GIBDDForms.Reports;
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

namespace GIBDD_AIS.GIBDDForms.ReportsForms
{
    public partial class VehiclesTIReport : Form
    {
        private DataBase _dataBase = new DataBase();
        public VehiclesTIReport()
        {
            InitializeComponent();
        }

        private void TIAutos_Report_Form_Load(object sender, EventArgs e)
        {
            _dataBase.openConnection();

            string queryString = "SELECT * FROM VehicleTI";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, _dataBase.GetConnection());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            VehiclesTICrystalReport crystalReport = new VehiclesTICrystalReport();
            crystalReport.SetDataSource(dataSet.Tables["table"]);
            mainCrystalReportViewer.ReportSource = crystalReport;

        }
      
    }
}