﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSchool
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
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 75)
            {
                timer1.Stop();
                new Form2().Show();
                this.Hide();

            }

        }

        private void Bus_Click(object sender, EventArgs e)
        {

        }
    }
}
