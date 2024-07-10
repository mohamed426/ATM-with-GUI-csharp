
namespace GUI_test
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.withBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.withb1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // withBox1
            // 
            this.withBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withBox1.Location = new System.Drawing.Point(191, 165);
            this.withBox1.Multiline = true;
            this.withBox1.Name = "withBox1";
            this.withBox1.Size = new System.Drawing.Size(401, 42);
            this.withBox1.TabIndex = 0;
            this.withBox1.TextChanged += new System.EventHandler(this.withBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(191, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(272, 25);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Enter Amount To Withdraw";
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
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // withb1
            // 
            this.withb1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withb1.Image = global::GUI_test.Properties.Resources.money_withdrawal__Custom_;
            this.withb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.withb1.Location = new System.Drawing.Point(307, 244);
            this.withb1.Name = "withb1";
            this.withb1.Size = new System.Drawing.Size(156, 36);
            this.withb1.TabIndex = 17;
            this.withb1.Text = "Withdraw";
            this.withb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withb1.UseVisualStyleBackColor = true;
            this.withb1.Click += new System.EventHandler(this.withb1_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.withb1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.withBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox withBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button withb1;
        private System.Windows.Forms.Button back;
    }
}