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
    public partial class StolenAuto_Report : Form
    {
        DataBase dataBase = new DataBase();
        public StolenAuto_Report()
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

            StolenAutos_CrustalReport sr = new StolenAutos_CrustalReport();
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;

        }

        private void StolenAuto_ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {   
            string SearchN = Search_textBox.Text;
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

            StolenAutos_CrustalReport SA = new StolenAutos_CrustalReport();
            SA.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = SA;

        }
    }
}
