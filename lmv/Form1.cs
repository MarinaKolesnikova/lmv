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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void regcode_TextChanged(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void EngLang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YkrLang_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
