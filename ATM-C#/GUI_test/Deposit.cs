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
    public partial class Deposit : Form
    {
        public int balance;
        public string serial, pin;
        public Deposit(int b, string s, string p)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Deposit_FormClosing);
            balance = b;
            serial = s;
            pin = p;
        }

        private void Deposit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This will close the application completely
            Application.Exit();
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
                MessageBox.Show("Unable to open file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depb1_Click(object sender, EventArgs e)
        {
            int amount_entered = int.Parse(depositBox.Text);
            if (amount_entered > 10000)
            {
                MessageBox.Show("You Can't Deposit More Than 10000$", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                depositBox.Text = "";
            }

            else if (amount_entered <= 0 || amount_entered % 50 != 0)
            {
                MessageBox.Show("Invalid Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                depositBox.Text = "";
            }

            else
            {
                int prev_balance = balance;
                balance += amount_entered;
                MessageBox.Show("Successful Deposit", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateBalance(pin, serial, balance);

                Depositreceipt depreceipt = new Depositreceipt(balance, prev_balance, amount_entered, serial, pin);
                depreceipt.Show();
                this.Hide();
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Opearations opearations = new Opearations(balance, serial, pin);
            opearations.Show();
            this.Hide();
        }
    }
}
