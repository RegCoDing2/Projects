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
    public partial class frmApartments : Form
    {
        private //Private variable is declared
            string block;

        //Instance variables of certain classes are declared
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adap;
        SqlCommand comm;
        SqlDataReader reader;


        public frmApartments()
        {
            InitializeComponent();
        }

        //This method will add apartment details to the database
        public void addApartment(string apartNum)
        {
            string sqlSearch = "";

            //Add Apartment
            try
            {
                conn.Open();

                comm = new SqlCommand($"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num = '{apartNum}'", conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    sqlSearch = reader.GetString(0);
                }

                conn.Close();

                if (apartNum == sqlSearch)
                {
                    MessageBox.Show("Apartment already exists. Please pick another Apartment Number.");

                }
                else
                {
                    conn.Open();

                    comm = new SqlCommand($"INSERT INTO Apartment(Apartment_Num) VALUES('{apartNum}')", conn);

                    adap = new SqlDataAdapter();

                    adap.InsertCommand = comm;
                    adap.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Apartment successfully added.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Method will remove an aprtment from the database
        public void deleteApartment(string apartNum)
        {
            int sqlSearch = 0;
            bool flag = false;

            //Delete Apartment
            try
            {
                conn.Open();    //Retrieves the Apartment ID where the Apartment is chosen

                comm = new SqlCommand($"SELECT Contract_ID FROM Apartment WHERE Apartment_Num = '{apartNum}'", conn);

                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    try
                    {
                        sqlSearch = reader.GetInt32(0);
                    }
                    catch
                    {
                        flag = true; //Value is = to NULL
                    }
                    
                }

                conn.Close();

                if(flag == false)
                {
                    MessageBox.Show("Cannot remove apartment, because apartment has a tenant");
                }
                else
                {
                    conn.Open();        //Deletes the record where the apartment number is selcted and the apartment has no tenant present

                    comm = new SqlCommand($"DELETE FROM  Apartment WHERE  Apartment_Num = '{apartNum}'", conn);

                    SqlDataAdapter adap = new SqlDataAdapter();

                    adap.DeleteCommand = comm;
                    adap.DeleteCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Apartment successfully Deleted.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //This method will comboxes
        public void fillComboBox(string sql)
        {
            cmbApartNumDel.Items.Clear();

            conn.Open();

            comm = new SqlCommand(sql, conn);

            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                cmbApartNumDel.Items.Add(reader.GetValue(0));//0 specifiy table colomb
            }

            conn.Close();
        }

        //This button closes the current form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApartments_Load(object sender, EventArgs e)
        {

        }

        //Assigns the block value to the 'block' variable
        private void rbBlockA_CheckedChanged(object sender, EventArgs e)
        {
            block = "A";
        }

        private void btnAddApart_Click(object sender, EventArgs e)
        {
            cmbApartNum.Items.Clear();

            int maxNum = 0, temp = 0;
            string currentNum = "";

            try
            {
                conn.Open();    //To find the last apartment number

                comm = new SqlCommand($"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE '{block}%'", conn);

                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    currentNum = reader.GetString(0);

                    currentNum = currentNum.Remove(0, 1);

                    temp = int.Parse(currentNum);

                    if(temp > maxNum)
                    {
                        maxNum = temp;
                    }
                }

                conn.Close();

                cmbApartNum.Items.Add(block + (maxNum + 1).ToString());
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            cmbApartNum.Visible = true; 
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            cmbApartNumDel.Visible = false;
        }

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }

        //This button is used to fill a combobox and make certain controls visible
        private void btnDelApart_Click(object sender, EventArgs e)
        {
            cmbApartNumDel.Items.Clear();

            if(block == "A")
            {
                fillComboBox($"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'A%'");
            }
            else
            {
                fillComboBox($"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'B%'");
            }

            btnAddApart.Visible = true;
            btnDelApart.Visible = true;

            btnAddApart.Visible = true;
            btnDelApart.Visible = true;

            btnDelete.Visible = true;//Makes Comboboxes and buttons visible
            cmbApartNumDel.Visible = true;
            cmbApartNum.Visible = false;
            btnAdd.Visible = false;
        }

        //This button is used add apartment details to the databse through the method 'addApartment'
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbApartNum.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Apartment to be deleted");
                cmbApartNum.Focus();
            }
            else
            {
                string apartment = cmbApartNum.SelectedItem.ToString();

                addApartment(apartment);

                cmbApartNum.Visible = false;
                btnAdd.Visible = false;
            } 
        }

        //This button is used delete apartment details to the databse through the method 'deleteApartment'
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbApartNumDel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Apartment to be deleted");
                cmbApartNumDel.Focus();
            }
            else
            {
                string apartment = cmbApartNumDel.SelectedItem.ToString();

                deleteApartment(apartment);

                cmbApartNumDel.Visible = false;
                btnDelete.Visible = false;
            }
        }

        //Assigns the block value to the 'block' variable
        private void rbBlockB_CheckedChanged(object sender, EventArgs e)
        {
            block = "B";
        }
    }
}
