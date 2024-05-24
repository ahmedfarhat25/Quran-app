using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using WMPLib;
namespace القرأن_الكريم
{
    public partial class Signinandupform : Form
    {
        public Signinandupform()
        {
            InitializeComponent();
            accountdetailsbtn.Click += new EventHandler(accountdetailsbtn_Click);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VM7TK3G;Initial Catalog=users;Integrated Security=True;Encrypt=False");
        private void ShowPass(Guna2TextBox txtpassword)
        {
            if (txtpassword is null)
            {
                throw new ArgumentNullException(nameof(txtpassword));
            }

            if (txtpassword.UseSystemPasswordChar == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            ShowPass(passtextboxsignin);
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            ShowPass(repasswordtextboxsignup);
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            ShowPass(passwordtextboxsignup);
        }
        private void adds()
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
           
            string username = usernametextbox.Text.Trim();
            string password = passtextboxsignin.Text.Trim();

            try
            {
                conn.Open();
                string query = "SELECT * FROM USERS WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successfully");
                    ListeningForm form2 = new ListeningForm();
                    form2.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametextbox.Clear();
                    passtextboxsignin.Clear();
                    usernametextbox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void signupbtn_Click(object sender, EventArgs e)
        {

            if (panel.Dock == DockStyle.Right)
            {
                panel.Dock = DockStyle.Left;
                slidebtn.Text = " SIGN IN";

            }
            else
            {
                panel.Dock = DockStyle.Right;
                slidebtn.Text = " SIGN UP";
            }

        }

        private void signupbuuton_Click_1(object sender, EventArgs e)
        {
            string username = usernametextboxsignup.Text.Trim();
            string password = passwordtextboxsignup.Text.Trim();
            string confirmPassword = repasswordtextboxsignup.Text.Trim();

            // Log the input values for debugging
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Confirm Password: {confirmPassword}");

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();
                string checkUserQuery = "SELECT COUNT(*) FROM USERS WHERE username = @username";
                SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", username);

                int userCount = (int)checkCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO USERS (username, password) VALUES (@username, @password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    // Log the query and parameters for debugging
                    Console.WriteLine($"Insert Query: {insertQuery}");
                    Console.WriteLine($"Username Parameter: {username}");
                    Console.WriteLine($"Password Parameter: {password}");

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
           //run listening form
        }

        private void accountdetailsbtn_Click(object sender, EventArgs e)
        {
            string username = usernametextbox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username to view details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();
                string query = "SELECT username, password FROM USERS WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string userDetails = $"Username: {reader["username"]}\n" +
                                         $"Password: {reader["password"]}";

                    MessageBox.Show(userDetails, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}

