﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_20520377
{
    public partial class FormDieuHuong : Form
    {
        public FormDieuHuong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Bai1().ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bai2().ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Bai3().ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Bai4().ShowDialog();
            this.Hide();
        }
    }
}
