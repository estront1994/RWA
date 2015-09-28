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
    public partial class StartWork : Form
    {
        public StartWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            CreateField newForm = new CreateField();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Выбран файл: " + OPF.FileName);
            }
            Close();
            RealeseAlgorithm newForm = new RealeseAlgorithm();
            newForm.Show();
        }
    }
}
