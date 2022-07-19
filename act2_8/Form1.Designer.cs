
namespace act2_8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.birthdayTextbox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.isrnTextbox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ERROR = new System.Windows.Forms.Label();
            this.SUCCESS = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.refreshIsrnbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(28, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(166, 38);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "First Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.ForeColor = System.Drawing.Color.White;
            this.nameTextbox.Location = new System.Drawing.Point(18, 14);
            this.nameTextbox.MaxLength = 50;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.ShortcutsEnabled = false;
            this.nameTextbox.Size = new System.Drawing.Size(173, 20);
            this.nameTextbox.TabIndex = 6;
            this.nameTextbox.Tag = "Name";
            this.nameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fisrtNameTextBox_KeyPress);
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.lastNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.ForeColor = System.Drawing.Color.White;
            this.lastNameTextbox.Location = new System.Drawing.Point(18, 15);
            this.lastNameTextbox.MaxLength = 50;
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.ShortcutsEnabled = false;
            this.lastNameTextbox.Size = new System.Drawing.Size(173, 20);
            this.lastNameTextbox.TabIndex = 7;
            this.lastNameTextbox.Tag = "Last Name";
            this.lastNameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.birthdayTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthdayTextbox.Enabled = false;
            this.birthdayTextbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.birthdayTextbox.Location = new System.Drawing.Point(9, 55);
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.ReadOnly = true;
            this.birthdayTextbox.Size = new System.Drawing.Size(192, 27);
            this.birthdayTextbox.TabIndex = 8;
            this.birthdayTextbox.Tag = "Birth Date";
            this.birthdayTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdayTextbox.TextChanged += new System.EventHandler(this.birthdayTextbox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ageTextBox.Location = new System.Drawing.Point(11, 15);
            this.ageTextBox.MaxLength = 2;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ShortcutsEnabled = false;
            this.ageTextBox.Size = new System.Drawing.Size(191, 20);
            this.ageTextBox.TabIndex = 9;
            this.ageTextBox.Tag = "Age";
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // isrnTextbox
            // 
            this.isrnTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.isrnTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isrnTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.isrnTextbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isrnTextbox.ForeColor = System.Drawing.Color.White;
            this.isrnTextbox.Location = new System.Drawing.Point(18, 15);
            this.isrnTextbox.MaxLength = 50;
            this.isrnTextbox.Name = "isrnTextbox";
            this.isrnTextbox.ReadOnly = true;
            this.isrnTextbox.ShortcutsEnabled = false;
            this.isrnTextbox.Size = new System.Drawing.Size(173, 20);
            this.isrnTextbox.TabIndex = 10;
            this.isrnTextbox.Tag = "IRSN";
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(16, 14);
            this.userTextBox.MaxLength = 50;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ShortcutsEnabled = false;
            this.userTextBox.Size = new System.Drawing.Size(184, 20);
            this.userTextBox.TabIndex = 12;
            this.userTextBox.Tag = "User";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(18, 14);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ShortcutsEnabled = false;
            this.passwordTextBox.Size = new System.Drawing.Size(173, 20);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.Tag = "Password";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(163)))), ((int)(((byte)(231)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(145, 593);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(255, 40);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Add";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(766, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 679);
            this.dataGridView1.TabIndex = 15;
            // 
            // ERROR
            // 
            this.ERROR.AutoSize = true;
            this.ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERROR.ForeColor = System.Drawing.Color.Red;
            this.ERROR.Location = new System.Drawing.Point(144, 676);
            this.ERROR.Name = "ERROR";
            this.ERROR.Size = new System.Drawing.Size(34, 13);
            this.ERROR.TabIndex = 16;
            this.ERROR.Text = "Error";
            this.ERROR.Visible = false;
            // 
            // SUCCESS
            // 
            this.SUCCESS.AutoSize = true;
            this.SUCCESS.Cursor = System.Windows.Forms.Cursors.Default;
            this.SUCCESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUCCESS.ForeColor = System.Drawing.Color.LawnGreen;
            this.SUCCESS.Location = new System.Drawing.Point(144, 648);
            this.SUCCESS.Name = "SUCCESS";
            this.SUCCESS.Size = new System.Drawing.Size(55, 13);
            this.SUCCESS.TabIndex = 17;
            this.SUCCESS.Text = "Success";
            this.SUCCESS.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(767, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.decryptButton.Location = new System.Drawing.Point(767, 40);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(211, 23);
            this.decryptButton.TabIndex = 21;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(767, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 40);
            this.button4.TabIndex = 22;
            this.button4.Text = "Salt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.generateSaltButton_Click);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.SystemColors.WindowText;
            this.calendar.Location = new System.Drawing.Point(10, 101);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 23;
            this.calendar.TitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calendar.TitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.calendar.TrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "ISRN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 38);
            this.label9.TabIndex = 28;
            this.label9.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password";
            // 
            // saltTextBox
            // 
            this.saltTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saltTextBox.Location = new System.Drawing.Point(767, 134);
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(211, 20);
            this.saltTextBox.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9.Location = new System.Drawing.Point(767, 107);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(211, 20);
            this.textBox9.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.nameTextbox);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(28, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 49);
            this.panel1.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 14);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Tag = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.lastNameTextbox);
            this.panel2.Location = new System.Drawing.Point(28, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 49);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.userTextBox);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(311, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 49);
            this.panel3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(18, 14);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Tag = "Name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(18, 14);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Tag = "Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.passwordTextBox);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(311, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 49);
            this.panel4.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(18, 15);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Tag = "Last Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.ageTextBox);
            this.panel5.Location = new System.Drawing.Point(311, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 47);
            this.panel5.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.isrnTextbox);
            this.panel6.Controls.Add(this.textBox7);
            this.panel6.Location = new System.Drawing.Point(311, 511);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 49);
            this.panel6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(18, 15);
            this.textBox7.MaxLength = 50;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(173, 20);
            this.textBox7.TabIndex = 7;
            this.textBox7.Tag = "Last Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.logoutButton);
            this.panel7.Location = new System.Drawing.Point(-10, 706);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(567, 79);
            this.panel7.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Universidad Tecnológica de la Laguna Durango";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Zahúl Guadalupe Domínguez Chávez";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(175)))), ((int)(((byte)(148)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(386, 15);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(148, 51);
            this.logoutButton.TabIndex = 34;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel8.Controls.Add(this.emailTextBox);
            this.panel8.Controls.Add(this.textBox10);
            this.panel8.Controls.Add(this.textBox11);
            this.panel8.Location = new System.Drawing.Point(311, 193);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(213, 47);
            this.panel8.TabIndex = 35;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.Location = new System.Drawing.Point(9, 14);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ShortcutsEnabled = false;
            this.emailTextBox.Size = new System.Drawing.Size(191, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.Tag = "E-Mail";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(18, 14);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(173, 20);
            this.textBox10.TabIndex = 13;
            this.textBox10.Tag = "Password";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(18, 15);
            this.textBox11.MaxLength = 50;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(173, 20);
            this.textBox11.TabIndex = 7;
            this.textBox11.Tag = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(304, 140);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(91, 38);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "Email";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel9.Controls.Add(this.calendar);
            this.panel9.Controls.Add(this.birthdayTextbox);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(28, 272);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(213, 288);
            this.panel9.TabIndex = 33;
            // 
            // refreshIsrnbtn
            // 
            this.refreshIsrnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(237)))), ((int)(((byte)(170)))));
            this.refreshIsrnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshIsrnbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshIsrnbtn.ForeColor = System.Drawing.Color.Black;
            this.refreshIsrnbtn.Location = new System.Drawing.Point(388, 478);
            this.refreshIsrnbtn.Name = "refreshIsrnbtn";
            this.refreshIsrnbtn.Size = new System.Drawing.Size(76, 27);
            this.refreshIsrnbtn.TabIndex = 36;
            this.refreshIsrnbtn.Text = "Refresh";
            this.refreshIsrnbtn.UseVisualStyleBackColor = false;
            this.refreshIsrnbtn.Click += new System.EventHandler(this.refreshIsrnbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(553, 786);
            this.Controls.Add(this.refreshIsrnbtn);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.saltTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SUCCESS);
            this.Controls.Add(this.ERROR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox birthdayTextbox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox isrnTextbox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ERROR;
        private System.Windows.Forms.Label SUCCESS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saltTextBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button refreshIsrnbtn;
    }
}

