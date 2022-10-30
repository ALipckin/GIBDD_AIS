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
            Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            string querystring = "SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Owners_dataGridView.DataSource = db.Tables[0];
        }
        private void SearchName_TextBox_TextChanged(object sender, EventArgs e)
        {
            (Owners_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{SearchName_TextBox.Text}%'";
        }
        private void Owners_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataBase.openConnection();
            try
            {
                string owner = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');

                string querystring = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);

                DataBank.Owner_ID = db.Tables[0].Rows[0][0].ToString();
                DataBank.chosenID = db.Tables[0].Rows[0][0].ToString();

                string querystring1 = $"SELECT Area AS 'Место' , Date AS 'Дата' FROM ACCIDENTS WHERE ID IN (SELECT ACCIDENTS_ID FROM HISTORYS WHERE VEHICLES_ID IN(SELECT ID FROM VEHICLES WHERE OWNERS_ID = '{DataBank.chosenID}'))";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring1, dataBase.GetConnection());
                DataSet db1 = new DataSet();
                dataAdapter.Fill(db1);
                Accidents_dataGridView.DataSource = db1.Tables[0];
                Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { };
        }

        private void View_button_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
            Owners_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                Owner_view newForm = new Owner_view();
                newForm.Show();

            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void ViewAccidents_button_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
            Accidents_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string owner = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string querystring = $"SELECT ID FROM ACCIDENTS WHERE Area = '{Accidents_dataGridView[0, Accidents_dataGridView.CurrentRow.Index].Value.ToString()}' AND Date = '{Accidents_dataGridView.CurrentRow.Cells[1].Value.ToString()}'";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);
                DataBank.chosenID = db.Tables[0].Rows[0][0].ToString();
                Accident_view newForm = new Accident_view();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Int32 selectedRowCount =
            Owners_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                this.Close();
                Owner_edit newForm = new Owner_edit();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void inputNewOwner_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_input newForm = new Owner_input();
            newForm.Show();
        }
        private void SearchName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
}
