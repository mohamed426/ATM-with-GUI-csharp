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
    public partial class Withdrawalreceipt : Form
    {
        public int balance, prev_balance , amount_entered;
        public string serial, pin;
        public Withdrawalreceipt(int b, int pb, int ae, string s, string p)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Withdrawalreceipt_FormClosing);
            balance = b;
            prev_balance = pb;
            amount_entered = ae;
            serial = s;
            pin = p;
        }

        private void Withdrawalreceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This will close the application completely
            Application.Exit();
        }

        private void save_with_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Your Trust", "THANKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Opearations opearations = new Opearations(balance, serial, pin);
            opearations.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Withdrawal is : " + amount_entered + "$\n" +
                "Your Previous Balance was: " + prev_balance + "$\n"+
                "Your Current Balance is :" + balance  + "$", "RECEIPT", MessageBoxButtons.OK);

            Opearations opearations = new Opearations(balance, serial, pin);
            opearations.Show();
            this.Hide();
        }

        private void Withdrawalreceipt_Load(object sender, EventArgs e)
        {

        }
    }
}
