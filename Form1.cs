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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            MessageBox messageBox = new MessageBox();
            messageBox.ShowDialog();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            TestPage testPage = new TestPage();
            testPage.Show();
            this.Hide();
        }
    }
}
