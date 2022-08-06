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
    public partial class Accident_input : Form
    {
        DataBase dataBase = new DataBase();
        public Accident_input()
        {
            InitializeComponent();
        }

        private void Accident_input_Load(object sender, EventArgs e)
        {
            Reason_textBox.MaxLength = 30;
            AmountOfDamage_textBox.MaxLength = 53;
            RoadConditions_textBox.MaxLength = 30;
            Area_textBox.MaxLength = 30;
            Type_textBox.MaxLength = 30;
            Date_textBox.MaxLength = 10;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();

            Accidents newForm = new Accidents();
            newForm.Show();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            
            var date = Date_textBox.Text;
            date.Reverse();

            try
            {
                string querystring = $"INSERT INTO ACCIDENTS( Reason, Amount_of_damage, Road_conditions, Area, Type, Date) VALUES('{Reason_textBox.Text}','{AmountOfDamage_textBox.Text}','{RoadConditions_textBox.Text}','{Area_textBox.Text}','{Type_textBox.Text}','{date}')";

                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());
                sqlCommand.ExecuteReader();

                MessageBox.Show("Успешно создано!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.closeConnection();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
