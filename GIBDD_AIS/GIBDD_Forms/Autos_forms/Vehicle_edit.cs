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
using GIBDD_AIS.GIBDD_Forms.Autos_forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GIBDD_AIS
{
    public partial class Vehicle_edit : Form
    {
        DataBase dataBase = new DataBase();
        public Vehicle_edit()
        {
            InitializeComponent();
        }
        public void Vehicle_edit_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            int MaxLength = 30;
            Brand_TextBox.MaxLength = MaxLength;
            VIN_TextBox.MaxLength = 17;
            Body_n_TextBox.MaxLength = MaxLength;
            EngineV_TextBox.MaxLength = MaxLength;
            Engine_n_TextBox.MaxLength = MaxLength;
            Chasis_n_TextBox.MaxLength = MaxLength;
            Color_TextBox.MaxLength = MaxLength;
            Number_TextBox.MaxLength = 9;
    
            bool Wanted;
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
            string CurrOwnerQuerystring = $"SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS where id in(SELECT OWNERS_ID FROM VEHICLES WHERE ID = '{DataBank.ChosenID}')";
            SqlCommand sqlCommand = new SqlCommand(CurrOwnerQuerystring, dataBase.GetConnection());

            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                CurrOwner_label.Text = dataReader[0].ToString();
            }
            dataReader.Close();
            try
            {
                string vehicle_querystring = $"SELECT Number, VIN, Type, Release_D, Engine_volume, Brand, Engine_n, Chasis_n, Body_n, Color, Wanted,OWNERS_ID, TID from VEHICLES WHERE ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand1 = new SqlCommand(vehicle_querystring, dataBase.GetConnection());
                dataReader = sqlCommand1.ExecuteReader();
                while (dataReader.Read())
                {
                    Number_TextBox.Text = dataReader[0].ToString();
                    VIN_TextBox.Text = dataReader[1].ToString();
                    Type_ComboBox.Text = dataReader[2].ToString();
                    ReleaseD_DateTimePicker.Text = dataReader[3].ToString();
                    EngineV_TextBox.Text = dataReader[4].ToString();
                    Brand_TextBox.Text = dataReader[5].ToString();
                    Engine_n_TextBox.Text = dataReader[6].ToString();
                    Chasis_n_TextBox.Text = dataReader[7].ToString();
                    Body_n_TextBox.Text = dataReader[8].ToString();
                    Color_TextBox.Text = dataReader[9].ToString();
                    Wanted = Convert.ToBoolean(dataReader[10].ToString());
                    if (Wanted == true)
                    { wanted_checkBox.Checked = true; }
                    else {wanted_checkBox.Checked = false;}
                    DataBank.Owner_ID = dataReader[11].ToString();
                    LastTIDate_TimePicker.Text = dataReader[12].ToString();
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
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_history = $"DELETE HISTORYS WHERE VEHICLES_ID = '{DataBank.ChosenID}'";
             
                string delete_vehicle = $"DELETE VEHICLES WHERE ID = '{DataBank.ChosenID}'";
   
                SqlCommand sqlCommand2 = new SqlCommand(delete_history, dataBase.GetConnection());
                sqlCommand2.ExecuteNonQuery();
                SqlCommand sqlCommand1 = new SqlCommand(delete_vehicle, dataBase.GetConnection());
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (checkForm() != false)
            {
                string owner = Owners_dataGridView[0, Owners_dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string querystring = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);
                string Owner_ID = db.Tables[0].Rows[0][0].ToString();
                var Brand = Brand_TextBox.Text;
                var VIN = VIN_TextBox.Text;
                var Type = Type_ComboBox.Text;
                var Release_D = ReleaseD_DateTimePicker.Text;
                var EngineV = EngineV_TextBox.Text;
                var Engine_n = Engine_n_TextBox.Text;
                var Chasis_n = Chasis_n_TextBox.Text;
                var Body_n = Body_n_TextBox.Text;
                var Color = Color_TextBox.Text;
                var Number = Number_TextBox.Text;
                var TI = LastTIDate_TimePicker.Text;
                Release_D.Reverse();

                TI.Reverse();
                string create_vehicle = $"UPDATE VEHICLES SET Number = '{Number}', VIN = '{VIN}', Type = '{Type}', Release_D = '{Release_D}', Engine_volume = '{EngineV}', Brand = '{Brand}', Engine_n = '{Engine_n}', Chasis_n = '{Chasis_n}', Body_n = '{Body_n}', Color = '{Color}', Wanted = '{wanted_checkBox.Checked}', OWNERS_ID = '{Owner_ID}', TID = '{TI}' WHERE ID = {DataBank.ChosenID}";
                SqlCommand CreateVehicle_Command = new SqlCommand(create_vehicle, dataBase.GetConnection());
                CreateVehicle_Command.ExecuteNonQuery();
                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    errorProvider1.SetError(Box, "Дата не может быть больше текущей");
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
            {
                return true;
            }
            else return false;
        }
    }
}
    

