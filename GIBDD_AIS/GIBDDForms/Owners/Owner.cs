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
using GIBDD_AIS.GIBDDForms.Accidents;
using GIBDD_AIS.GIBDDForms.Owners;

namespace GIBDD_AIS
{
    public partial class Owner : Form
    {
        DataBase dataBase = new DataBase();
        public Owner()
        {
            InitializeComponent();
        }
        private void Owners_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            accidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            string querystring = "SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            ownersDataGridView.DataSource = db.Tables[0];
        }

        private void ownersDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            dataBase.openConnection();
            try
            {
                string owner = ownersDataGridView[0, ownersDataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');

                string querystring = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);

                DataBank.Owner_ID = db.Tables[0].Rows[0][0].ToString();
                DataBank.ChosenID = db.Tables[0].Rows[0][0].ToString();

                string querystring1 = $"SELECT Area AS 'Место' , Date AS 'Дата' FROM ACCIDENTS WHERE ID IN (SELECT ACCIDENTS_ID FROM HISTORYS WHERE VEHICLES_ID IN(SELECT ID FROM VEHICLES WHERE OWNERS_ID = '{DataBank.ChosenID}'))";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring1, dataBase.GetConnection());
                DataSet db1 = new DataSet();
                dataAdapter.Fill(db1);
                accidentsDataGridView.DataSource = db1.Tables[0];
                accidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { };
        }

        private void viewButtonClick(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
            ownersDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                OwnerView newForm = new OwnerView();
                newForm.Show();

            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void editButtonClick(object sender, EventArgs e)
        {
            int selectedRowCount =
            ownersDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                this.Close();
                OwnerEdit newForm = new OwnerEdit();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void viewAccidentsButtonClick(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
            accidentsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string owner = ownersDataGridView[0, ownersDataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string querystring = $"SELECT ID FROM ACCIDENTS WHERE Area = '{accidentsDataGridView[0, accidentsDataGridView.CurrentRow.Index].Value.ToString()}' AND Date = '{accidentsDataGridView.CurrentRow.Cells[1].Value.ToString()}'";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);
                DataBank.ChosenID = db.Tables[0].Rows[0][0].ToString();
                AccidentView newForm = new AccidentView();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void inputNewOwnerButtonClick(object sender, EventArgs e)
        {
            this.Close();
            OwnerInput newForm = new OwnerInput();
            newForm.Show();
        }
        private void searchNameTextBoxTextChanged(object sender, EventArgs e)
        {
            (ownersDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{searchNameTextBox.Text}%'";
        }
        private void searchNameTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Owners_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.closeConnection();
        }

    }
}
