﻿using BLL;
using DTO;
using DTO.CodeFirstDB;
using PBL3.View.tour;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PBL3.View.homepage
{
    public partial class TourTicketItemView : UserControl
    {
        private TourTicket ticket;
        public delegate void LoadDataParent();
        public LoadDataParent loadDataParent { get; set; }
        public TourTicketItemView(TourTicket ticket, bool isHideCancel = true)
        {
            InitializeComponent();
            btnCancel.Visible = !isHideCancel;
            if (isHideCancel) btnViewTour.Location = new Point(500, 125);
            this.ticket = ticket;
            GUI();
        }

        private void GUI()
        {
            lbTourName.Text = ticket.Tour.name;
            lbNameUser.Text = ticket.name;
            lbEmail.Text = ticket.email;
            lbTotalPrice.Text = ticket.total_price.ToString("###,###,###,###");
            lbIdentityCard.Text = ticket.identity_card;
            lbNumberAdult.Text = ticket.number_adult.ToString();
            lbNumberChildren.Text = ticket.number_children.ToString();

           
            if (ticket.Tour.TourImages != null) {
                panel1.Controls.Clear();
                List<Image> images = new List<Image>();
                foreach (TourImage tourImage in ticket.Tour.TourImages)
                    images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
                SliderImage sliderImage = new SliderImage(images, false, true);
                panel1.Controls.Add(sliderImage);
                sliderImage.Dock = DockStyle.Fill;
            }
        }

        private void btnViewTour_Click(object sender, System.EventArgs e)
        {
            FormTourDetail f = new FormTourDetail(ticket.tour_id, ticket.account_id);
            f.Show();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn hủy vé đặt này không?", "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TourTicketBLL.Instance.Save(new TourTicket
                {
                    id = ticket.id,
                    identity_card = ticket.identity_card,
                    tour_ticket_status_id = 3
                });
                MessageBox.Show("Vé của bạn đã hủy thành công!!!");
                loadDataParent();
            }
        }
    }
}
