using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIBDD_AIS.GIBDDForms.ReportsForms;
using GIBDD_AIS.GIBDDForms.ReportsForms.ReportData;
using BaseFormsLibrary;

namespace GIBDD_AIS.GIBDDForms
{
    public partial class GIBDD : Form
    {
       
        public GIBDD()
        {
            InitializeComponent();
        }
        private void vehiclesClick(object sender, EventArgs e)
        {
            Vehicle newForm = new Vehicle();
            newForm.Show();
        }
        private void accidentsButtonClick(object sender, EventArgs e)
        {
            Accident newForm = new Accident();
            newForm.Show();
        }
        private void ownersClick(object sender, EventArgs e)
        {
            Owner newForm = new Owner();
            newForm.Show();
        }
        private void GIBDDLoad(object sender, EventArgs e)
        {
            ClientSize = new Size(745, 633);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void exitButtonClick(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Close(); }
            else
            { return; }
        }

        private void changeAuthButtonClick(object sender, EventArgs e)
        {
            AuthEdit newForm = new AuthEdit();
            newForm.Show();
        }

        private void reportStolenVehiclesButtonClick(object sender, EventArgs e)
        {
            StolenVehiclesReport newForm = new StolenVehiclesReport();
            newForm.Show();
        }

        private void reportAccidentsButtonClick(object sender, EventArgs e)
        {
            AccidentsReport newForm = new AccidentsReport();
            newForm.Show();
        }

        private void reportVehiclesTIButtonClick(object sender, EventArgs e)
        {
            VehiclesTIReport newForm = new VehiclesTIReport();
            newForm.Show();
        }
    }
}
