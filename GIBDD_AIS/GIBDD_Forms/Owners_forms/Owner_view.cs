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
namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    public partial class Owner_view : Form
    {
        DataBase dataBase = new DataBase();
        public Owner_view()
        {
            InitializeComponent();
        }
        private void Owner_view_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;
            string quertystring = $"SELECT Surname, Name, Middle_name, Address, Birth_D FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(quertystring, dataBase.GetConnection());
            dataReader = sqlCommand.ExecuteReader();
            OwnerSurname_textBox.MaxLength = 30;
            OwnerMiddleName_textBox.MaxLength = 30;
            OwnerSurname_textBox.MaxLength = 30;
            Address_textBox.MaxLength = 60;
            BrirthD_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            BrirthD_dateTimePicker.Format = DateTimePickerFormat.Custom;
            while (dataReader.Read())
            {
                OwnerName_textBox.Text = dataReader[1].ToString();
                OwnerSurname_textBox.Text = dataReader[0].ToString();
                OwnerMiddleName_textBox.Text = dataReader[2].ToString();
                Address_textBox.Text = dataReader[3].ToString();
                BrirthD_dateTimePicker.Text = dataReader[4].ToString();
            }
            dataReader.Close();
            string querystring = $"SELECT Number AS 'Номер', Brand as 'Марка' FROM VEHICLES WHERE OWNERS_ID LIKE '{DataBank.Owner_ID}'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Owner_vehicles_dataGridView.DataSource = db.Tables[0];
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
