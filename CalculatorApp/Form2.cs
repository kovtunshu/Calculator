﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        Button bnAbout = new Button();

        public Form2()
        {
            InitializeComponent();
            bnAbout.Text = "About";
            this.Controls.Add(bnAbout);
        }
    }
}
