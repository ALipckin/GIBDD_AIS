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

using GIBDD_AIS.GIBDD_Forms.Autos_forms;

namespace GIBDD_AIS
{
    public partial class Vehicle_edit : Form
    {
        DataBase dataBase = new DataBase();
        public Vehicle_edit()
        {
            InitializeComponent();
        }

 

        private void Vehicle_edit_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;
  
            try
            {
                string vehicle_querystring = $"SELECT Number,  Brand, Color, Engine_n, Chasis_n, VIN, OWNERS_ID from VEHICLES WHERE ID LIKE '{DataBank.chosenID}'";
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
                string owner_querystring = $"SELECT Surname, Name, Middle_name from OWNERS where ID IN (SELECT OWNERS_ID FROM VEHICLES where ID LIKE '{DataBank.chosenID}')";
                sqlCommand = new SqlCommand(owner_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Owner_textBox.Text = dataReader[0].ToString() + " " + dataReader[1].ToString() + " " + dataReader[2].ToString();
                }

                string TI_querystring = $"SELECT Date FROM TI WHERE VEHICLES_ID = '{DataBank.chosenID}'";
                sqlCommand = new SqlCommand(TI_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    var date = dataReader.GetDateTime(0);
                    lastTi_textBox.Text = date.ToString("dd-MM-yyyy");
                }
                dataReader.Close();

                string Wanted_querystring = $"SELECT Activity From WANTED where VEHICLES_ID = '{DataBank.chosenID}'";
                sqlCommand = new SqlCommand(Wanted_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader[0].ToString() == "True")
                    { wanted_checkBox.Checked = true; }
                    else { wanted_checkBox.Checked = false; }
                }
                dataReader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }

            }
        }

        private void TopLabelAuto_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_vehicle = $"DELETE FROM VEHICLES WHERE ID LIKE '{DataBank.chosenID}'";
                string delete_ti = $"DELETE FROM TI WHERE VEHICLES_ID = '{DataBank.chosenID}'";
                string delete_wanted = $"DELETE FROM WANTED WHERE VEHICLES_ID = '{DataBank.chosenID}'";
                string delete_owner = $"DELETE FROM OWNERS WHERE ID IN (SELECT OWNERS_ID FROM VEHICLES WHERE ID LIKE '{DataBank.chosenID}')";

                SqlCommand sqlCommand1 = new SqlCommand(delete_vehicle, dataBase.GetConnection());
                sqlCommand1.ExecuteNonQuery();
                SqlCommand sqlCommand2 = new SqlCommand(delete_ti, dataBase.GetConnection());
                sqlCommand2.ExecuteNonQuery();
                SqlCommand sqlCommand3 = new SqlCommand(delete_wanted, dataBase.GetConnection());
                sqlCommand3.ExecuteNonQuery();
                SqlCommand sqlCommand4 = new SqlCommand(delete_owner, dataBase.GetConnection());
                sqlCommand4.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Brand_textBox_Leave(object sender, EventArgs e)
        {
            string edit_vehicle = $"UPDATE VEHICLES SET Brand = '{Brand_textBox.Text}' WHERE ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void VIN_textBox_Leave(object sender, EventArgs e)
        {
          
            string edit_vehicle =$"UPDATE VEHICLES SET VIN = '{VIN_textBox.Text}' WHERE ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void Chasis_n_textBox_Leave(object sender, EventArgs e)
        {
           
            string edit_vehicle =$"UPDATE VEHICLES SET Chasis_n = '{Chasis_n_textBox.Text}' WHERE ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void Engine_n_textBox_Leave(object sender, EventArgs e)
        {
            string edit_vehicle = $"UPDATE VEHICLES SET Engine_n = '{Engine_n_textBox.Text}' WHERE ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
           
        }

        private void Color_textBox_Leave(object sender, EventArgs e)
        {
          
            string edit_vehicle = $"UPDATE VEHICLES SET Color = '{Color_textBox.Text}' WHERE ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
            
        }

        private void Number_textBox_Leave(object sender, EventArgs e)
        {
            string edit_vehicle = $"UPDATE VEHICLES SET Number = '{Number_textBox.Text}' WHERE ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void Owner_textBox_Leave(object sender, EventArgs e)
        {
            String Owner = Owner_textBox.Text;
            String[] subs = Owner.Split(' ');
            string query = $"UPDATE OWNERS SET Surname = '{subs[0]}', Name = '{subs[1]}', Middle_name = '{subs[2]}'where ID IN (SELECT OWNERS_ID FROM VEHICLES where ID LIKE '{DataBank.chosenID}')";
            SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }
        private void BirthDate_textBox_Leave(object sender, EventArgs e)
        {
            String BirthDate = BirthDate_textBox.Text;
            string query = $"UPDATE OWNERS SET Birth_D = '{BirthDate}' where ID IN (SELECT OWNERS_ID FROM VEHICLES where ID LIKE '{DataBank.chosenID}')";
            SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }
        private void lastTi_textBox_Leave(object sender, EventArgs e)
        {
            string date = lastTi_textBox.Text;
            date.Reverse();
            string edit_vehicle = $"UPDATE TI SET Date = '{date}' WHERE VEHICLES_ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
          
        }

        private void wanted_checkBox_Leave(object sender, EventArgs e)
        {
            string edit_vehicle = $"UPDATE WANTED SET Activity = '{wanted_checkBox.Checked}' WHERE VEHICLES_ID LIKE '{DataBank.chosenID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void Vehicle_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vehicles newForm = new Vehicles();
            newForm.Show();
        }


    }
}
