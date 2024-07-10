
namespace GUI_test
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.depBox = new System.Windows.Forms.TextBox();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.depb1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depBox
            // 
            this.depBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.depBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depBox.Location = new System.Drawing.Point(197, 137);
            this.depBox.Name = "depBox";
            this.depBox.ReadOnly = true;
            this.depBox.Size = new System.Drawing.Size(272, 25);
            this.depBox.TabIndex = 19;
            this.depBox.Text = "Enter Amount To Deposit";
            // 
            // depositBox
            // 
            this.depositBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBox.Location = new System.Drawing.Point(197, 168);
            this.depositBox.Multiline = true;
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(401, 42);
            this.depositBox.TabIndex = 18;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Image = global::GUI_test.Properties.Resources.return__Custom_;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 35);
            this.back.TabIndex = 21;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // depb1
            // 
            this.depb1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depb1.Image = global::GUI_test.Properties.Resources.deposit__Custom_;
            this.depb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depb1.Location = new System.Drawing.Point(313, 247);
            this.depb1.Name = "depb1";
            this.depb1.Size = new System.Drawing.Size(156, 36);
            this.depb1.TabIndex = 20;
            this.depb1.Text = "Deposit";
            this.depb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depb1.UseVisualStyleBackColor = true;
            this.depb1.Click += new System.EventHandler(this.depb1_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.depb1);
            this.Controls.Add(this.depBox);
            this.Controls.Add(this.depositBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depb1;
        private System.Windows.Forms.TextBox depBox;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Button back;
    }
}