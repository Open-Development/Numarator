﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numarator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Numarator";
            btnGetNumber.Text = "Get Number";
            lblLastNumber.Text = "-";
        }

        private void BtnGetNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
