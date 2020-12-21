using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class myBlackList : Form
    {
        public myBlackList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AgeLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setParametrForManOrWoman();
        }
        private void setParametrForManOrWoman()
        {
            if (manRB.Checked)
            {
                heightOrWeightLbl.Text = "Рост";
                hairLengthOrSalaryLbl.Text = "Зарплата";
            }
            else
            {
                heightOrWeightLbl.Text = "Вес";
                hairLengthOrSalaryLbl.Text = "Длина" + '\n'+ "волос";
            }
        }

        private void manRB_CheckedChanged(object sender, EventArgs e)
        {
            setParametrForManOrWoman();
        }

        private void womanRB_CheckedChanged(object sender, EventArgs e)
        {
            setParametrForManOrWoman();
        }

        private void setNewHumanBt_Click(object sender, EventArgs e)
        {
            if (manRB.Checked)
            {
                setNewMan();
            }
            else
            {
                if ( womanRB.Checked)
                {
                    setNewWoman();
                }
            }
        }
        private void setNewWoman()
        {
            int hairLength, weight, age;

            try
            {
                hairLength = Convert.ToInt32(hairLengthOrSalaryTB.Text);
                weight = Convert.ToInt32(heightOrWeightTB.Text);
                age = Convert.ToInt32(AgeTB.Text);
                Woman woman = new Woman(weight,hairLength, nameTB.Text, lastNameTB.Text, middleNameTB.Text, age);
                humanListCBx.Items.Add(woman.Name + " " + woman.LastName + " " + woman.MiddleName + " рост:" + woman.Weight + " возраст:" + woman.Age + " зарплата:" + woman.HairLength);
            }
            catch
            {
                try
                {
                    hairLength = Convert.ToInt32(hairLengthOrSalaryTB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Введена некорректная зарплата!");
                }
                try
                {
                    weight = Convert.ToInt32(heightOrWeightTB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Введен некорректный рост!");
                }
                try
                {
                    age = Convert.ToInt32(AgeTB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Введен некорректный возраст!");
                }

            }

        }
        private void setNewMan()
        {
            int salary, height, age;

            try
            {
                salary = Convert.ToInt32(hairLengthOrSalaryTB.Text);
                height = Convert.ToInt32(heightOrWeightTB.Text);
                age = Convert.ToInt32(AgeTB.Text);
                Man man = new Man(salary, height, nameTB.Text, lastNameTB.Text, middleNameTB.Text, age);
                humanListCBx.Items.Add(man.Name+" "+man.LastName + " " +man.MiddleName+ " рост:" + man.Height + " возраст:"+man.Age+" зарплата:"+man.Salary);
            }
            catch
            {
                try
                {
                    salary = Convert.ToInt32(hairLengthOrSalaryTB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Введена некорректная зарплата!");
                }
                try
                {
                    height = Convert.ToInt32(heightOrWeightTB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Введен некорректный рост!");
                }
                try
                {
                    age = Convert.ToInt32(AgeTB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Введен некорректный возраст!");
                }

            }
           
        }
    }
}
