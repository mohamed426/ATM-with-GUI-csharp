
namespace GUI_test
{
    partial class Opearations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opearations));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.currentBalance = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(284, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(207, 25);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "What Do You Want?";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.Image = global::GUI_test.Properties.Resources.logout__Custom_2;
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel.Location = new System.Drawing.Point(12, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 35);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Log out";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // currentBalance
            // 
            this.currentBalance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalance.Image = global::GUI_test.Properties.Resources.dollar__Custom_;
            this.currentBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.currentBalance.Location = new System.Drawing.Point(284, 270);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(207, 40);
            this.currentBalance.TabIndex = 2;
            this.currentBalance.Text = "Balance Inquiry";
            this.currentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentBalance.UseVisualStyleBackColor = true;
            this.currentBalance.Click += new System.EventHandler(this.currentBalance_Click);
            // 
            // deposit
            // 
            this.deposit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Image = global::GUI_test.Properties.Resources.deposit__Custom_;
            this.deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deposit.Location = new System.Drawing.Point(284, 206);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(207, 40);
            this.deposit.TabIndex = 1;
            this.deposit.Text = "Deposit";
            this.deposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.Image = global::GUI_test.Properties.Resources.money_withdrawal__Custom_;
            this.withdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.withdraw.Location = new System.Drawing.Point(284, 139);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(207, 40);
            this.withdraw.TabIndex = 0;
            this.withdraw.Text = "Withdraw";
            this.withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // Opearations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.currentBalance);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Opearations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button currentBalance;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cancel;
    }
}