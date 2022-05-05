﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace PBL3.View.admin
{
    public partial class AdminManagement : Form
    {
        bool sidebarExpand;
        public AdminManagement()
        {
            InitializeComponent();
            Load += AdminManagement_Load;
            manacontainer.Visible = false;
            btnStatistic.Location = new Point(0, 362);
        }
        public void SetActivePanel(UserControl control)
        {
            //set all usercontrol false
            employeeManagement1.Visible = false;
            customer1.Visible = false;
            tourManagement1.Visible = false;
            transportManagement1.Visible = false;
            hotelManagement1.Visible = false;
            siteManagement1.Visible = false;
            control.Visible = true;
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            SetActivePanel(employeeManagement1);
        }
        private void hidesubmenu()
        {
            if (manacontainer.Visible == true)
            {
                manacontainer.Visible = false;
            }

        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
                btnStatistic.Location = new Point(0, 503);
            }
            else
            {
                submenu.Visible = false;
                btnStatistic.Location = new Point(0, 362);
            }

        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            showsubmenu(manacontainer);
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SetActivePanel(employeeManagement1);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SetActivePanel(customer1);
        }

        private void btnTour_Click_1(object sender, EventArgs e)
        {
            SetActivePanel(tourManagement1);
            hidesubmenu();
            btnStatistic.Location = new Point(0, 362);
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {

            SetActivePanel(transportManagement1);
            hidesubmenu();
            btnStatistic.Location = new Point(0, 362);
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            SetActivePanel(hotelManagement1);
            hidesubmenu();
            btnStatistic.Location = new Point(0, 362);
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            SetActivePanel(siteManagement1);
            hidesubmenu();
            btnStatistic.Location = new Point(0, 362);
        }
        private void SidebarTimer_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                navbar.Width -= 10;
                if (navbar.Width == navbar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                navbar.Width += 10;
                if (navbar.Width == navbar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }

            }
        }

        private void pcMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }
      
    }
}
