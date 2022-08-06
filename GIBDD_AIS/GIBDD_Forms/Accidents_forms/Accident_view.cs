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

namespace GIBDD_AIS.GIBDD_Forms.Accidents_forms
{
    public partial class Accident_view : Form
    {
        DataBase dataBase = new DataBase();
        public Accident_view()
        {
            InitializeComponent();
        }

        private void Accident_view_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;
            string Vehicle_querystring = $"SELECT Number, Brand, Color from VEHICLES where ID IN (SELECT VEHICLES_ID FROM HISTORYS WHERE ACCIDENTS_ID LIKE'{DataBank.chosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            MembersOfAccident_dataGridView.DataSource = db.Tables[0];

            Reason_textBox.MaxLength = 30;
            AmountOfDamage_textBox.MaxLength = 53;
            RoadConditions_textBox.MaxLength = 30;
            Area_textBox.MaxLength = 30;
            Type_textBox.MaxLength = 30;
            Date_textBox.MaxLength = 10;
            try
            {
                string querystring = $"SELECT Reason, Amount_of_damage, Road_conditions, Area, Type, Date from ACCIDENTS where ID LIKE '{DataBank.chosenID}'";
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {

                    Reason_textBox.Text = dataReader[0].ToString();

                    AmountOfDamage_textBox.Text = dataReader[1].ToString();

                    RoadConditions_textBox.Text = dataReader[2].ToString();

                    Area_textBox.Text = dataReader[3].ToString();

                    Type_textBox.Text = dataReader[4].ToString();

                    var date = dataReader.GetDateTime(5);
                    Date_textBox.Text = date.ToString("dd-MM-yyyy");
                }
                dataReader.Close();
            }

            catch
            {
                MessageBox.Show("Ошибка", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
