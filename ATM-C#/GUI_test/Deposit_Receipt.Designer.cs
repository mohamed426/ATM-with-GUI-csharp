
namespace GUI_test
{
    partial class Depositreceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depositreceipt));
            this.save_dep = new System.Windows.Forms.Button();
            this.print_dep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_dep
            // 
            this.save_dep.BackColor = System.Drawing.Color.LimeGreen;
            this.save_dep.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_dep.Image = global::GUI_test.Properties.Resources.sustainability__Custom_;
            this.save_dep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.save_dep.Location = new System.Drawing.Point(256, 248);
            this.save_dep.Name = "save_dep";
            this.save_dep.Size = new System.Drawing.Size(273, 93);
            this.save_dep.TabIndex = 3;
            this.save_dep.Text = "Save The Enviroment";
            this.save_dep.UseVisualStyleBackColor = false;
            this.save_dep.Click += new System.EventHandler(this.save_dep_Click);
            // 
            // print_dep
            // 
            this.print_dep.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_dep.Image = global::GUI_test.Properties.Resources.receipt__Custom_;
            this.print_dep.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.print_dep.Location = new System.Drawing.Point(256, 120);
            this.print_dep.Name = "print_dep";
            this.print_dep.Size = new System.Drawing.Size(273, 93);
            this.print_dep.TabIndex = 2;
            this.print_dep.Text = "Print Receipt";
            this.print_dep.UseVisualStyleBackColor = true;
            this.print_dep.Click += new System.EventHandler(this.print_dep_Click);
            // 
            // Depositreceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_dep);
            this.Controls.Add(this.print_dep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Depositreceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Depositreceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_dep;
        private System.Windows.Forms.Button print_dep;
    }
}