﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Value.Text);
            int num2 = int.Parse(Jyou.Text);
            int result = num1;
            for (int i = 1; i < num2; i++)
            {
                result = result * num1;
            }
            Result.Text = result.ToString();
        }
    }
}
