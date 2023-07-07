using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //Including SQL to programming functions

namespace CMPG_223
{
    public partial class frmFacility : Form
    {

        private void addFacility(string Name)   //Method for adding a facility to the database
        {
            bool flag = false;

            try
            {
                conn.Open();    //SQL used to check if facility entered does not already exist

                com = new SqlCommand("SELECT Facility_name FROM Facility", conn);

                reader = com.ExecuteReader();

                while(reader.Read())
                {
                    if(Name == reader.GetString(0))
                    {
                        flag = true;
                    }
                }

                conn.Close();

                if(flag)
                {
                    MessageBox.Show("Facility entered already exists");
                }
                else
                {
                    conn.Open();    //SQL used to add facility to table

                    com = new SqlCommand($"INSERT INTO Facility(Facility_name) VALUES('{Name}')", conn);

                    adap = new SqlDataAdapter();

                    adap.InsertCommand = com;
                    adap.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Facility added successfully!");

                    txtAdd.Clear();
                    txtAdd.Visible = false;
                    btnAddConfirm.Visible = false;
                    lblAdd.Visible = false;
                } 
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void changeFacility(string Name)    //Method for changing a facility in the database
        {
            try
            {
                conn.Open();

                com = new SqlCommand($"UPDATE Facility SET Facility_name = '{Name}' WHERE Facility_name = '{sFacilityName}'", conn);

                adap = new SqlDataAdapter();

                adap.UpdateCommand = com;
                adap.UpdateCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Facility changed successfully!");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void deleteFacility()   //Method for removing a facility from the database
        {
            try
            {
                conn.Open();

                com = new SqlCommand($"DELETE FROM Facility WHERE Facility_name = '{sFacilityName}'", conn);

                adap = new SqlDataAdapter();

                adap.DeleteCommand = com;
                adap.DeleteCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Facility deleted successfully!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private //Decleration of field variables only to be used within this form
            string sFacilityName;

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand com;
            SqlDataAdapter adap = new SqlDataAdapter();
            SqlDataReader reader;


        public frmFacility()
        {
            InitializeComponent();
        }

        private void btnAddFacility_Click(object sender, EventArgs e)   //Button used to make other controls visible
        {
            lblAdd.Visible = true;
            txtAdd.Visible = true;
            btnAddConfirm.Visible = true;

            txtAdd.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddConfirm_Click(object sender, EventArgs e)    //Button used to add Facility to Database
        {
            string sNewFacilityName = txtAdd.Text;

            if ((int.TryParse(sNewFacilityName, out int i) == true))
            {
                txtAdd.Focus();
                MessageBox.Show("Incorrect format for Facility Name!");
            }
            else
            {
                addFacility(sNewFacilityName);
            }
        }

        private void btnChangeFacility_Click(object sender, EventArgs e)    //Button used to change Facility Deatils
        {
            lblChange.Visible = true;
            cbChange.Visible = true;

            cbChange.Items.Clear();

            try
            {
                conn.Open();

                com = new SqlCommand("SELECT Facility_name FROM Facility", conn);

                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    cbChange.Items.Add(reader.GetValue(0));
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lbChange_SelectedIndexChanged(object sender, EventArgs e)  //Button used to make other controls visible
        {
            lblNewName.Visible = true;
            txtNewName.Visible = true;

            txtNewName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)  //Button used populate combobox and make controls visble
        {
            lblDelete.Visible = true;
            cbDelete.Visible = true;
            btnConfirmRemoval.Visible = true;

            cbDelete.Items.Clear();

            try
            {
                conn.Open();

                com = new SqlCommand("SELECT Facility_name FROM Facility", conn);

                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    cbDelete.Items.Add(reader.GetValue(0));
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmRemoval_Click(object sender, EventArgs e)    //Button used to delete Facility
        {
            deleteFacility();

            cbDelete.Visible = false;
            lblDelete.Visible = false;
            btnConfirmRemoval.Visible = false;
        }

        private void lbDelete_SelectedIndexChanged(object sender, EventArgs e)  //Combobox used to assign facility chosen by user to a variable
        {
            sFacilityName = cbDelete.SelectedItem.ToString();
        }

        private void btnConfirmChange_Click(object sender, EventArgs e) //Button used to change Facility details
        {
            string sNewFacility = txtNewName.Text;

            if ((int.TryParse(sNewFacility, out int i) == true))
            {
                txtAdd.Focus();
                MessageBox.Show("Incorrect format for Facility Name!");
            }
            else
            {
                changeFacility(sNewFacility);

                txtNewName.Clear();
                txtNewName.Visible = false;
                lblNewName.Visible = false;
                cbChange.Visible = false;
                lblChange.Visible = false;
                btnConfirmChange.Visible = false;

            }
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbChange_SelectedIndexChanged(object sender, EventArgs e)  //Combobox used to make controls visible and assign values
        {
            lblNewName.Visible = true;
            txtNewName.Visible = true;
            btnConfirmChange.Visible = true;

            txtNewName.Focus();

            sFacilityName = cbChange.SelectedItem.ToString();
        }

        private void cbDelete_SelectedIndexChanged(object sender, EventArgs e)  //Combobox used to assign facility chosen
        {
            sFacilityName = cbDelete.SelectedItem.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes the facility form
        }

        private void frmFacility_Load(object sender, EventArgs e)
        {

        }
    }
}
