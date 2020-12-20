namespace WindowsFormsApp1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(72, 6);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(154, 20);
            this.nameTB.TabIndex = 0;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(72, 32);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(154, 20);
            this.lastNameTB.TabIndex = 1;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(72, 58);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(154, 20);
            this.middleNameTB.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(29, 13);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Имя";
            this.nameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(12, 35);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(56, 13);
            this.lastNameLbl.TabIndex = 4;
            this.lastNameLbl.Text = "Фамилия";
            this.lastNameLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // middleNameLbl
            // 
            this.middleNameLbl.AutoSize = true;
            this.middleNameLbl.Location = new System.Drawing.Point(12, 58);
            this.middleNameLbl.Name = "middleNameLbl";
            this.middleNameLbl.Size = new System.Drawing.Size(54, 13);
            this.middleNameLbl.TabIndex = 5;
            this.middleNameLbl.Text = "Отчество";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(12, 84);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(49, 13);
            this.AgeLbl.TabIndex = 7;
            this.AgeLbl.Text = "Возраст";
            this.AgeLbl.Click += new System.EventHandler(this.AgeLbl_Click);
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(72, 84);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(154, 20);
            this.AgeTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.middleNameLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.nameTB);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

