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
using System.ComponentModel.DataAnnotations;

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
            if (checkForm())
            {
                dataBase.openConnection();
                SqlCommand sqlCommand = null;
                var Brand = Brand_TextBox.Text;
                var VIN = VIN_TextBox.Text;
                var Type = Type_ComboBox.Text;
                var Release_D = ReleaseD_DateTimePicker.Text;
                Release_D.Reverse();

                var EngineV = EngineV_TextBox.Text;
                var Engine_n = Engine_n_TextBox.Text;
                var Chasis_n = Chasis_n_TextBox.Text;
                var Body_n = Body_n_TextBox.Text;
                var Color = Color_TextBox.Text;
                var Number = Number_TextBox.Text;
                var TI = LastTIDate_TimePicker.Text;
                TI.Reverse();
                
                string owner = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string querystring = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);
                string Owner_ID = db.Tables[0].Rows[0][0].ToString();
                string create_vehicle = $"INSERT INTO VEHICLES(Number, VIN, Type, Release_D, Engine_volume, Brand, Engine_n, Chasis_n, Body_n, Color, Wanted, OWNERS_ID, TID) values('{Number}','{VIN}','{Type}','{Release_D}','{EngineV}','{Brand}','{Engine_n}','{Chasis_n}','{Body_n}','{Color}', '{wanted_checkBox.Checked}','{Owner_ID}', '{TI}')";
                sqlCommand = new SqlCommand(create_vehicle, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Авто созданно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else
                MessageBox.Show("Ошибка ввода", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }  
        private void Vehicle_input_Load(object sender, EventArgs e)
        {
            int MaxLength = 30;

            Brand_TextBox.MaxLength = MaxLength;
            VIN_TextBox.MaxLength = 17;
            Body_n_TextBox.MaxLength = MaxLength;
            EngineV_TextBox.MaxLength = MaxLength;
            Engine_n_TextBox.MaxLength = MaxLength;
            Chasis_n_TextBox.MaxLength = MaxLength;
            Color_TextBox.MaxLength = MaxLength;
            Number_TextBox.MaxLength = 9;
            SqlDataReader dataReader = null;
            LastTIDate_TimePicker.CustomFormat = "dd-MM-yyyy";
            LastTIDate_TimePicker.Format = DateTimePickerFormat.Custom;
            ReleaseD_DateTimePicker.CustomFormat = "dd-MM-yyyy";
            ReleaseD_DateTimePicker.Format = DateTimePickerFormat.Custom;

            string[] Types = { "Легковой", "Грузовой", "Грузопасажирский", "Автобус", "Спецтранспорт" };
            Type_ComboBox.Items.AddRange(Types);
            Type_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string querystring = "SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Owners_dataGridView.DataSource = db.Tables[0];
        }
        private void Vehicle_input_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vehicles newForm = new Vehicles();
            newForm.Show();
        }
        private void SearchName_TextBox_TextChanged(object sender, EventArgs e)
        {
            (Owners_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{SearchName_TextBox.Text}%'";
        }
        private bool CheckBrand()
        {
            var textBox = Brand_TextBox;
            bool status = true;
            if (textBox.Text == "")
            {
                errorProvider1.SetError(textBox, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(textBox, "");

            return status;
        }
        private bool CheckVIN()
        {
            var textBox = VIN_TextBox;
            bool status = true;
            if (textBox.Text == "")
            {
                errorProvider1.SetError(textBox, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(textBox, "");
            return status;
        }
        private bool CheckType()
        {
            var Box = Type_ComboBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckEngineV()
        {
            var Box = EngineV_TextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckReleaseD()
        {
            var Box = ReleaseD_DateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            if (Box.Value > DateTime.Today)
            {
                errorProvider1.SetError(Box, "Дата выпуска не может быть больше текущей");
                status = false;
            }
            else
            if (Box.Value > LastTIDate_TimePicker.Value)
            {
                errorProvider1.SetError(Box, "Дата выпуска не может быть больше даты то");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckEngine_n()
        {
            var Box = Engine_n_TextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }

        private bool CheckChasis_n()
        {
            var Box = Chasis_n_TextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckBody_n()
        {
            var Box = Body_n_TextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckColor()
        {
            var Box = Color_TextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");

            return status;
        }
        private bool CheckNumber()
        {
            var Box = Number_TextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckLastTIDate()
        {
            var Box = LastTIDate_TimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
             if (Box.Value > DateTime.Today)
            {

                errorProvider1.SetError(Box, "Дата то не может быть больше текущей");
                status = false;
            }
            else
                if (Box.Value < ReleaseD_DateTimePicker.Value)
            {
                errorProvider1.SetError(Box, "Дата то не может быть меньше даты выпуска");
                status = false;
            }
            else errorProvider1.SetError(Box, "");

            return status;
        }
        public bool checkForm()
        {
            bool Brand = CheckBrand();
            bool VIN = CheckVIN();
            bool Type = CheckType();
            bool EngineV = CheckEngineV();
            bool ReleaseD = CheckReleaseD();
            bool Engine_n = CheckEngine_n();
            bool Chasis_n = CheckChasis_n();
            bool Body_n = CheckBody_n();
            bool Color_n = CheckColor();
            bool Number = CheckNumber();
            bool TIDate = CheckLastTIDate();
            if (Brand && VIN && Type && EngineV && ReleaseD && Engine_n && Chasis_n && Body_n && Color_n && Number && TIDate)
                return true;
            else return false;
        }
    }
}
