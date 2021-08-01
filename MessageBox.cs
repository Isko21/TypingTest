using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Test_App
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
