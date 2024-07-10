using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_test
{
    public partial class Login : Form
    {
        public int balance;
        public string serial, pin;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This will close the application completely
            Application.Exit();
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
            t2.PasswordChar = '*';
        }
        public bool SearchPin(string pinToFind, string serialToFind)
        {
            string dataFilePath = Path.Combine(@"C:\Users\mk979\Desktop\ATM_GUI\GUI_test", "data.txt");
            if (File.Exists(dataFilePath))
            {
                string[] lines = File.ReadAllLines(dataFilePath);
                foreach (string line in lines)
                {
                    string[] columns = line.Split(' ');
                    string serial = columns[1];
                    if (serialToFind == serial)
                    {
                        string pin = columns[2];
                        if (pinToFind == pin)
                        {
                            balance = int.Parse(columns[3]);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                t1.Text = t2.Text = "";
                return false;
            }
            else
            {
                MessageBox.Show("Unable to open file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATM System\n" +
                "Team 10\n" +
                "Created by: Mohammed Khaled",
                "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text == "Dark Mode")
            { 
                this.BackColor = Color.FromArgb(60, 60, 60);
                this.button3.Text = "Light Mode";
                this.button3.BackColor = Color.White;
                this.button3.ForeColor = Color.Black;
                this.textBox3.ForeColor = this.textBox4.ForeColor = Color.White;
                this.textBox3.BackColor = this.textBox4.BackColor = Color.FromArgb(60, 60, 60);  
            }
            else if (this.button3.Text == "Light Mode")
            {
                this.BackColor = Color.White;
                this.button3.Text = "Dark Mode";
                this.button3.BackColor = Color.FromArgb(60, 60, 60);
                this.button3.ForeColor = Color.White;
                this.textBox3.ForeColor = this.textBox4.ForeColor = Color.Black;
                this.textBox3.BackColor = this.textBox4.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial = t1.Text;
            pin = t2.Text;
            if (SearchPin(t2.Text, t1.Text))
            {
                Opearations opearations = new Opearations(balance, serial, pin);
                opearations.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Data","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t1.Text = t2.Text = "";
            }
        }

        
    }
}
