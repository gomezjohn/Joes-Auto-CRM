﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pageButton_Click(object sender, EventArgs e)
        {
            if (vehiclebox.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            if (customersBox.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
                
        }
    }
}
