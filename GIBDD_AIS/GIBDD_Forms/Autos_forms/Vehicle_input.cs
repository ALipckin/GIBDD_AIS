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
namespace GIBDD_AIS.GIBDD_Forms.Autos_forms
{
    public partial class Vehicle_input : Form
    {
        DataBase dataBase = new DataBase();

        
        public Vehicle_input()
        {
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            SqlDataReader dataReader = null;
            SqlCommand sqlCommand = null;

            var Brand = Brand_textBox.Text;
            var VIN = Body_n_textBox.Text;
            var Type = Type_comboBox.Text;
            var Release_D = ReleaseD_textBox.Text;
            Release_D.Reverse();
            var Engine_n = Engine_n_textBox.Text;
            var Body_n = Body_n_textBox.Text;
            var Chasis_n = Body_n_textBox.Text;
            var Color = Color_textBox.Text;
            var Number = Number_textBox.Text;
            var EngineV = EngineV_textBox.Text;

           
            var Owner = Owner_textBox.Text;
            var Address = Address_textBox.Text;
            var BirthDate = BirthDate_textBox.Text;
            BirthDate.Reverse();
            String[] subs = Owner.Split(' ');

            var TI = lastTi_textBox.Text;
            TI.Reverse();

           try
            {
                string create_owner = $"INSERT INTO OWNERS (Surname, Name, Middle_name, Address, Birth_D) values('{subs[0]}', '{subs[1]}', '{subs[2]}', '{Address}', '{BirthDate}')";
                sqlCommand = new SqlCommand(create_owner, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
            } 
             catch
            {
              MessageBox.Show("Ошибка создания владельца", "Неправильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
            try
            {
                string owner_query = $"SELECT ID FROM OWNERS WHERE ID = SCOPE_IDENTITY()";

                sqlCommand = new SqlCommand(owner_query, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                string owner_id;

                while (dataReader.Read())
                {
                    owner_id = dataReader[0].ToString();
                    string create_vehicle =
                    $"INSERT INTO VEHICLES(Number, VIN, Type, Release_D, Engine_volume, Brand, Engine_n, Chasis_n, Body_n, Color, OWNERS_ID) values('{Number}','{VIN}','{Type}','{Release_D}','{EngineV}','{Brand}','{Engine_n}','{Chasis_n}','{Body_n}','{Color}', '{owner_id}')";
                    sqlCommand = new SqlCommand(create_vehicle, dataBase.GetConnection());
                    sqlCommand.ExecuteNonQuery();
                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка создания авто", "Неправильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            try
            {
                string TI_query = $"SELECT ID FROM VEHICLES WHERE ID = SCOPE_IDENTITY()";

                sqlCommand = new SqlCommand(TI_query, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                string VEHICLES_ID;
                while (dataReader.Read())
                {
                    VEHICLES_ID = dataReader[0].ToString();
                    string TI_querystring = $"INSERT INTO TI (Date, VEHICLES_ID) values('{TI}', '{VEHICLES_ID}')";
                    sqlCommand = new SqlCommand(TI_querystring, dataBase.GetConnection());
                    sqlCommand.ExecuteNonQuery();
                }
                dataReader.Close();
            }
             catch
            {
                 MessageBox.Show("Ошибка последний тех. осмотр", "Введите дату в формате dd-MM-yyyy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            MessageBox.Show("Успешно создано!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection();
            this.Close();
        }  

        private void Vehicle_input_Load(object sender, EventArgs e)
        {
            int MaxLength = 30;
            Brand_textBox.MaxLength = MaxLength;
            VIN_textBox.MaxLength = 17;
         
            ReleaseD_textBox.MaxLength = 10;
            EngineV_textBox.MaxLength = MaxLength;
            Engine_n_textBox.MaxLength = MaxLength;
            Chassis_n_textBox.MaxLength = MaxLength;
            Body_n_textBox.MaxLength = MaxLength;
            
            Color_textBox.MaxLength = MaxLength;
            Number_textBox.MaxLength = 9;

            Owner_textBox.MaxLength = MaxLength; 
            Address_textBox.MaxLength = MaxLength;
            BirthDate_textBox.MaxLength = 10;

            lastTi_textBox.MaxLength = 10;

            string[] Types = { "Легковой", "Грузовой", "Грузопасажирский", "Автобус", "Спецтранспорт" };
            Type_comboBox.Items.AddRange(Types);
        }

        private void Vehicle_input_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vehicles newForm = new Vehicles();
            newForm.Show();
        }
    }
}
