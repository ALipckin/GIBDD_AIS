using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDD_Forms
{
    public partial class GIBDD : Form
    {
        public GIBDD()
        {
            InitializeComponent();
        }

        private void Vehicles_Click(object sender, EventArgs e)
        {
            Vehicles newForm = new Vehicles();
            newForm.Show();
        }

        private void Accidents_button_Click(object sender, EventArgs e)
        {
            Accidents newForm = new Accidents();
            newForm.Show();
        }

        private void Owners_Click(object sender, EventArgs e)
        {
            Owners newForm = new Owners();
            newForm.Show();
        }

        private void GIBDD_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
