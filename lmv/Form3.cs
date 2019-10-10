using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmv
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 F2)
        {
            F2.Show();
        }

        private void CardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashCard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CardConf_Click(object sender, EventArgs e)
        {

        }

        private void CardCode_TextChanged(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
