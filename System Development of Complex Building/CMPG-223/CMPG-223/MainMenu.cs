//Main Fixed 10-09-2022

/*Group 10 Members
 37543636 Jacques Perelaer
 34210164 Joubert Schoeman
 27356957 Etty Pontsho Selepe
 31590357 Louis Nel
 31865259 Wesley vd Nest
 38176459 Regan Williamson*/

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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        /*This entire form is used to be a hub where multiple forms can be displayed*/

private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApartments newMDIChild = new frmApartments();
            newMDIChild.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin newMDIChild = new frmLogin();
            newMDIChild.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if(frmLogin.authorityLevel == 3)//guest
            {
                msApartment.Visible = false;
                msMainFacil.Visible = false;
                msReport.Visible = false;
            }
            else if (frmLogin.authorityLevel == 2)//sec
            {
                msMainFacil.Visible = false;
                msApartment.Visible = false;
                msContract.Visible = false;
            }
            else//ceo
            {
                msContract.Visible = false;
                msBookFac.Visible = false;
            }
                
        }

        private void msContract_Click(object sender, EventArgs e)
        {
            Contract frmContract = new Contract();
            frmContract.ShowDialog();
        }

        private void msMainFacil_Click(object sender, EventArgs e)
        {
            frmFacility newMDIChild = new frmFacility();
            newMDIChild.ShowDialog();
        }

        private void msReport_Click(object sender, EventArgs e)
        {
            frmReports newMdiChild = new frmReports();
            newMdiChild.ShowDialog();
        }

        private void msBookFac_Click(object sender, EventArgs e)
        {
            frmFacilityBooking newfrmFacilityBooking = new frmFacilityBooking();
            newfrmFacilityBooking.ShowDialog();
        }

        private void msTenant_Click(object sender, EventArgs e)
        {
            
        }
    }
}
