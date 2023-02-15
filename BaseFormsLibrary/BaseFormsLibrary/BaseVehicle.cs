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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GIBDD_AIS
{
    public partial class BaseVehicle : Form
    {
       
        public BaseVehicle()
        {
            InitializeComponent();
        }

        private bool CheckBrand()
        {
            var textBox = brandTextBox;
            bool status = true;
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(textBox, "");
            return status;
        }
        private bool CheckVIN()
        {
            var textBox = vinTextBox;
            bool status = true;
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(textBox, "");
            return status;
        }
        private bool CheckType()
        {
            var Box = typeComboBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckEngineV()
        {
            var Box = engineVolumeTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckReleaseD()
        {
            var Box = releaseDateDateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            if (Box.Value > DateTime.Today)
            {
                errorProvider.SetError(Box, "Дата выпуска не может быть больше текущей");
                status = false;
            }
            else
            if (Box.Value > lastTIDateTimePicker.Value)
            {
                errorProvider.SetError(Box, "Дата выпуска не может быть больше даты то");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");

            return status;
        }
        private bool CheckEngine_n()
        {
            var Box = engineNumberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");
            return status;
        }

        private bool CheckChasis_n()
        {
            var Box = chasisNumberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckBody_n()
        {
            var Box = bodyNumberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckColor()
        {
            var Box = colorTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");

            return status;
        }
        private bool CheckNumber()
        {
            var Box = numberTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                errorProvider.SetError(Box, "");

            return status;
        }
        private bool CheckLastTIDate()
        {
            var Box = lastTIDateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
             if (Box.Value > DateTime.Today)
                {

                    errorProvider.SetError(Box, "Дата не может быть больше текущей");
                    status = false;
                }
                else
                if (Box.Value < releaseDateDateTimePicker.Value)
                {
                    errorProvider.SetError(Box, "Дата то не может быть меньше даты выпуска");
                    status = false;
                }
                else errorProvider.SetError(Box, "");
            
            return status;
        }
        protected bool checkForm()
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

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

