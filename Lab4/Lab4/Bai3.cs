﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        WebBrowser wb;
        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 1920;
            wb.Height = 1080;
            wb.ScriptErrorsSuppressed = true;
            //wb.DocumentCompleted += wb_DocumentCompleted;

            pnlWeb.Controls.Add(wb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = textBox1.Text;
            wb.Navigate(link);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
