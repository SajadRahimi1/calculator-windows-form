﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            answer.Text = (float.Parse(number1.Text) + float.Parse(number2.Text)).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            answer.Text = (float.Parse(number1.Text) - float.Parse(number2.Text)).ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            answer.Text = (float.Parse(number1.Text) * float.Parse(number2.Text)).ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            answer.Text = (float.Parse(number1.Text) / float.Parse(number2.Text)).ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            answer.Text = (Math.Pow(float.Parse(number1.Text), float.Parse(number2.Text))).ToString();
            
        }
    }
}
