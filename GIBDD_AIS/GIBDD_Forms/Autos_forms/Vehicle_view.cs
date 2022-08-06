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

            string querystring = $"SELECT Date, Reason FROM ACCIDENTS WHERE ID IN(SELECT ACCIDENTS_ID FROM HISTORYS WHERE VEHICLES_ID LIKE '{DataBank.chosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Accidents_dataGridView.DataSource = db.Tables[0];

            try
            {
                string vehicle_querystring = $"SELECT Number,  Brand, Color, Engine_n, Chasis_n, VIN, OWNERS_ID from VEHICLES where ID LIKE '{DataBank.chosenID}'";
                SqlCommand sqlCommand = new SqlCommand(vehicle_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
               
                while (dataReader.Read())
                {
                   
                    Brand_textBox.Text = dataReader[1].ToString();
                    Color_textBox.Text = dataReader[2].ToString();
                    Engine_n_textBox.Text = dataReader[3].ToString();
                    Chasis_n_textBox.Text = dataReader[4].ToString();
                    VIN_textBox.Text = dataReader[5].ToString();
                    DataBank.Owner_ID = dataReader[6].ToString();
                    Number_textBox.Text = dataReader[0].ToString();
                   
             
                }
                string owner_querystring = $"SELECT Surname, Name, Middle_name, Birth_D from OWNERS where ID IN (SELECT OWNERS_ID FROM VEHICLES where ID LIKE '{DataBank.chosenID}')";
                sqlCommand = new SqlCommand(owner_querystring,dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Owner_textBox.Text = dataReader[0].ToString() + " " + dataReader[1].ToString() + " " + dataReader[2].ToString();
           
                    var BirthDate = dataReader.GetDateTime(3);
                    BirthDate_textBox.Text = BirthDate.ToString("dd-MM-yyyy");
                }
                dataReader.Close();

                string TI_querystring = $"SELECT Date FROM TI WHERE VEHICLES_ID LIKE '{DataBank.chosenID}'";
                sqlCommand = new SqlCommand(TI_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    var date = dataReader.GetDateTime(0);
                    lastTi_textBox.Text = date.ToString("dd-MM-yyyy");
                }
                dataReader.Close();

                string Wanted_querystring = $"SELECT Activity From WANTED where VEHICLES_ID LIKE '{DataBank.chosenID}'";
                sqlCommand = new SqlCommand(Wanted_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader[0].ToString() == "True")
                    { wanted_checkBox.Checked = true; }
                    else {wanted_checkBox.Checked = false; }
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
        private void Brand_textBox_TextChanged(object sender, EventArgs e)
        {

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

        private void Vehicle_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
