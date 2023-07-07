//frmFacility Correct
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

namespace CMPG_223
{

    public partial class frmFacilityBooking : Form
    {
        private //Decleration of private variables
            int i, j;

        //Decleration of instance variables
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader reader;

        //This method will bookm the facility into the database
        public void bookFacility(string apartNum, string facilityID)
        {
            // Apartment Connection
            try
            {
                conn.Open();

                comm = new SqlCommand($"SELECT Apartment_ID FROM Apartment WHERE Apartment_Num = '{apartNum}'", conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    i = reader.GetInt32(0);
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


            // Facility Connection
            try
            {
                conn.Open();

                comm = new SqlCommand($"SELECT Facility_ID FROM Facility WHERE Facility_name = '{facilityID}'", conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    j = reader.GetInt32(0);
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Facility in Apartment
            try
            {
                conn.Open();

                comm = new SqlCommand($"INSERT INTO Facility_in_Apartment(Apartment_ID,Facility_ID) VALUES({i},{j})", conn);

                adap = new SqlDataAdapter();

                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Facility has been booked");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fill method to populate combo box
        public void fillComboBox(string sqlstr)
        {         
            try
            {
                conn.Open();

                comm = new SqlCommand(sqlstr, conn);

                reader = comm.ExecuteReader();

                //fill ComboBox combo box with filtered data
                while (reader.Read())
                {
                    cmbApartNum.Items.Add(reader.GetValue(0));//<<<<<<<<Change num
                }

                conn.Close();
            }
            catch (SqlException ex)//Sql Exception catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Radiobuttons are used to fill the combox via the 'fillComboBox' method
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbApartNum.Items.Clear();
            if (rbBlokA.Checked)
            {             
                // Filter for Blok A Apartment
                string sqlstr = $"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'A%'";
                fillComboBox(sqlstr);                    
                
            }
            else
            {              
                // Filter for Blok B Apartment
                string sqlstr = $"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'B%'";
                fillComboBox(sqlstr);                
            }
        }

        private void cmbApartNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //On the loading of this form a combobox fill be filled
        private void frmFacilityBooking_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand("SELECT Facility_name FROM Facility", conn);

                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    cbFacilities.Items.Add(reader.GetValue(0));
                }

                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        public frmFacilityBooking()
        {
            InitializeComponent();
        }

        //THis button will close the current form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This buuton will book a facility via the 'bookFacility' method
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbApartNum.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose an Apartment Number");
            }
            else if(cbFacilities.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose a facility to book");
            }
            else
            {
                bookFacility(cmbApartNum.SelectedItem.ToString(), cbFacilities.SelectedItem.ToString());   
            }

        }
    }
}
