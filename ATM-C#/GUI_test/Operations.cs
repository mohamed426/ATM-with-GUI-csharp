using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_test
{
    public partial class Opearations: Form
    {
        public int balance;
        public string serial, pin;
        public Opearations(int b, string s, string p)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Opearations_FormClosing);
            balance = b;
            serial = s;
            pin = p;
        }

        private void Opearations_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This will close the application completely
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void currentBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Balance is " + balance + "$", "BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw(balance,serial,pin);
            withdraw.Show();
            this.Hide();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(balance, serial, pin);
            deposit.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
