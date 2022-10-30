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

namespace GIBDD_AIS.GIBDD_Forms.Reports_forms
{
    public partial class TIAutos_Report : Form
    {
        DataBase dataBase = new DataBase();
        public TIAutos_Report()
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

            AutoTI_CrystalReport sr = new AutoTI_CrystalReport();
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;

        }
      
    }
}