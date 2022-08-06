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
using GIBDD_AIS.GIBDD_Forms.Accidents_forms;

namespace GIBDD_AIS
{
    public partial class Accidents : Form
    {
        DataBase dataBase = new DataBase();
        public Accidents()
        {
            InitializeComponent();
        }

        private void Accidents_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string querystring = "SELECT ID, Area, Date FROM ACCIDENTS";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Accidents_dataGridView.DataSource = db.Tables[0];
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            DataBank.chosenID = Accidents_dataGridView[0, Accidents_dataGridView.CurrentRow.Index].Value.ToString();
 
            Accident_view newForm = new Accident_view();
            newForm.Show();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            DataBank.chosenID = Accidents_dataGridView[0, Accidents_dataGridView.CurrentRow.Index].Value.ToString();
            this.Close();
            Accident_edit newForm = new Accident_edit();
            newForm.Show();
        }

        private void Input_Click(object sender, EventArgs e)
        {
            DataBank.chosenID = Accidents_dataGridView[0, Accidents_dataGridView.CurrentRow.Index].Value.ToString();
            this.Close();
            Accident_input newForm = new Accident_input();
            newForm.Show();
        }
    }
}
