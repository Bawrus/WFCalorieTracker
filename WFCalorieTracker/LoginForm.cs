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
    public partial class LoginForm : Form
    {
        // wegens moeite met implementatie wordt deze form achterwege gelaten en werkt de applicatie altijd lokaal voor dezelfde user zonder inlogfunctionaliteit
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        { 
            
            if (UNBox.Text != "" && PWBox.Text != "")
            {
                User currentUser = new User(UNBox.Text, PWBox.Text);
                this.Hide();
                MainForm MF = new MainForm();
                MF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill out both fields.");
            }

            


            //if (Database.CredentialsCorrect(UNBox.Text, PWBox.Text))
            //{
            //    this.Hide();
            //    MainForm MF = new MainForm();
            //    MF.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Login credentials incorrect");
            //}
        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            if (UNBox.Text != "" && PWBox.Text != "")
            {
                /* nog een database implementeren
                User newUser = new User(UNBox.Text, PWBox.Text);
                .CreateNewUser(newUser);
                */
            }
            else
            {
                MessageBox.Show("Please fill out both fields.");
            }


        }
    }
}