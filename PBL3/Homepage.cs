﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Homepage : Form
    {
        private Account account;
        public Homepage(Account ac)
        {
            InitializeComponent();
            account = ac;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

<<<<<<< HEAD
        private void choiceAdmin_Click(object sender, EventArgs e)
=======
        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c
        {
            AdManagement f = new AdManagement();
            f.ShowDialog();
        }
<<<<<<< HEAD

        private void choiceLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
=======
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c
    }
}
