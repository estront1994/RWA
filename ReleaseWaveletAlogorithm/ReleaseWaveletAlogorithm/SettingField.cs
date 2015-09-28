﻿using System;
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
    public partial class SettingField : Form
    {
        public SettingField()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            CreateField newForm = new CreateField();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            RealeseAlgorithm newForm = new RealeseAlgorithm();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Сохранить поле
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добаить источник
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Добаить приемник
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Добаить препятствие
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }
    }
}
