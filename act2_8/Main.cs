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
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ERROR.Visible = false;
            label8.Visible = false;
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

            SqlConnection myConnection =
                new SqlConnection(@"user id=DESKTOP-NHVI6LM\User072020;" +
                @"password=PptsQNNqnMartYNikki20101090!ssh;server=DESKTOP-NHVI6LM;" +
                //@"Trusted_Connection=yes" +
                @"database=SecurityB;" +
                @"connection timeout = 30");

            SqlConnection conexion = new SqlConnection("server=DESKTOP-NHVI6LM ; database=SecurityB ; integrated security = true");

            //Conn to DB
            try
            {
                conexion.Open(); //Opens con to DB
                ERROR.Visible = true;
                ERROR.Text = "CONNECTION SUCCEED";
            }
            catch (SqlException sqlEx)
            {
                ERROR.Visible = true;
                label8.Visible = true;
                label8.Text = "ERROR 10000 SOMETHING WENT WRONG" + sqlEx;
                conexion.Close();
                return;
            } catch (Exception ex1)
            {
                label8.Text = "ERROR 20000 CALL THE TECH GUY" + ex1;
                return;
            }


            //New Query (Test)
            string query1;
            query1 = "INSERT INTO students VALUES (@name, @last_name, @birthday, @age, @irsn, @username , @password);";

            SqlCommand cmd1 = new SqlCommand(query1, conexion);

           
            cmd1.Parameters.Add("@name", SqlDbType.VarChar);
            cmd1.Parameters.Add("@last_name", SqlDbType.VarChar);
            cmd1.Parameters.Add("@birthday", SqlDbType.Date);
            cmd1.Parameters.Add("@age", SqlDbType.Int);
            cmd1.Parameters.Add("@irsn", SqlDbType.VarChar);
            cmd1.Parameters.Add("@username", SqlDbType.VarChar);
            cmd1.Parameters.Add("@password", SqlDbType.Int);

          
            cmd1.Parameters["@name"].Value = "THOMAS";
            cmd1.Parameters["@last_name"].Value = "GIOVANI";
            cmd1.Parameters["@birthday"].Value = "01/01/2020";
            cmd1.Parameters["@age"].Value = 33;
            cmd1.Parameters["@irsn"].Value = "x123456789012";
            cmd1.Parameters["@username"].Value = "NANCYK";
            cmd1.Parameters["@password"].Value = 1234;


            try
            {
                cmd1.ExecuteNonQuery();
                ERROR.Visible = true;
                ERROR.Text = "Nuevo Alumno registrado correctamente!";
                myConnection.Close();
            }
            catch (Exception err)
            {
                ERROR.Visible = true;
                MessageBox.Show(err + "");
                ERROR.Text = "Error 10001: Query Failed";
                myConnection.Close();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
