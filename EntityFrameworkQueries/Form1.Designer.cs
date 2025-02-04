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
            btnSelectSpecificColumns = new Button();
            SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            btnSelectAllVendors.Location = new Point(115, 30);
            btnSelectAllVendors.Name = "btnSelectAllVendors";
            btnSelectAllVendors.Size = new Size(146, 23);
            btnSelectAllVendors.TabIndex = 0;
            btnSelectAllVendors.Text = "Select * FROM Vendors";
            btnSelectAllVendors.UseVisualStyleBackColor = true;
            btnSelectAllVendors.Click += btnSelectAllVendors_Click;
            // 
            // btnAllCaliVendors
            // 
            btnAllCaliVendors.Location = new Point(27, 71);
            btnAllCaliVendors.Name = "btnAllCaliVendors";
            btnAllCaliVendors.Size = new Size(311, 47);
            btnAllCaliVendors.TabIndex = 1;
            btnAllCaliVendors.Text = "SELECT * FROM Vendors Where VendorState = 'CA' \r\nORDER BY VendorName ASC";
            btnAllCaliVendors.UseVisualStyleBackColor = true;
            btnAllCaliVendors.Click += btnAllCaliVendors_Click;
            // 
            // btnSelectSpecificColumns
            // 
            btnSelectSpecificColumns.Location = new Point(44, 134);
            btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            btnSelectSpecificColumns.Size = new Size(279, 45);
            btnSelectSpecificColumns.TabIndex = 2;
            btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState\r\nFROM Vendors";
            btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            btnSelectSpecificColumns.Click += btnSelectSpecificColumns_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 214);
            Controls.Add(btnSelectSpecificColumns);
            Controls.Add(btnAllCaliVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCaliVendors;
        private Button btnSelectSpecificColumns;
    }
}
