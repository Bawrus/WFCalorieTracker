using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Classes;

namespace GUILayer
{
    public partial class MainForm : Form, IValidateInformation
    {
        public MainForm()
        {
            InitializeComponent();
            DateLabel.Text = DateTime.Now.ToString();
        }

        TdeeCalculator calc = new TdeeCalculator();

        public bool IsValid()
        {
            bool validInfo = false;

            if (AgeBox.Text != "" && WeightBox.Text != "" && SexComboBox.SelectedText != null && ActivityComboBox.SelectedText != null && WeeklyWeightLossBox.Text != "")
            {
                validInfo = true;
            }

            return validInfo;
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
           if (IsValid())
           {
                WeightGoal userWeightGoal = new WeightGoal(Convert.ToDouble(WeeklyWeightLossBox.Text));
                User currentUser = new User(Convert.ToInt32(AgeBox.Text), Convert.ToInt32(WeightBox.Text), Convert.ToInt32(HeightBox.Text), SexComboBox.SelectedText, ActivityComboBox.SelectedText, userWeightGoal);
                MessageBox.Show("User data updated");
                
                //output TDEE berekening in calorieën hieronder
                //CaloriesRemainingTB.Text = Convert.ToString(calc.CalculateTDEE(calc.CalculateBMR(currentUser), calc.CalculateActivityMultiplier(currentUser.getActivityLevel), currentUser));
           } 
           else
           {
                MessageBox.Show("Please fill in all fields.");
           }
        }

    }
}
