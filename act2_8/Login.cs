using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act2_8
{
    public partial class Login : Form
    {
        int y = 200;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Button btn1 = new Button();
            btn1.Size = new Size(150, 100);
            btn1.Location = new Point(500, y);
            btn1.Text = "This is a new Button created dynamically";
            this.Controls.Add(btn1);
            y += 150;
        }
    }
}
