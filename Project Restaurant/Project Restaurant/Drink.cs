﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant
{
    public partial class Drink : Form
    {
        public Drink()
        {
            InitializeComponent();
            comboBox8.Items.Add("มีน้ำตาล");
            comboBox8.Items.Add("ไม่มีน้ำตาล");
            comboBox1.Items.Add("น้ำแร่");
            comboBox1.Items.Add("น้ำธรรมดา");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
