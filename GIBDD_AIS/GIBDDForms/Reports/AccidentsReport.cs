using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GIBDD_AIS.GIBDDForms.Reports;

namespace GIBDD_AIS.GIBDDForms.ReportsForms.ReportData
{
    public partial class AccidentsReport : Form
    {
        DataBase _dataBase = new DataBase();
        public AccidentsReport()
        {
            InitializeComponent();
        }

        private void Accidents_Report_Form_Load(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            startDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            startDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            endDateDateTimePicker.Format = DateTimePickerFormat.Custom;

            string queryString = "SELECT * FROM Accidents";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, _dataBase.GetConnection());
            DataSet newDataSet = new DataSet();
            dataAdapter.Fill(newDataSet);
            AccidentsCrystalReport crystalReport = new AccidentsCrystalReport();
            crystalReport.SetDataSource(newDataSet.Tables["table"]);
            mainCrystalReportViewer.ReportSource = crystalReport;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            string startDate = startDateDateTimePicker.Text;
            string endDate = endDateDateTimePicker.Text;
            startDate.Reverse();
            endDate.Reverse();
            string queryString = "SELECT * FROM Accidents where Date >= '" + startDate + "' and Date <= '" + endDate + "' ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, _dataBase.GetConnection());
            DataSet newDataSet = new DataSet();
            dataAdapter.Fill(newDataSet);
            AccidentsCrystalReport newReport = new AccidentsCrystalReport();
            newReport.SetDataSource(newDataSet.Tables["table"]);
            mainCrystalReportViewer.ReportSource = newReport;
        }
    }
}
