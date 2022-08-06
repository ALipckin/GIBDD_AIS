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
    public partial class Owner_input : Form
    {
        DataBase dataBase = new DataBase();
        public Owner_input()
        {
            InitializeComponent();
        }

        private void Owner_inputcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vehicles newForm = new Vehicles();
            newForm.Show();
        }

        private void Owner_inputcs_Load(object sender, EventArgs e)
        {
            Owner_textBox.MaxLength = 30;
            Address_textBox.MaxLength = 30;
            BirthDate_textBox.MaxLength = 10;

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

          
            SqlCommand sqlCommand = null;


            var Owner = Owner_textBox.Text;
            var Address = Address_textBox.Text;
            var BirthDate = BirthDate_textBox.Text;
            BirthDate.Reverse();
            String[] subs = Owner.Split(' ');

            try
            {
                string create_owner = $"INSERT INTO OWNERS (Surname, Name, Middle_name, Address, Birth_D) values('{subs[0]}', '{subs[1]}', '{subs[2]}', '{Address}', '{BirthDate}')";
                sqlCommand = new SqlCommand(create_owner, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Владелец успешно создан", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка создания владельца", "Неправильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
