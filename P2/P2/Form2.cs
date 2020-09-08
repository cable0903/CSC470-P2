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
        public string dialogResult;
        public Form2(string dialogParam)
        {
            InitializeComponent();
            dialogResult = dialogParam;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
