
namespace GrandRentAuto
{
    partial class CarForm
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
            this.listViewCars = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoredAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.textBoxMilage = new System.Windows.Forms.TextBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxStoredAt = new System.Windows.Forms.ComboBox();
            this.textboxPlate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newCarSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView_types = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_changeFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_dailyRate = new System.Windows.Forms.TextBox();
            this.textBox_weeklyRate = new System.Windows.Forms.TextBox();
            this.textBox_monthlyRate = new System.Windows.Forms.TextBox();
            this.textBox_typeDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveType = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCars
            // 
            this.listViewCars.CheckBoxes = true;
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.plat,
            this.StoredAt,
            this.Type,
            this.Mileage,
            this.Status});
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(162, 111);
            this.listViewCars.MultiSelect = false;
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(644, 452);
            this.listViewCars.TabIndex = 0;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCars_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // plat
            // 
            this.plat.Text = "Plate Number";
            this.plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plat.Width = 120;
            // 
            // StoredAt
            // 
            this.StoredAt.Text = "Branch";
            this.StoredAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StoredAt.Width = 120;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 80;
            // 
            // Mileage
            // 
            this.Mileage.Text = "Mileage";
            this.Mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mileage.Width = 80;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 65;
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "Branch Name",
            "City",
            "Type"});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(242, 49);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(191, 28);
            this.comboBoxFilterBy.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 587);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 62);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(588, 587);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(218, 62);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter By";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(480, 49);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(326, 26);
            this.textBoxFilter.TabIndex = 6;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.textBoxMilage);
            this.panelAdd.Controls.Add(this.comboBoxTypes);
            this.panelAdd.Controls.Add(this.comboBoxStoredAt);
            this.panelAdd.Controls.Add(this.textboxPlate);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.newCarSave);
            this.panelAdd.Controls.Add(this.button1);
            this.panelAdd.Location = new System.Drawing.Point(869, 111);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(577, 452);
            this.panelAdd.TabIndex = 7;
            this.panelAdd.Visible = false;
            // 
            // textBoxMilage
            // 
            this.textBoxMilage.Location = new System.Drawing.Point(299, 207);
            this.textBoxMilage.Name = "textBoxMilage";
            this.textBoxMilage.Size = new System.Drawing.Size(215, 26);
            this.textBoxMilage.TabIndex = 11;
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(299, 157);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(215, 28);
            this.comboBoxTypes.TabIndex = 10;
            // 
            // comboBoxStoredAt
            // 
            this.comboBoxStoredAt.FormattingEnabled = true;
            this.comboBoxStoredAt.Location = new System.Drawing.Point(299, 109);
            this.comboBoxStoredAt.Name = "comboBoxStoredAt";
            this.comboBoxStoredAt.Size = new System.Drawing.Size(215, 28);
            this.comboBoxStoredAt.TabIndex = 9;
            // 
            // textboxPlate
            // 
            this.textboxPlate.Location = new System.Drawing.Point(299, 48);
            this.textboxPlate.Name = "textboxPlate";
            this.textboxPlate.Size = new System.Drawing.Size(215, 26);
            this.textboxPlate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mileage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stored At";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plate Number";
            // 
            // newCarSave
            // 
            this.newCarSave.Location = new System.Drawing.Point(333, 363);
            this.newCarSave.Name = "newCarSave";
            this.newCarSave.Size = new System.Drawing.Size(200, 65);
            this.newCarSave.TabIndex = 1;
            this.newCarSave.Text = "Save";
            this.newCarSave.UseVisualStyleBackColor = true;
            this.newCarSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Discard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 1023);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 62);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 1023);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 62);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView_types
            // 
            this.listView_types.CheckBoxes = true;
            this.listView_types.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_types.HideSelection = false;
            this.listView_types.Location = new System.Drawing.Point(162, 681);
            this.listView_types.Name = "listView_types";
            this.listView_types.Size = new System.Drawing.Size(644, 299);
            this.listView_types.TabIndex = 8;
            this.listView_types.UseCompatibleStateImageBehavior = false;
            this.listView_types.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Desc";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Daily Rate";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Weekly Rate";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Monthly Rate";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Change Branch Fee";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehicles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 804);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Types";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_changeFee);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_dailyRate);
            this.panel1.Controls.Add(this.textBox_weeklyRate);
            this.panel1.Controls.Add(this.textBox_monthlyRate);
            this.panel1.Controls.Add(this.textBox_typeDesc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSaveType);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(869, 685);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 400);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // textBox_changeFee
            // 
            this.textBox_changeFee.Location = new System.Drawing.Point(299, 251);
            this.textBox_changeFee.Name = "textBox_changeFee";
            this.textBox_changeFee.Size = new System.Drawing.Size(215, 26);
            this.textBox_changeFee.TabIndex = 15;
            this.textBox_changeFee.Leave += new System.EventHandler(this.amountBox_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Change Branch Fee";
            // 
            // textBox_dailyRate
            // 
            this.textBox_dailyRate.Location = new System.Drawing.Point(299, 103);
            this.textBox_dailyRate.Name = "textBox_dailyRate";
            this.textBox_dailyRate.Size = new System.Drawing.Size(215, 26);
            this.textBox_dailyRate.TabIndex = 13;
            this.textBox_dailyRate.Leave += new System.EventHandler(this.amountBox_Leave);
            // 
            // textBox_weeklyRate
            // 
            this.textBox_weeklyRate.Location = new System.Drawing.Point(299, 154);
            this.textBox_weeklyRate.Name = "textBox_weeklyRate";
            this.textBox_weeklyRate.Size = new System.Drawing.Size(215, 26);
            this.textBox_weeklyRate.TabIndex = 12;
            this.textBox_weeklyRate.Leave += new System.EventHandler(this.amountBox_Leave);
            // 
            // textBox_monthlyRate
            // 
            this.textBox_monthlyRate.Location = new System.Drawing.Point(299, 199);
            this.textBox_monthlyRate.Name = "textBox_monthlyRate";
            this.textBox_monthlyRate.Size = new System.Drawing.Size(215, 26);
            this.textBox_monthlyRate.TabIndex = 11;
            this.textBox_monthlyRate.Leave += new System.EventHandler(this.amountBox_Leave);
            // 
            // textBox_typeDesc
            // 
            this.textBox_typeDesc.Location = new System.Drawing.Point(299, 48);
            this.textBox_typeDesc.Name = "textBox_typeDesc";
            this.textBox_typeDesc.Size = new System.Drawing.Size(215, 26);
            this.textBox_typeDesc.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monthly Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Daily Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Weekly Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Description";
            // 
            // btnSaveType
            // 
            this.btnSaveType.Location = new System.Drawing.Point(333, 320);
            this.btnSaveType.Name = "btnSaveType";
            this.btnSaveType.Size = new System.Drawing.Size(200, 65);
            this.btnSaveType.TabIndex = 1;
            this.btnSaveType.Text = "Save";
            this.btnSaveType.UseVisualStyleBackColor = true;
            this.btnSaveType.Click += new System.EventHandler(this.btnSaveType_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(48, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 65);
            this.button6.TabIndex = 0;
            this.button6.Text = "Discard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 1347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView_types);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxFilterBy);
            this.Controls.Add(this.listViewCars);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newCarSave;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.ComboBox comboBoxStoredAt;
        private System.Windows.Forms.TextBox textboxPlate;
        private System.Windows.Forms.TextBox textBoxMilage;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader plat;
        private System.Windows.Forms.ColumnHeader StoredAt;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Mileage;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView_types;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_changeFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_dailyRate;
        private System.Windows.Forms.TextBox textBox_weeklyRate;
        private System.Windows.Forms.TextBox textBox_monthlyRate;
        private System.Windows.Forms.TextBox textBox_typeDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveType;
        private System.Windows.Forms.Button button6;
    }
}