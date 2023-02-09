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

namespace GIBDD_AIS.GIBDD_Forms.Autos_forms
{
    public partial class Vehicle_view : Form
    {
        DataBase dataBase = new DataBase();
        public Vehicle_view()
        {
            InitializeComponent();
        }
        private void Vehicle_view1_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;
            string querystring = $"SELECT Date as 'Дата', Reason as 'Обстоятельства' FROM ACCIDENTS WHERE ID IN(SELECT ACCIDENTS_ID FROM HISTORYS WHERE VEHICLES_ID LIKE '{DataBank.ChosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Accidents_dataGridView.DataSource = db.Tables[0];
            Accidents_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string vehicle_querystring = $"SELECT Number,  Brand, Color, Engine_n, Chasis_n, VIN, Wanted, OWNERS_ID, TID from VEHICLES where ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(vehicle_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Brand_textBox.Text = dataReader[1].ToString();
                    Color_textBox.Text = dataReader[2].ToString();
                    Engine_n_textBox.Text = dataReader[3].ToString();
                    Chasis_n_textBox.Text = dataReader[4].ToString();
                    VIN_textBox.Text = dataReader[5].ToString();
                    if (dataReader[6].ToString() == "True")
                    { wanted_checkBox.Checked = true; }
                    else { wanted_checkBox.Checked = false; }
                    DataBank.Owner_ID = dataReader[7].ToString();
                    Number_textBox.Text = dataReader[0].ToString();
                    lastTi_textBox.Text = dataReader[8].ToString();   
                }
                dataReader.Close();
                string owner_querystring = $"SELECT Surname, Name, Middle_name, Birth_D from OWNERS where ID IN (SELECT OWNERS_ID FROM VEHICLES where ID LIKE '{DataBank.ChosenID}')";
                sqlCommand = new SqlCommand(owner_querystring,dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Owner_textBox.Text = dataReader[0].ToString() + " " + dataReader[1].ToString() + " " + dataReader[2].ToString();
                    var BirthDate = dataReader.GetDateTime(3);
                    BirthDate_textBox.Text = BirthDate.ToString("dd-MM-yyyy");
                }
                dataReader.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if(dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InfoOwner_button_Click(object sender, EventArgs e)
        {
            Owner_view newForm = new Owner_view();
            newForm.Show();
        }
    }
}
