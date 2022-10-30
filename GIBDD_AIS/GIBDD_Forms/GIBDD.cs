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
using GIBDD_AIS.GIBDD_Forms.Reports_forms;
using GIBDD_AIS.GIBDD_Forms.Reports_forms.Report_files;
using Microsoft.Reporting.WinForms;
namespace GIBDD_AIS.GIBDD_Forms
{
    public partial class GIBDD : Form
    {
        DataBase dataBase = new DataBase();
        public GIBDD()
        {
            InitializeComponent();
        }
        private void Vehicles_Click(object sender, EventArgs e)
        {
            Vehicles newForm = new Vehicles();
            newForm.Show();
        }
        private void Accidents_button_Click(object sender, EventArgs e)
        {
            Accidents newForm = new Accidents();
            newForm.Show();
        }
        private void Owners_Click(object sender, EventArgs e)
        {
            Owners newForm = new Owners();
            newForm.Show();
        }
        private void GIBDD_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(745, 633);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Close(); }
            else
            { return; }
        }
        private void AutoTI_button_Click(object sender, EventArgs e)
        {
            TIAutos_Report newForm = new TIAutos_Report();
            newForm.Show();
        }
        private void SolenAuto_button_Click(object sender, EventArgs e)
        {
            StolenAuto_Report newForm = new StolenAuto_Report();
            newForm.Show();
        }
        private void AccidetsrReport_button_Click(object sender, EventArgs e)
        {
            Accidents_Report newForm = new Accidents_Report();
            newForm.Show();
        }
    }
}
