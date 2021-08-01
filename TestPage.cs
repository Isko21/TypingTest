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
    public partial class TestPage : Form
    {
        public TestPage()
        {
            InitializeComponent();
        }
        private void TestPage_Load(object sender, EventArgs e)
        {
            using (var soundPlayer = new System.Media.SoundPlayer(@"Audios\music.wav"))
            {
                soundPlayer.Play();
            }
        }
    }
}
