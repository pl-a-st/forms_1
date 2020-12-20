namespace WindowsFormsApp1
{
    partial class myBlackList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.middleNameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.inPutGB = new System.Windows.Forms.GroupBox();
            this.heightOrWeightLbl = new System.Windows.Forms.Label();
            this.heightOrWeightTB = new System.Windows.Forms.TextBox();
            this.hairLengthOrSalaryLbl = new System.Windows.Forms.Label();
            this.hairLengthOrSalaryTB = new System.Windows.Forms.TextBox();
            this.manRB = new System.Windows.Forms.RadioButton();
            this.womanRB = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.setNewHumanBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inPutGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(72, 68);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(154, 20);
            this.nameTB.TabIndex = 0;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(72, 94);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(154, 20);
            this.lastNameTB.TabIndex = 1;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(72, 120);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(154, 20);
            this.middleNameTB.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(6, 71);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(29, 13);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Имя";
            this.nameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(4, 97);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(56, 13);
            this.lastNameLbl.TabIndex = 4;
            this.lastNameLbl.Text = "Фамилия";
            this.lastNameLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // middleNameLbl
            // 
            this.middleNameLbl.AutoSize = true;
            this.middleNameLbl.Location = new System.Drawing.Point(6, 123);
            this.middleNameLbl.Name = "middleNameLbl";
            this.middleNameLbl.Size = new System.Drawing.Size(54, 13);
            this.middleNameLbl.TabIndex = 5;
            this.middleNameLbl.Text = "Отчество";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(6, 149);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(49, 13);
            this.AgeLbl.TabIndex = 7;
            this.AgeLbl.Text = "Возраст";
            this.AgeLbl.Click += new System.EventHandler(this.AgeLbl_Click);
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(72, 146);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(154, 20);
            this.AgeTB.TabIndex = 6;
            // 
            // inPutGB
            // 
            this.inPutGB.Controls.Add(this.womanRB);
            this.inPutGB.Controls.Add(this.manRB);
            this.inPutGB.Controls.Add(this.hairLengthOrSalaryLbl);
            this.inPutGB.Controls.Add(this.hairLengthOrSalaryTB);
            this.inPutGB.Controls.Add(this.heightOrWeightLbl);
            this.inPutGB.Controls.Add(this.heightOrWeightTB);
            this.inPutGB.Controls.Add(this.lastNameLbl);
            this.inPutGB.Controls.Add(this.AgeLbl);
            this.inPutGB.Controls.Add(this.nameTB);
            this.inPutGB.Controls.Add(this.AgeTB);
            this.inPutGB.Controls.Add(this.lastNameTB);
            this.inPutGB.Controls.Add(this.middleNameLbl);
            this.inPutGB.Controls.Add(this.middleNameTB);
            this.inPutGB.Controls.Add(this.nameLbl);
            this.inPutGB.Location = new System.Drawing.Point(12, 12);
            this.inPutGB.Name = "inPutGB";
            this.inPutGB.Size = new System.Drawing.Size(243, 239);
            this.inPutGB.TabIndex = 8;
            this.inPutGB.TabStop = false;
            this.inPutGB.Text = "Данные о человеке";
            // 
            // heightOrWeightLbl
            // 
            this.heightOrWeightLbl.AutoSize = true;
            this.heightOrWeightLbl.Location = new System.Drawing.Point(6, 175);
            this.heightOrWeightLbl.Name = "heightOrWeightLbl";
            this.heightOrWeightLbl.Size = new System.Drawing.Size(68, 13);
            this.heightOrWeightLbl.TabIndex = 9;
            this.heightOrWeightLbl.Text = "[параметр1]";
            // 
            // heightOrWeightTB
            // 
            this.heightOrWeightTB.Location = new System.Drawing.Point(72, 172);
            this.heightOrWeightTB.Name = "heightOrWeightTB";
            this.heightOrWeightTB.Size = new System.Drawing.Size(154, 20);
            this.heightOrWeightTB.TabIndex = 8;
            // 
            // hairLengthOrSalaryLbl
            // 
            this.hairLengthOrSalaryLbl.AutoSize = true;
            this.hairLengthOrSalaryLbl.Location = new System.Drawing.Point(6, 201);
            this.hairLengthOrSalaryLbl.Name = "hairLengthOrSalaryLbl";
            this.hairLengthOrSalaryLbl.Size = new System.Drawing.Size(68, 13);
            this.hairLengthOrSalaryLbl.TabIndex = 11;
            this.hairLengthOrSalaryLbl.Text = "[параметр2]";
            // 
            // hairLengthOrSalaryTB
            // 
            this.hairLengthOrSalaryTB.Location = new System.Drawing.Point(72, 198);
            this.hairLengthOrSalaryTB.Name = "hairLengthOrSalaryTB";
            this.hairLengthOrSalaryTB.Size = new System.Drawing.Size(154, 20);
            this.hairLengthOrSalaryTB.TabIndex = 10;
            // 
            // manRB
            // 
            this.manRB.AutoSize = true;
            this.manRB.Checked = true;
            this.manRB.Location = new System.Drawing.Point(9, 19);
            this.manRB.Name = "manRB";
            this.manRB.Size = new System.Drawing.Size(70, 17);
            this.manRB.TabIndex = 12;
            this.manRB.TabStop = true;
            this.manRB.Text = "Мужчина";
            this.manRB.UseVisualStyleBackColor = true;
            this.manRB.CheckedChanged += new System.EventHandler(this.manRB_CheckedChanged);
            // 
            // womanRB
            // 
            this.womanRB.AutoSize = true;
            this.womanRB.Location = new System.Drawing.Point(9, 42);
            this.womanRB.Name = "womanRB";
            this.womanRB.Size = new System.Drawing.Size(75, 17);
            this.womanRB.TabIndex = 13;
            this.womanRB.Text = "Женщина";
            this.womanRB.UseVisualStyleBackColor = true;
            this.womanRB.CheckedChanged += new System.EventHandler(this.womanRB_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // setNewHumanBt
            // 
            this.setNewHumanBt.Location = new System.Drawing.Point(276, 80);
            this.setNewHumanBt.Name = "setNewHumanBt";
            this.setNewHumanBt.Size = new System.Drawing.Size(225, 23);
            this.setNewHumanBt.TabIndex = 10;
            this.setNewHumanBt.Text = "Добавить человека";
            this.setNewHumanBt.UseVisualStyleBackColor = true;
            this.setNewHumanBt.Click += new System.EventHandler(this.setNewHumanBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добавленные люди";
            // 
            // myBlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setNewHumanBt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.inPutGB);
            this.Name = "myBlackList";
            this.Text = "Черный список";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inPutGB.ResumeLayout(false);
            this.inPutGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label middleNameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.GroupBox inPutGB;
        private System.Windows.Forms.RadioButton womanRB;
        private System.Windows.Forms.RadioButton manRB;
        private System.Windows.Forms.Label hairLengthOrSalaryLbl;
        private System.Windows.Forms.TextBox hairLengthOrSalaryTB;
        private System.Windows.Forms.Label heightOrWeightLbl;
        private System.Windows.Forms.TextBox heightOrWeightTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button setNewHumanBt;
        private System.Windows.Forms.Label label1;
    }
}

