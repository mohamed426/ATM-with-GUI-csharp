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
    public partial class Withdraw : Form
    {
        public int balance; 
        public string serial, pin;
        public Withdraw(int b, string s, string p)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Withdraw_FormClosing);
            balance = b;
            serial = s;
            pin = p;
        }

        private void Withdraw_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This will close the application completely
            Application.Exit();
        }


        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Opearations opearations = new Opearations(balance, serial, pin);
            opearations.Show();
            this.Hide();
        }

        public void UpdateBalance(string pinToFind, string serialToFind, int balance)
        {
            string dataFilePath = Path.Combine(@"C:\Users\mk979\Desktop\ATM_GUI\GUI_test", "data.txt");
            string tempFilePath = Path.Combine(@"C:\Users\mk979\Desktop\ATM_GUI\GUI_test", "temp.txt");

            if (File.Exists(dataFilePath))
            {
                string[] lines = File.ReadAllLines(dataFilePath);
                using (StreamWriter writer = File.CreateText(tempFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(' ');
                        string serial = columns[1];
                        string pin = columns[2];
                        int currentBalance = int.Parse(columns[3]);

                        if (serial == serialToFind && pin == pinToFind)
                        {
                            currentBalance = balance;
                        }

                        writer.WriteLine($"{columns[0]} {serial} {pin} {currentBalance}");                        
                    }
                }

                // Replace the original file with the temporary one
                File.Delete(dataFilePath);
                File.Move(tempFilePath, dataFilePath);
                
            }
            else
            {
                MessageBox.Show("Unable to open file", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void withb1_Click(object sender, EventArgs e)
        {
            int amount_entered = int.Parse(withBox1.Text);
            
            if (amount_entered > 10000)
            {
                MessageBox.Show("You Can't Withdraw More Than 10000$", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                withBox1.Text = "";
            }

            else if (amount_entered > balance)
            {
                MessageBox.Show("Your balance is not enough", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                withBox1.Text = "";
            }

            else if(amount_entered <= 0 || amount_entered % 50 != 0)
            {
                MessageBox.Show("Invalid Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                withBox1.Text = "";
            }

            else
            {
                int prev_balance = balance;
                balance -= amount_entered;
                MessageBox.Show("Successful Withdrawal", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateBalance(pin, serial, balance);

                Withdrawalreceipt withreceipt = new Withdrawalreceipt(balance, prev_balance, amount_entered, serial, pin);
                withreceipt.Show();
                this.Hide();
            }
        }
    }
}
