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
    public partial class RealeseAlgorithm : Form
    {
        public RealeseAlgorithm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            SettingField newForm = new SettingField();
            newForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }
    }
}
