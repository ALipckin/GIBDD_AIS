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
    public partial class TIAutosReport : Form
    {
        DataBase dataBase = new DataBase();
        public TIAutosReport()
        {
            InitializeComponent();
        }

        private void TIAutos_Report_Form_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            string querystring = "SELECT * FROM AutoTI";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet s = new DataSet();
            dataAdapter.Fill(s);

            AutoTICrystalReport sr = new AutoTICrystalReport();
            sr.SetDataSource(s.Tables["table"]);
            mainCrystalReportViewer.ReportSource = sr;

        }
      
    }
}