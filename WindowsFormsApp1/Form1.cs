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
            Man man=new Man(Convert.ToInt32(hairLengthOrSalaryTB.Text),
                Convert.ToInt32(heightOrWeightTB),nameTB.Text,lastNameTB.Text,middleNameTB.Text,
                Convert.ToInt32(AgeTB.Text));
        }
    }
}
