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
            _brandTextBox.MaxLength = MaxLength;
            _vinTextBox.MaxLength = 17;
            _bodyNumberTextBox.MaxLength = MaxLength;
            _engineVolumeTextBox.MaxLength = MaxLength;
            _engineNumberTextBox.MaxLength = MaxLength;
            _chasisNumberTextBox.MaxLength = MaxLength;
            _colorTextBox.MaxLength = MaxLength;
            _numberTextBox.MaxLength = 9;
    
            bool Wanted;
            SqlDataReader dataReader = null;
            _lastTIDateTimePicker.CustomFormat = "dd-MM-yyyy";
            _lastTIDateTimePicker.Format = DateTimePickerFormat.Custom;
            _releaseDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            _releaseDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Легковой", "Грузовой", "Грузопасажирский", "Автобус", "Спецтранспорт" };
            _typeComboBox.Items.AddRange(Types);
            _typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string querystring = "SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            _dataGridView.DataSource = db.Tables[0];
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
                    _numberTextBox.Text = dataReader[0].ToString();
                    _vinTextBox.Text = dataReader[1].ToString();
                    _typeComboBox.Text = dataReader[2].ToString();
                    _releaseDateDateTimePicker.Text = dataReader[3].ToString();
                    _engineVolumeTextBox.Text = dataReader[4].ToString();
                    _brandTextBox.Text = dataReader[5].ToString();
                    _engineNumberTextBox.Text = dataReader[6].ToString();
                    _chasisNumberTextBox.Text = dataReader[7].ToString();
                    _bodyNumberTextBox.Text = dataReader[8].ToString();
                    _colorTextBox.Text = dataReader[9].ToString();
                    Wanted = Convert.ToBoolean(dataReader[10].ToString());
                    if (Wanted == true)
                    { _wantedCheckBox.Checked = true; }
                    else {_wantedCheckBox.Checked = false;}
                    DataBank.Owner_ID = dataReader[11].ToString();
                    _lastTIDateTimePicker.Text = dataReader[12].ToString();
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
                string owner = _dataGridView[0, _dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string querystring = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);
                string Owner_ID = db.Tables[0].Rows[0][0].ToString();
                var Brand = _brandTextBox.Text;
                var VIN = _vinTextBox.Text;
                var Type = _typeComboBox.Text;
                var Release_D = _releaseDateDateTimePicker.Text;
                var EngineV = _engineVolumeTextBox.Text;
                var Engine_n = _engineNumberTextBox.Text;
                var Chasis_n = _chasisNumberTextBox.Text;
                var Body_n = _bodyNumberTextBox.Text;
                var Color = _colorTextBox.Text;
                var Number = _numberTextBox.Text;
                var TI = _lastTIDateTimePicker.Text;
                Release_D.Reverse();

                TI.Reverse();
                string create_vehicle = $"UPDATE VEHICLES SET Number = '{Number}', VIN = '{VIN}', Type = '{Type}', Release_D = '{Release_D}', Engine_volume = '{EngineV}', Brand = '{Brand}', Engine_n = '{Engine_n}', Chasis_n = '{Chasis_n}', Body_n = '{Body_n}', Color = '{Color}', Wanted = '{_wantedCheckBox.Checked}', OWNERS_ID = '{Owner_ID}', TID = '{TI}' WHERE ID = {DataBank.ChosenID}";
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
            (_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{_searchTextBox.Text}%'";
        }
        private bool CheckBrand()
        {
            var textBox = _brandTextBox;
            bool status = true;
            if (textBox.Text == "")
            {
                _errorProvider.SetError(textBox, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(textBox, "");
            return status;
        }
        private bool CheckVIN()
        {
            var textBox = _vinTextBox;
            bool status = true;
            if (textBox.Text == "")
            {
                _errorProvider.SetError(textBox, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(textBox, "");
            return status;
        }
        private bool CheckType()
        {
            var Box = _typeComboBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckEngineV()
        {
            var Box = _engineVolumeTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckReleaseD()
        {
            var Box = _releaseDateDateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            if (Box.Value > DateTime.Today)
            {
                _errorProvider.SetError(Box, "Дата выпуска не может быть больше текущей");
                status = false;
            }
            else
            if (Box.Value > _lastTIDateTimePicker.Value)
            {
                _errorProvider.SetError(Box, "Дата выпуска не может быть больше даты то");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");

            return status;
        }
        private bool CheckEngine_n()
        {
            var Box = _engineNumberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");
            return status;
        }

        private bool CheckChasis_n()
        {
            var Box = _chasisNumberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckBody_n()
        {
            var Box = _bodyNumberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckColor()
        {
            var Box = _colorTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");

            return status;
        }
        private bool CheckNumber()
        {
            var Box = _numberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                _errorProvider.SetError(Box, "");

            return status;
        }
        private bool CheckLastTIDate()
        {
            var Box = _lastTIDateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                _errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
             if (Box.Value > DateTime.Today)
                {

                    _errorProvider.SetError(Box, "Дата не может быть больше текущей");
                    status = false;
                }
                else
                if (Box.Value < _releaseDateDateTimePicker.Value)
                {
                    _errorProvider.SetError(Box, "Дата то не может быть меньше даты выпуска");
                    status = false;
                }
                else _errorProvider.SetError(Box, "");
            
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
    

