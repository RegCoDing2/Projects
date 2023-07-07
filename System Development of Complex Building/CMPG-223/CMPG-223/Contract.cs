using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;    
using System.Runtime.Remoting.Contexts;
using System.Net;



namespace CMPG_223
{
    public partial class Contract : Form
    {
        private     //Decleration of private variables
            string first_name, last_name, apart_num;
            string contact_num;
            DateTime sign_date;
            DateTime end_date;

        //Decleration of Sql instances

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand com;
        SqlDataAdapter adap;
        SqlDataReader reader;
        
        public Contract()
        {
            InitializeComponent();
        }

        //The following method adds contract details to the database
        public void addContract(DateTime signDate, DateTime endDate, string fName, string lName, string number, string apartment)
        {
            bool flag = false;

            try     //try-catch is used for exception handling
            {
               conn.Open();

                com = new SqlCommand("SELECT First_Name, Last_Name, Contact_Num FROM Contract", conn);

                reader = com.ExecuteReader();

                while(reader.Read() && flag == false)
                {
                    if(reader.GetString(0) == fName && reader.GetString(1) == lName && reader.GetString(2) == contact_num)
                    {
                        flag = true;
                    }
                }

                conn.Close();

                if(flag)
                {
                    MessageBox.Show("Details entered already exist");
                }
                else
                {
                    conn.Open();    //SQL used to insert into the 'Contract' Table

                    com = new SqlCommand($"INSERT INTO Contract(Sign_Date, End_Date, First_Name, Last_Name, Contact_Num) VALUES('{signDate}', '{endDate}','{fName}', '{lName}', '{number}')", conn);

                    adap = new SqlDataAdapter();

                    adap.InsertCommand = com;
                    adap.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    conn.Open();    //SQL used to selct the contract id from the 'Contract' table

                    int contractID = 0;

                    com = new SqlCommand($"SELECT Contract_ID FROM Contract WHERE Contact_Num = '{number}'", conn);

                    reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        contractID = reader.GetInt32(0);
                    }

                    conn.Close();

                    conn.Open();    //SQL used to update the contract id in the 'Apartment' Table

                    com = new SqlCommand($"Update Apartment SET Contract_ID = {contractID} WHERE Apartment_Num = '{apartment}'", conn);

                    adap = new SqlDataAdapter();

                    adap.UpdateCommand = com;
                    adap.UpdateCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Contract details have been added");

                    lstbx_ViewInfo.Items.Add("\n");
                    lstbx_ViewInfo.Items.Add("Contact number:  \t" + contact_num);
                    lstbx_ViewInfo.Items.Add("Apartment number:\t" + apart_num);
                    lstbx_ViewInfo.Items.Add("First Name:      \t" + first_name);
                    lstbx_ViewInfo.Items.Add("Last Name:       \t" + last_name);
                    lstbx_ViewInfo.Items.Add("Sign Date:       \t" + sign_date.ToShortDateString());
                    lstbx_ViewInfo.Items.Add("End Date:        \t" + end_date.ToShortDateString());
                } 
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //The following method remove sthe contract details from the database
        public void deleteContract(string fName, string lName, string number)
        {
            int cID = 0;
            bool flag = false;

            try
            {
                conn.Open();

                com = new SqlCommand("SELECT First_Name, Last_Name, Contact_Num FROM Contract", conn);

                reader = com.ExecuteReader();

                while (reader.Read() && flag == false)
                {
                    if (reader.GetString(0) == fName && reader.GetString(1) == lName && reader.GetString(2) == contact_num)
                    {
                        flag = true;
                    }
                }

                conn.Close();

                if (!flag)
                {
                    MessageBox.Show("Contract does not exist according to details eneterd");
                }
                else
                {
                    conn.Open();    //SQL used to retrieve the contract_ID

                    com = new SqlCommand($"SELECT Contract_ID FROM Contract WHERE First_Name = '{fName}' AND Last_Name = '{lName}' AND Contact_Num = '{number}'", conn);

                    reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        cID = reader.GetInt32(0);
                    }

                    conn.Close();

                    conn.Open();    //SQL used to update contract id in the 'Contract' Table to null

                    com = new SqlCommand($"UPDATE Apartment SET Contract_ID = NULL WHERE Contract_ID = '{cID}'", conn);

                    adap = new SqlDataAdapter();

                    adap.UpdateCommand = com;
                    adap.UpdateCommand.ExecuteNonQuery();

                    conn.Close();

                    conn.Open();    //SQL used to delete contract information

                    com = new SqlCommand($"DELETE FROM Contract WHERE First_Name = '{first_name}' AND Last_Name = '{last_name}' AND Contact_Num = '{contact_num}'", conn);

                    adap = new SqlDataAdapter();

                    adap.InsertCommand = com;
                    adap.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Contract has been deleted successfully");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //The following method will fill the combox
        public void fillComboBox(string sqlstr)
        {
            string apartment = "";
            int cID = 0;
            bool flag = false;

            try
            {
                conn.Open();

                com = new SqlCommand(sqlstr, conn);
                reader = com.ExecuteReader();

                //fill ComboBox combo box with filtered data
                while (reader.Read())
                {
                    flag = false;

                    try
                    {
                        cID = reader.GetInt32(0);
                    }
                    catch
                    {
                        flag = true;
                    }
                    
                    if(flag)
                    {
                        apartment = reader.GetString(1);

                        cmbAparNum.Items.Add(apartment);
                    }
                    else
                    {

                    }
                                         
                }

                conn.Close();
            }
            catch (SqlException ex)//Sql Exception catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        //The following buuton is used to implement the 'addContract' method
        private void button1_Click(object sender, EventArgs e)  
        {        
            if(txtFname.Text == "")
            {
                MessageBox.Show("Invalid syntax for First Name");
                txtFname.Focus();
            }
            else if(txtLname.Text == "")
            {
                MessageBox.Show("Invalid syntax for Last Name!");
            }
            else if(txtContNum.Text == "" || txtContNum.Text.Length < 10)
            {
                MessageBox.Show("Invalid syntax for Contact Number!");
            }
            else
            {
                first_name = txtFname.Text;
                last_name = txtLname.Text;
                contact_num = txtContNum.Text;

                apart_num = cmbAparNum.SelectedItem.ToString();

                if (rdbtn_A.Checked == false && rdbtn_B.Checked == false)
                {
                    MessageBox.Show("Please indicate block ");
                }
                else
                {
                    addContract(sign_date, end_date, first_name, last_name, contact_num, apart_num);
                }
            }
        }

        //The following button gets the dates for the contract
        private void btn_SignDate_Click(object sender, EventArgs e)
        {
             sign_date = DateTime.Today;
             end_date = sign_date.AddDays(365);

            btnSign.Visible = true;

            MessageBox.Show("To sign contract click the 'Sign' contract");
        }

        private void txtbx_lname_TextChanged(object sender, EventArgs e)
        {

        }


        //The following button is used to implement the removing of contract details from the database
        private void button2_Click(object sender, EventArgs e)
        {

            if (txtFname.Text == "")
            {
                MessageBox.Show("Invalid syntax for First Name");
                txtFname.Focus();
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("Invalid syntax for Last Name");
            }
            else if (txtContNum.Text == "" || txtContNum.Text.Length < 10)
            {
                MessageBox.Show("Invalid syntax for Contact Number");
            }
            else
            {
                first_name = txtFname.Text;
                last_name = txtLname.Text;
                contact_num = txtContNum.Text;

                deleteContract(first_name, last_name, contact_num);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        //The following radiobutton will be used to fill a combobox
        private void rdbtn_A_CheckedChanged(object sender, EventArgs e)
        {
            cmbAparNum.Items.Clear();

            string sqlstr = ($"SELECT Contract_ID, Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'A%'");
            fillComboBox(sqlstr);
        }

        //The following radiobutton will be used to fill a combobox
        private void rdbtn_B_CheckedChanged(object sender, EventArgs e)
        {
            cmbAparNum.Items.Clear();

            string sqlstr = ($"SELECT Contract_ID, Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'B%'");
            fillComboBox(sqlstr);
        }

        private void grpbx_ChooseBlock_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_EndDate_Click(object sender, EventArgs e)
        {

        }

        //On the loading of this form a certain mesaage will be displayed to the user with a choice
        private void Contract_Load(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to sign a contract? Then click 'Yes'.\nIf you wish to cancel a contract then click 'No'", "Action Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(res == DialogResult.Yes)
            {
                btnDelete.Visible = false;
            }
            else
            {
                btnDelete.Visible = true;

                GrpBx_Contract.Visible = false;
                grpbx_ChooseBlock.Visible = false;
                btnSign.Visible = false;
            }
        }


        //The following groupbox will be used to make vertain controls visible as well as display a message to the user
        private void cmbAparNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Provide the current date by clicking the 'Signed Date' button.");
            btn_SignDate.Visible = true;
            btn_SignDate.Focus();
        }

        //The following button will close the current form
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
