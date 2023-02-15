using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseFormsLibrary
{
    public partial class BaseAccident : Form
    {
        protected List<string> removedVehiclesID;
        protected List<string> addedVehiclesID;
        public BaseAccident()
        {
            InitializeComponent();
        }

        private bool CheckReason()
        {
            var Box = reasonTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckAmountOfDamage()
        {
            var Box = damageAmountTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            {
                errorProvider.SetError(Box, "");
                int numericValue;
                bool isNumber = int.TryParse(Box.Text, out numericValue);
                if (isNumber != false) status = true;
                else
                {
                    errorProvider.SetError(Box, "Поле может содержать только число");
                    status = false;
                }
            }
            return status;
        }
        private bool CheckRoadConditions()
        {
            var Box = roadConditionsTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckArea()
        {
            var Box = areaTextBox;
            bool status = true;

            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider.SetError(Box, "");
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
            else errorProvider.SetError(Box, "");
            return status;
        }
        private bool CheckNumOfVictims()
        {
            var Box = victimsTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            {
                errorProvider.SetError(Box, "");
                int numericValue;
                bool isNumber = int.TryParse(Box.Text, out numericValue);
                if (isNumber != false) status = true;
                else
                {
                    errorProvider.SetError(Box, "Поле может содержать только число");
                    status = false;
                }
            }
            return status;
        }
        private bool CheckDate()
        {
            var Box = dateDateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                if (Box.Value > DateTime.Today)
            {

                errorProvider.SetError(Box, "Дата то не может быть больше текущей");
                status = false;
            }
            else errorProvider.SetError(Box, "");
            return status;
        }

        protected bool checkForm()
        {
            bool Reason = CheckReason();
            bool AmountOfDamage = CheckAmountOfDamage();
            bool RoadConditions = CheckRoadConditions();
            bool Area = CheckArea();
            bool Type = CheckType();
            bool NumOfVictims = CheckNumOfVictims();
            bool Date = CheckDate();

            if (Reason && AmountOfDamage && RoadConditions && Area && Type && NumOfVictims && Date)
                return true;
            else return false;
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void currVehiclesDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        protected virtual void currVehiclesDataGridViewRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        protected virtual void currVehiclesDataGridViewRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        protected virtual void currVehiclesDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}