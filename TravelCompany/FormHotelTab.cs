using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class FormHotelTab : Form
    {
        public FormHotelTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVhotel.DataSource = DBObjects.Entities.Hotel.ToList();
            this.DGVhotel.Columns["Additional_feature"].Visible = false;
            this.DGVhotel.Columns["Tour"].Visible = false;
            this.DGVhotel.Columns["Code_hotel"].Visible = false;
            this.DGVhotel.Columns["Code_city"].Visible = false;
            DGVadditional_features.DataSource = DBObjects.Entities.Additional_feature.ToList();
            this.DGVadditional_features.Columns["Code_hotel"].Visible = false;
            this.DGVadditional_features.Columns["Code_feature"].Visible = false;
            this.DGVadditional_features.Columns["Code_service"].Visible = false;
        }

        private void DGVhotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Additional_feature additional = new Additional_feature();
            Hotel hotel = (Hotel)DGVhotel.Rows[e.RowIndex].DataBoundItem;
            FormHotel formHotel = new FormHotel(hotel, additional);
            formHotel.ShowDialog();
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            Additional_feature additional = new Additional_feature();
            Hotel hotel = new Hotel();
            FormHotel formHotel = new FormHotel(hotel,additional);
            formHotel.ShowDialog();
            Fill();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text != "")
            {
                DGVhotel.DataSource = DBObjects.Entities.Hotel.Where(c => c.Title_hotel == txtSearch1.Text).ToList();
            }
            else
            {
                DGVhotel.DataSource = DBObjects.Entities.Hotel.ToList();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (txtSearch2.Text != "")
            {
                DGVadditional_features.DataSource = DBObjects.Entities.Additional_feature.Where(c => c.Hotel.Title_hotel == txtSearch2.Text).ToList();
            }
            else
            {
                DGVadditional_features.DataSource = DBObjects.Entities.Additional_feature.ToList();
            }
        }
    }
}
