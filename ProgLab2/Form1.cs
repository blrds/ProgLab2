﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (radioButton1.Checked) {
                Exer1 f = new Exer1(this);
                f.Show();
            }
            if (radioButton2.Checked)
            {
                Exer2 f = new Exer2(this);
                f.Show();
            }
            if (radioButton3.Checked)
            {
                Exer3 f = new Exer3(this);
                f.Show();
            }
            if (radioButton4.Checked)
            {
                Exer4 f = new Exer4(this);
                f.Show();
            }
        }
    }
}
