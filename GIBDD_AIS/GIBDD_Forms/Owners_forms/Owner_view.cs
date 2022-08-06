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
            string Vehicle_querystring = $"SELECT Number, Brand, Color, Engine_n, Chasis_n, OWNERS_ID from VEHICLES where OWNERS_ID LIKE '{DataBank.Owner_ID}'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Owner_vehicles_dataGridView.DataSource = db.Tables[0];

            Owner_textBox.MaxLength = 30;
            Address_textBox.MaxLength = 30;
            BirthDate_textBox.MaxLength = 10;
            try
            {
                string OwnerName_querystring = $"SELECT Surname, Name, Middle_name from OWNERS where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand  sqlCommand = new SqlCommand(OwnerName_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Owner_textBox.Text = dataReader[0].ToString() + " " + dataReader[1].ToString() + " " + dataReader[2].ToString();
                }
                dataReader.Close();
            }

            catch
            {
                MessageBox.Show("Ошибка ФИО", "Ошибка ФИО", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                string OwnerAddress_quertystring = $"SELECT Address FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(OwnerAddress_quertystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Address_textBox.Text = dataReader[0].ToString();
                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка адреса", "Ошибка адреса", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string OwnerBirthDate_quertystring = $"SELECT Birth_D FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(OwnerBirthDate_quertystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    var BirthDate = dataReader.GetDateTime(0);
                    BirthDate_textBox.Text = BirthDate.ToString("dd-MM-yyyy");

                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка даты рождения ", "Ошибка даты рождения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
