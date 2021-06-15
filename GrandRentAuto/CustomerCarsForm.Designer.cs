
namespace GrandRentAuto
{
    partial class CustomerCarsForm
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioMyCity = new System.Windows.Forms.RadioButton();
            this.radioCustomCity = new System.Windows.Forms.RadioButton();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickup = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.Province = new System.Windows.Forms.Label();
            this.radioProvinceAll = new System.Windows.Forms.RadioButton();
            this.radioMyProvince = new System.Windows.Forms.RadioButton();
            this.radioCustomProvince = new System.Windows.Forms.RadioButton();
            this.textProvince = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxBranches = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 270);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1084, 572);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Plate#";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Daily Rate";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weekly Rate";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Monthly Rate";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Branch";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "City";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Province";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Postal Code";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 865);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(215, 81);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(51, 24);
            this.radioAll.TabIndex = 2;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioMyCity
            // 
            this.radioMyCity.AutoSize = true;
            this.radioMyCity.Location = new System.Drawing.Point(293, 84);
            this.radioMyCity.Name = "radioMyCity";
            this.radioMyCity.Size = new System.Drawing.Size(81, 24);
            this.radioMyCity.TabIndex = 3;
            this.radioMyCity.Text = "My city";
            this.radioMyCity.UseVisualStyleBackColor = true;
            // 
            // radioCustomCity
            // 
            this.radioCustomCity.AutoSize = true;
            this.radioCustomCity.Location = new System.Drawing.Point(450, 86);
            this.radioCustomCity.Name = "radioCustomCity";
            this.radioCustomCity.Size = new System.Drawing.Size(89, 24);
            this.radioCustomCity.TabIndex = 4;
            this.radioCustomCity.Text = "Custom";
            this.radioCustomCity.UseVisualStyleBackColor = true;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(584, 83);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(172, 26);
            this.textCity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pickup Time";
            // 
            // dateTimePickup
            // 
            this.dateTimePickup.Location = new System.Drawing.Point(271, 22);
            this.dateTimePickup.Name = "dateTimePickup";
            this.dateTimePickup.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickup.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Return Time";
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(742, 23);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(200, 26);
            this.dateTimeReturn.TabIndex = 10;
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Location = new System.Drawing.Point(129, 139);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(69, 20);
            this.Province.TabIndex = 11;
            this.Province.Text = "Province";
            // 
            // radioProvinceAll
            // 
            this.radioProvinceAll.AutoSize = true;
            this.radioProvinceAll.Checked = true;
            this.radioProvinceAll.Location = new System.Drawing.Point(215, 137);
            this.radioProvinceAll.Name = "radioProvinceAll";
            this.radioProvinceAll.Size = new System.Drawing.Size(51, 24);
            this.radioProvinceAll.TabIndex = 12;
            this.radioProvinceAll.TabStop = true;
            this.radioProvinceAll.Text = "All";
            this.radioProvinceAll.UseVisualStyleBackColor = true;
            // 
            // radioMyProvince
            // 
            this.radioMyProvince.AutoSize = true;
            this.radioMyProvince.Location = new System.Drawing.Point(293, 139);
            this.radioMyProvince.Name = "radioMyProvince";
            this.radioMyProvince.Size = new System.Drawing.Size(118, 24);
            this.radioMyProvince.TabIndex = 13;
            this.radioMyProvince.Text = "My Province";
            this.radioMyProvince.UseVisualStyleBackColor = true;
            // 
            // radioCustomProvince
            // 
            this.radioCustomProvince.AutoSize = true;
            this.radioCustomProvince.Location = new System.Drawing.Point(450, 139);
            this.radioCustomProvince.Name = "radioCustomProvince";
            this.radioCustomProvince.Size = new System.Drawing.Size(89, 24);
            this.radioCustomProvince.TabIndex = 14;
            this.radioCustomProvince.Text = "Custom";
            this.radioCustomProvince.UseVisualStyleBackColor = true;
            // 
            // textProvince
            // 
            this.textProvince.Location = new System.Drawing.Point(584, 139);
            this.textProvince.Name = "textProvince";
            this.textProvince.Size = new System.Drawing.Size(172, 26);
            this.textProvince.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(446, 194);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(60, 20);
            this.label123.TabIndex = 17;
            this.label123.Text = "Branch";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(215, 194);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(196, 28);
            this.comboBoxTypes.TabIndex = 18;
            // 
            // comboBoxBranches
            // 
            this.comboBoxBranches.FormattingEnabled = true;
            this.comboBoxBranches.Location = new System.Drawing.Point(584, 194);
            this.comboBoxBranches.Name = "comboBoxBranches";
            this.comboBoxBranches.Size = new System.Drawing.Size(172, 28);
            this.comboBoxBranches.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(866, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 64);
            this.button2.TabIndex = 20;
            this.button2.Text = "Show Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 953);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxBranches);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textProvince);
            this.Controls.Add(this.radioCustomProvince);
            this.Controls.Add(this.radioMyProvince);
            this.Controls.Add(this.radioProvinceAll);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.radioCustomCity);
            this.Controls.Add(this.radioMyCity);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "CustomerCarsForm";
            this.Text = "Find a Car";
            this.Load += new System.EventHandler(this.CustomerBranchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioMyCity;
        private System.Windows.Forms.RadioButton radioCustomCity;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label Province;
        private System.Windows.Forms.RadioButton radioProvinceAll;
        private System.Windows.Forms.RadioButton radioMyProvince;
        private System.Windows.Forms.RadioButton radioCustomProvince;
        private System.Windows.Forms.TextBox textProvince;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.ComboBox comboBoxBranches;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}