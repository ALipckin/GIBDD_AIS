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
        DataBase dataBase = new DataBase();
        public AccidentsReport()
        {
            InitializeComponent();
        }

        private void Accidents_Report_Form_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            startDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            startDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            endDateDateTimePicker.Format = DateTimePickerFormat.Custom;

            string querystring = "SELECT * FROM Accidents";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            AccidentsCrystalReport sr = new AccidentsCrystalReport();
            sr.SetDataSource(s.Tables["table"]);
            mainCrystalReportViewer.ReportSource = sr;
            
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            string StartDate = startDateDateTimePicker.Text;
            string EndDate = endDateDateTimePicker.Text;
            StartDate.Reverse();
            EndDate.Reverse();
            string querystring = "SELECT * FROM Accidents where Date >= '" + StartDate + "' and Date <= '" + EndDate + "' ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            AccidentsCrystalReport sr = new AccidentsCrystalReport();
            sr.SetDataSource(s.Tables["table"]);
            mainCrystalReportViewer.ReportSource = sr;
        }
    }
}
