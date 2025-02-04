namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectAllVendors = new Button();
            btnAllCaliVendors = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            btnSelectAllVendors.Location = new Point(94, 12);
            btnSelectAllVendors.Name = "btnSelectAllVendors";
            btnSelectAllVendors.Size = new Size(146, 23);
            btnSelectAllVendors.TabIndex = 0;
            btnSelectAllVendors.Text = "Select * FROM Vendors";
            btnSelectAllVendors.UseVisualStyleBackColor = true;
            btnSelectAllVendors.Click += btnSelectAllVendors_Click;
            // 
            // btnAllCaliVendors
            // 
            btnAllCaliVendors.Location = new Point(12, 41);
            btnAllCaliVendors.Name = "btnAllCaliVendors";
            btnAllCaliVendors.Size = new Size(311, 47);
            btnAllCaliVendors.TabIndex = 1;
            btnAllCaliVendors.Text = "SELECT * FROM Vendors Where VendorState = 'CA' \r\nORDER BY VendorName ASC";
            btnAllCaliVendors.UseVisualStyleBackColor = true;
            btnAllCaliVendors.Click += btnAllCaliVendors_Click;
            // 
            // button3
            // 
            button3.Location = new Point(115, 106);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 161);
            Controls.Add(button3);
            Controls.Add(btnAllCaliVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCaliVendors;
        private Button button3;
    }
}
