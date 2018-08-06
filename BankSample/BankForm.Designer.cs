namespace BankSample
{
    partial class BankForm
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
            this.lstBranches = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStreetNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAptNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBranches
            // 
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.ItemHeight = 25;
            this.lstBranches.Location = new System.Drawing.Point(12, 107);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(732, 379);
            this.lstBranches.TabIndex = 0;
            this.lstBranches.SelectedIndexChanged += new System.EventHandler(this.lstBranches_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branches";
            // 
            // txtStreetNum
            // 
            this.txtStreetNum.Location = new System.Drawing.Point(958, 182);
            this.txtStreetNum.Name = "txtStreetNum";
            this.txtStreetNum.Size = new System.Drawing.Size(452, 31);
            this.txtStreetNum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Street Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apartment Number:";
            // 
            // txtAptNum
            // 
            this.txtAptNum.Location = new System.Drawing.Point(958, 223);
            this.txtAptNum.Name = "txtAptNum";
            this.txtAptNum.Size = new System.Drawing.Size(452, 31);
            this.txtAptNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Street Name:";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(958, 140);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(452, 31);
            this.txtStreetName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(958, 264);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(452, 31);
            this.txtCity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Province:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(958, 305);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(452, 31);
            this.txtProvince.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Postal Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Phone Number:";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(643, 53);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(162, 25);
            this.lblBankName.TabIndex = 16;
            this.lblBankName.Text = "TD-Scotia Bank";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(755, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 45);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(914, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 45);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1082, 441);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 45);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1239, 441);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(171, 45);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open Branch";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 40);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(958, 387);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(452, 31);
            this.txtPhone.TabIndex = 14;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(958, 346);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(452, 31);
            this.txtPostalCode.TabIndex = 12;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 550);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAptNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStreetNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBranches);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TD-Scotia Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBranches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStreetNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAptNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostalCode;
    }
}

