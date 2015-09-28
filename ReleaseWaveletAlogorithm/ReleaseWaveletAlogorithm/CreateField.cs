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
    public partial class CreateField : Form
    {
        public CreateField()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateField_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            SetingField newForm = new SetingField();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            StartWork newForm = new StartWork();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }
    }
}
