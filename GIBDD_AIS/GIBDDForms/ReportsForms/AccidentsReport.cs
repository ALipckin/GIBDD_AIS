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
            StardD_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            StardD_dateTimePicker.Format = DateTimePickerFormat.Custom;
            EndD_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            EndD_dateTimePicker.Format = DateTimePickerFormat.Custom;

            string querystring = "SELECT * FROM Accidents";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            AccidentsCrystalReport sr = new AccidentsCrystalReport();
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;
            
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            string StartDate = StardD_dateTimePicker.Text;
            string EndDate = EndD_dateTimePicker.Text;
            StartDate.Reverse();
            EndDate.Reverse();
            string querystring = "SELECT * FROM Accidents where Date >= '" + StartDate + "' and Date <= '" + EndDate + "' ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            AccidentsCrystalReport sr = new AccidentsCrystalReport();
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;
        }
    }
}
