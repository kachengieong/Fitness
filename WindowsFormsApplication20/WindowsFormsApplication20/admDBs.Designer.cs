namespace CSC330_CSharp_Midterm
{
    partial class admDBs
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
            this.buttonOwnerDB = new System.Windows.Forms.Button();
            this.buttonEmpDB = new System.Windows.Forms.Button();
            this.buttonGuestDB = new System.Windows.Forms.Button();
            this.buttonMemDB = new System.Windows.Forms.Button();
            this.buttonEquipDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOwnerDB
            // 
            this.buttonOwnerDB.Location = new System.Drawing.Point(88, 117);
            this.buttonOwnerDB.Name = "buttonOwnerDB";
            this.buttonOwnerDB.Size = new System.Drawing.Size(122, 27);
            this.buttonOwnerDB.TabIndex = 0;
            this.buttonOwnerDB.Text = "Owner Database";
            this.buttonOwnerDB.UseVisualStyleBackColor = true;
            this.buttonOwnerDB.Click += new System.EventHandler(this.buttonOwnerDB_Click);
            // 
            // buttonEmpDB
            // 
            this.buttonEmpDB.Location = new System.Drawing.Point(88, 164);
            this.buttonEmpDB.Name = "buttonEmpDB";
            this.buttonEmpDB.Size = new System.Drawing.Size(122, 27);
            this.buttonEmpDB.TabIndex = 1;
            this.buttonEmpDB.Text = "Employee Database";
            this.buttonEmpDB.UseVisualStyleBackColor = true;
            this.buttonEmpDB.Click += new System.EventHandler(this.buttonEmpDB_Click);
            // 
            // buttonGuestDB
            // 
            this.buttonGuestDB.Location = new System.Drawing.Point(88, 211);
            this.buttonGuestDB.Name = "buttonGuestDB";
            this.buttonGuestDB.Size = new System.Drawing.Size(122, 27);
            this.buttonGuestDB.TabIndex = 2;
            this.buttonGuestDB.Text = "Guest Database";
            this.buttonGuestDB.UseVisualStyleBackColor = true;
            this.buttonGuestDB.Click += new System.EventHandler(this.buttonGuestDB_Click);
            // 
            // buttonMemDB
            // 
            this.buttonMemDB.Location = new System.Drawing.Point(88, 258);
            this.buttonMemDB.Name = "buttonMemDB";
            this.buttonMemDB.Size = new System.Drawing.Size(122, 27);
            this.buttonMemDB.TabIndex = 3;
            this.buttonMemDB.Text = "Member Database";
            this.buttonMemDB.UseVisualStyleBackColor = true;
            this.buttonMemDB.Click += new System.EventHandler(this.buttonMemDB_Click);
            // 
            // buttonEquipDB
            // 
            this.buttonEquipDB.Location = new System.Drawing.Point(88, 305);
            this.buttonEquipDB.Name = "buttonEquipDB";
            this.buttonEquipDB.Size = new System.Drawing.Size(122, 27);
            this.buttonEquipDB.TabIndex = 4;
            this.buttonEquipDB.Text = "Equipment Database";
            this.buttonEquipDB.UseVisualStyleBackColor = true;
            this.buttonEquipDB.Click += new System.EventHandler(this.buttonEquipDB_Click);
            // 
            // admDBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 371);
            this.Controls.Add(this.buttonEquipDB);
            this.Controls.Add(this.buttonMemDB);
            this.Controls.Add(this.buttonGuestDB);
            this.Controls.Add(this.buttonEmpDB);
            this.Controls.Add(this.buttonOwnerDB);
            this.Name = "admDBs";
            this.Text = "Databases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOwnerDB;
        private System.Windows.Forms.Button buttonEmpDB;
        private System.Windows.Forms.Button buttonGuestDB;
        private System.Windows.Forms.Button buttonMemDB;
        private System.Windows.Forms.Button buttonEquipDB;
    }
}