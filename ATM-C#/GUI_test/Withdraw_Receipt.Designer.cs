
namespace GUI_test
{
    partial class Withdrawalreceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrawalreceipt));
            this.save_with = new System.Windows.Forms.Button();
            this.print_with = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_with
            // 
            this.save_with.BackColor = System.Drawing.Color.LimeGreen;
            this.save_with.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_with.Image = global::GUI_test.Properties.Resources.sustainability__Custom_;
            this.save_with.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.save_with.Location = new System.Drawing.Point(261, 242);
            this.save_with.Name = "save_with";
            this.save_with.Size = new System.Drawing.Size(273, 93);
            this.save_with.TabIndex = 1;
            this.save_with.Text = "Save The Enviroment";
            this.save_with.UseVisualStyleBackColor = false;
            this.save_with.Click += new System.EventHandler(this.save_with_Click);
            // 
            // print_with
            // 
            this.print_with.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_with.Image = global::GUI_test.Properties.Resources.receipt__Custom_;
            this.print_with.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.print_with.Location = new System.Drawing.Point(261, 114);
            this.print_with.Name = "print_with";
            this.print_with.Size = new System.Drawing.Size(273, 93);
            this.print_with.TabIndex = 0;
            this.print_with.Text = "Print Receipt";
            this.print_with.UseVisualStyleBackColor = true;
            this.print_with.Click += new System.EventHandler(this.button1_Click);
            // 
            // Withdrawalreceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_with);
            this.Controls.Add(this.print_with);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Withdrawalreceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Withdrawalreceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button print_with;
        private System.Windows.Forms.Button save_with;
    }
}