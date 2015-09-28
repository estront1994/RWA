using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseWaveletAlogorithm
{
    public partial class Start_menu : Form
    {

        public Start_menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartWork newForm = new StartWork();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }
    }
}
