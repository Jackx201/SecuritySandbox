using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //lib SQL

namespace act2_8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if(isValidPassword(username, password))
            {
                notificationLabel.Text = "Welcome " + username;
                changeForm();

            } else
            {
                notificationLabel.Text = "Incorrect Username or Password";
            }
        }

        private bool isValidPassword(string username, string password)
        {
            userBE user = getUserFromDB(username);
            bool isValid = false;

            if(!string.IsNullOrEmpty(user.user))
            {
                byte[] hashedPassword = encriptar.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), user.salt);
                
                if (hashedPassword.SequenceEqual(user.pass))
                {
                    isValid = true;
                }
                    
            }

            return isValid;
        }

        private userBE getUserFromDB(string username)
        {
            userBE user = new userBE();


            using (SqlConnection connection = new SqlConnection("server=DESKTOP-NHVI6LM ; database=SecurityB ; integrated security = true"))
            {
                string saltSaved = "select username, salt, password, email from students where username = @username or email = @username";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = saltSaved;
                    command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            if (oReader.Read())
                            {
                                user.user = oReader["username"].ToString();
                                user.salt = (byte[])oReader["salt"];
                                user.pass = (byte[])oReader["password"];
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        notificationLabel.Text = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return user;
        }

        private void changeForm()
        {
            new Form1().Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
