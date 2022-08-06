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
using GIBDD_AIS.GIBDD_Forms.Owners_forms;
using GIBDD_AIS.GIBDD_Forms.Accidents_forms;
namespace GIBDD_AIS
{
    public partial class Owners : Form
    {
        DataBase dataBase = new DataBase();
        public Owners()
        {
            InitializeComponent();
        }

        private void Owners_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string querystring = "SELECT ID, CONCAT(Surname, ' ', Name, ' ', Middle_Name) AS FULL_NAMES FROM OWNERS";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Owners_dataGridView.DataSource = db.Tables[0];
            Owners_dataGridView.AutoResizeColumns();
            //Owners_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SearchName_TextBox_TextChanged(object sender, EventArgs e)
        {
           
            (Owners_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"FULL_NAMES LIKE '%{SearchName_TextBox.Text}%'";
        }

        private void Owners_dataGridView_SelectionChanged(object sender, EventArgs e)
        {

            dataBase.openConnection();

            string chosenID = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
            
            string querystring = $"SELECT ID, Area, Date FROM ACCIDENTS WHERE ID IN (SELECT ACCIDENTS_ID FROM HISTORYS WHERE VEHICLES_ID IN(SELECT ID FROM VEHICLES WHERE OWNERS_ID = '{chosenID}'))";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Accidents_dataGridView.DataSource = db.Tables[0];
            Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            DataBank.Owner_ID = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
            Owner_view newForm = new Owner_view();
            newForm.Show();

        }

        private void ViewAccidents_button_Click(object sender, EventArgs e)
        {
            DataBank.chosenID = Accidents_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
            Accident_view newForm = new Accident_view();
            newForm.Show();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Owners_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.closeConnection();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            DataBank.Owner_ID = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
            Owner_edit newForm = new Owner_edit();
            newForm.Show();
            this.Close();
        }

        private void inputNewOwner_button_Click(object sender, EventArgs e)
        {
            Owner_input newForm = new Owner_input();
            newForm.Show();
            this.Close();
        }
    }
}
