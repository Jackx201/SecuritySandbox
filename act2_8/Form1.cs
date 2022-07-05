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

        }

        private void validarTexto( KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Left) && !(e.KeyChar == (char)Keys.Right) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void validarNumero(KeyPressEventArgs e, object sender)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { 
                nameTextbox, 
                lastNameTextbox,
                birthdayTextbox,
                ageTextBox,
                irsnTextbox,
                userTextBox,
                passwordTextBox
            };
            
            foreach(TextBox textBox in textBoxes)
            {
                if (!validateTextBox(textBox))
                {
                    MessageBox.Show("The field: " + textBox.Tag + " must be filled");
                    return;
                }
            }

            SqlConnection conexion = new SqlConnection("server=DESKTOP-NHVI6LM ; database=SecurityB ; integrated security = true");

            //Conn to DB
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


            //New Query (Test)
            string query1;
            query1 = "INSERT INTO students VALUES (@enrollmentid, @name, @last_name, @birthday, @age, @irsn, @username , @password, @salt);";

            SqlCommand cmd1 = new SqlCommand(query1, conexion);
            byte[] salt = encriptar.GenerateSalt();
            string password = passwordTextBox.Text.Trim();
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

            cmd1.Parameters["@enrollmentid"].Value = "12345678";
            cmd1.Parameters["@name"].Value = nameTextbox.Text;
            cmd1.Parameters["@last_name"].Value = lastNameTextbox.Text;
            cmd1.Parameters["@birthday"].Value = birthdayTextbox.Text;
            cmd1.Parameters["@age"].Value = Convert.ToInt32(ageTextBox.Text);
            cmd1.Parameters["@irsn"].Value = irsnTextbox.Text;
            cmd1.Parameters["@username"].Value = username;
            cmd1.Parameters["@password"].Value = Encoding.UTF8.GetBytes(password);
            cmd1.Parameters["@salt"].Value = salt;


            try
            {
                cmd1.ExecuteNonQuery();
                SUCCESS.Visible = true;
                SUCCESS.Text = "New Student Registered Successfully!";
                conexion.Close();
            }
            catch (Exception err)
            {
                ERROR.Visible = true;
                MessageBox.Show(err + "");
                ERROR.Text = "Error 10001: Query Failed";
                conexion.Close();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumero(e, sender);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            plainText = ByteConverter.GetBytes(passwordTextBox.Text);
            encryptedText = Encryption(plainText, RSA.ExportParameters(false), false);
            textBox8.Text = ByteConverter.GetString(encryptedText);
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

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] decryptedText = Decryption(encryptedText, RSA.ExportParameters(true), false);
            textBox9.Text = ByteConverter.GetString(decryptedText);
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Text = ByteConverter.GetString(encriptar.GenerateSalt());
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

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*SqlConnection myConnection = new SqlConnection(@"user id=sa;" + @"password=utlaguna1.; " +
    @"server = CTEUTLD01\SEGURIDADB;" 
    @"database = securityB;" 
    + @"connection timeout=30");

SqlConnection myConnection =
    new SqlConnection(@"user id=DESKTOP-NHVI6LM\User072020;" +
    @"password=7859;server=DESKTOP-NHVI6LM;" +
    @"Trusted_Connection=yes" +
    @"database=SecurityB;" +
    @"connection timeout = 30");
*/