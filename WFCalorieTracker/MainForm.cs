using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //SexComboBox.DataSource = Enum.GetValues(typeof(sexEnum));
            //ActivityComboBox.DataSource = Enum.GetValues(typeof(activityLevelEnum));
            DateLabel.Text = DateTime.Now.ToString();
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
           
        }

    }
}
