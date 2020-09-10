using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Form2 : Form
    {
        public string Fname;
        public string dialogResult;
        public Form2(string fishName)
        {
            InitializeComponent();
            Fname = fishName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if(Fname == "Crappie")
            {
                pictureBox1.Image = Properties.Resources.Crappie;
            }else if (Fname == "Walleye")
            {
                pictureBox1.Image = Properties.Resources.Walleye;
            }
            else if(Fname == "Perch")
            {
                pictureBox1.Image = Properties.Resources.Perch;
            }
            else
            {
                MessageBox.Show("Resource/Image not Found","Loading ERROR!");
            }
        }

        private void calcel_Click(object sender, EventArgs e)
        {
            dialogResult = "Decision Cancelled";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
        private void keep_Click(object sender, EventArgs e)
        {
            dialogResult = "We decided to keep it";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void thorw_Click(object sender, EventArgs e)
        {
            dialogResult = "We decided to throw it";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
