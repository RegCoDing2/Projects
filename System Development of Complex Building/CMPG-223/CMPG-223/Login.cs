//Login Correct 10-09-2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG_223
{
    public partial class frmLogin : Form
    {
        public static int authorityLevel;       //Decleration of public variable

        string username, password;              //Decleration of private variables

        string chCeoUser = "Ceo111", chSecUser = "Sec123";
        string chCeoPass = "Ceo@0111", chSecPass = "Sec#1023";

        private void btnGuessLogin_Click(object sender, EventArgs e)
        {
            //Client has level 3 authority
            authorityLevel = 3;
            frmMainMenu main = new frmMainMenu();
            main.ShowDialog();
            this.Close();
        }

        private void pbLoginBack_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes current form
        }

        private void btnLogin_Click_1(object sender, EventArgs e)   //This button validates the input from the user and
        {                                                           //Will either grant user access to certain authority
            username = txtUsername.Text;                            //Or will show message stating the credentials were incorrect
            password = txtPassword.Text;

            if ((username == chCeoUser) || (username == chSecUser))
            {
                if (password == chCeoPass)
                {
                    authorityLevel = 1;

                    frmMainMenu main = new frmMainMenu();
                    main.ShowDialog();

                    this.Close();
                }
                else if (password == chSecPass)
                {
                    authorityLevel = 2;

                    frmMainMenu Main = new frmMainMenu();
                    Main.ShowDialog();

                    this.Close();
                }
                else
                {

                    MessageBox.Show("Please enter a password!");
                }

            }
            else
            {
                MessageBox.Show("Username incorrect!");
            }

        }


        public frmLogin()
        {
            InitializeComponent();
        }
    }
}
