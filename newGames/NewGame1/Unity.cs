﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewGame
{
    public partial class Unity : Form
    {
        public Unity()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}