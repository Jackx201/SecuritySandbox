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
using System.Security.Cryptography;
using System.Web;
using System.IO;

namespace act2_8
{


    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plainText;
        byte[] encryptedText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Booting Up");
        }

        private void validateText( KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Left) && !(e.KeyChar == (char)Keys.Right) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void validateNumber(KeyPressEventArgs e, object sender)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { 
                nameTextbox, 
                lastNameTextbox,
                birthdayTextbox,
                ageTextBox,
                irsnTextbox,
                userTextBox,
                passwordTextBox,
                emailTextBox
            };
            
            foreach(TextBox textBox in textBoxes)
            {
                if (!validateTextBox(textBox))
                {
                    MessageBox.Show("The field: " + textBox.Tag + " must be filled");
                    return;
                }
            }

            if (Convert.ToInt32(ageTextBox.Text) < 18)
            {
                SUCCESS.Visible = false;
                ERROR.Visible = true;
                ERROR.Text = "Only 18 year students or older can be registered";
                return;
            }


            SqlConnection conexion = new SqlConnection("server=DESKTOP-NHVI6LM ; database=SecurityB ; integrated security = true");

            try
            {
                conexion.Open(); 
                SUCCESS.Visible = true;
                SUCCESS.Text = "CONNECTION SUCCEED";
            }
            catch (SqlException sqlEx)
            {
                ERROR.Visible = true;
                ERROR.Text = "ERROR 10000 SOMETHING WENT WRONG" + sqlEx;
                conexion.Close();
                return;
            } catch (Exception ex1)
            {
                ERROR.Text = "ERROR 20000 CALL THE TECH GUY" + ex1;
                return;
            }

            string query1;
            query1 = "INSERT INTO students VALUES (@enrollmentid, @name, @last_name, @birthday, @age, @irsn, @username , @password, @salt, @email);";

            SqlCommand cmd1 = new SqlCommand(query1, conexion);
            byte[] salt = encriptar.GenerateSalt();
            string password = passwordTextBox.Text.Trim();

            var hashedPassword = encriptar.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), salt);
            string username = userTextBox.Text.Trim();

            cmd1.Parameters.Add("@enrollmentid", SqlDbType.Char);
            cmd1.Parameters.Add("@name", SqlDbType.VarChar);
            cmd1.Parameters.Add("@last_name", SqlDbType.VarChar);
            cmd1.Parameters.Add("@birthday", SqlDbType.Date);
            cmd1.Parameters.Add("@age", SqlDbType.Int);
            cmd1.Parameters.Add("@irsn", SqlDbType.VarChar);
            cmd1.Parameters.Add("@username", SqlDbType.VarChar);
            cmd1.Parameters.Add("@password", SqlDbType.VarBinary);
            cmd1.Parameters.Add("@salt", SqlDbType.VarBinary);
            cmd1.Parameters.Add("@email", SqlDbType.VarChar);

            cmd1.Parameters["@enrollmentid"].Value = "12345678";
            cmd1.Parameters["@name"].Value = nameTextbox.Text;
            cmd1.Parameters["@last_name"].Value = lastNameTextbox.Text;
            cmd1.Parameters["@birthday"].Value = birthdayTextbox.Text;
            cmd1.Parameters["@age"].Value = Convert.ToInt32(ageTextBox.Text);
            cmd1.Parameters["@irsn"].Value = irsnTextbox.Text;
            cmd1.Parameters["@username"].Value = username;
            cmd1.Parameters["@password"].Value = hashedPassword;
            cmd1.Parameters["@salt"].Value = salt;
            cmd1.Parameters["@email"].Value = emailTextBox.Text;


            try
            {
                cmd1.ExecuteNonQuery();
                SUCCESS.Visible = true;
                SUCCESS.Text = "New Student Registered Successfully!";
                ERROR.Text = "";
                ERROR.Visible = false;
                conexion.Close();
            }
            catch (Exception err)
            {
                ERROR.Visible = true;
                SUCCESS.Text = "";
                SUCCESS.Visible = false;
                MessageBox.Show(err + "");
                ERROR.Text = "Error 10001: Query Failed";
                conexion.Close();
            }
        }

        static public byte [] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                } return encryptedData;
            } catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;

            } catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }


        private bool validateTextBox(TextBox textBox)
        {
            if(textBox.Text != "")
            {
                return true;
            }
                return false;
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = calendar.SelectionRange.Start.ToShortDateString();
            birthdayTextbox.Text = date;
        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNumber(e, sender);
        }

        private void fisrtNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateText(e);
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateText(e);
        }

        private void generateSaltButton_Click(object sender, EventArgs e)
        {
            saltTextBox.Text = ByteConverter.GetString(encriptar.GenerateSalt());
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            byte[] decryptedText = Decryption(encryptedText, RSA.ExportParameters(true), false);
            textBox9.Text = ByteConverter.GetString(decryptedText);
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            plainText = ByteConverter.GetBytes(passwordTextBox.Text);
            encryptedText = Encryption(plainText, RSA.ExportParameters(false), false);
            saltTextBox.Text = ByteConverter.GetString(encryptedText);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void birthdayTextbox_TextChanged(object sender, EventArgs e)
        {
            //int year = Convert.ToInt32(birthdayTextbox.Text.Substring(6, 4));

            DateTime birthdate = Convert.ToDateTime(birthdayTextbox.Text);

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(birthdate.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            ageTextBox.Text = age.ToString();
        }
    }
}
