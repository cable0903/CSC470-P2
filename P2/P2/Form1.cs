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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fishName;

            if (Crappie.Checked == true)
            {
                fishName = "Crappie";
            }else if(Walleye.Checked == true )
            {
                fishName = "Walleye";
            }else if(Perch.Checked == true)
            {
                fishName = "Perch";
            }
            else
            {
                fishName = "";
            }
            if (fishName == "")

            {
                MessageBox.Show("No Fish Selected","ERROR");
            }
            else
            {
                Form2 Seefish = new Form2(fishName);
                DialogResult rslt = Seefish.ShowDialog();
                if (rslt == DialogResult.OK)
                {
                    MessageBox.Show(Seefish.dialogResult, " Result");
                }
                else
                {
                    MessageBox.Show("Nothing was decited");
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Perch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Crappie_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Walleye_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
