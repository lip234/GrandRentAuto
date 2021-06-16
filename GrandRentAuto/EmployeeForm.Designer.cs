
namespace GrandRentAuto
{
    partial class EmployeeForm
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
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.province = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.comboBoxBranches = new System.Windows.Forms.ComboBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxlName = new System.Windows.Forms.TextBox();
            this.textBoxfName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.city,
            this.province,
            this.branch});
            this.listViewEmployee.FullRowSelect = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(88, 81);
            this.listViewEmployee.MultiSelect = false;
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(565, 812);
            this.listViewEmployee.TabIndex = 0;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstName.Width = 120;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastName.Width = 120;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // province
            // 
            this.province.Text = "Province";
            this.province.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.province.Width = 100;
            // 
            // branch
            // 
            this.branch.Text = "Branch";
            this.branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.branch.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 950);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 950);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxEID);
            this.panel1.Controls.Add(this.checkBoxEdit);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonDiscard);
            this.panel1.Controls.Add(this.comboBoxBranches);
            this.panel1.Controls.Add(this.textBoxProvince);
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Controls.Add(this.textBoxlName);
            this.panel1.Controls.Add(this.textBoxfName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(736, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 540);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(208, 394);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 38);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(51, 394);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(115, 38);
            this.buttonDiscard.TabIndex = 10;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxBranches
            // 
            this.comboBoxBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranches.FormattingEnabled = true;
            this.comboBoxBranches.Items.AddRange(new object[] {
            "Edmonton",
            "Calgary"});
            this.comboBoxBranches.Location = new System.Drawing.Point(166, 269);
            this.comboBoxBranches.Name = "comboBoxBranches";
            this.comboBoxBranches.Size = new System.Drawing.Size(166, 28);
            this.comboBoxBranches.TabIndex = 9;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(166, 210);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(166, 26);
            this.textBoxProvince.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(166, 157);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(166, 26);
            this.textBoxCity.TabIndex = 7;
            // 
            // textBoxlName
            // 
            this.textBoxlName.Location = new System.Drawing.Point(166, 100);
            this.textBoxlName.Name = "textBoxlName";
            this.textBoxlName.Size = new System.Drawing.Size(166, 26);
            this.textBoxlName.TabIndex = 6;
            // 
            // textBoxfName
            // 
            this.textBoxfName.Location = new System.Drawing.Point(166, 35);
            this.textBoxfName.Name = "textBoxfName";
            this.textBoxfName.Size = new System.Drawing.Size(166, 26);
            this.textBoxfName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branch";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Province";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Location = new System.Drawing.Point(51, 471);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(63, 24);
            this.checkBoxEdit.TabIndex = 12;
            this.checkBoxEdit.Text = "Edit";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.Visible = false;
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(189, 471);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(100, 26);
            this.textBoxEID.TabIndex = 13;
            this.textBoxEID.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(285, 950);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 44);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 1127);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewEmployee);
            this.Name = "EmployeeForm";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader province;
        private System.Windows.Forms.ColumnHeader branch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.ComboBox comboBoxBranches;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxlName;
        private System.Windows.Forms.TextBox textBoxfName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.Button buttonEdit;
    }
}