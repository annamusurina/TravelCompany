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
    public partial class FormTourTab : Form
    {
        public FormTourTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVtour.DataSource = DBObjects.Entities.Tour.ToList();
            this.DGVtour.Columns["Orders"].Visible = false;
            this.DGVtour.Columns["Code_hotel"].Visible = false;
            this.DGVtour.Columns["Code_transport"].Visible = false;
        }

        private void DGVtour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tour tour = (Tour)DGVtour.Rows[e.RowIndex].DataBoundItem;
            FormTour formTour = new FormTour(tour);
            formTour.ShowDialog();
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            Tour tour = new Tour();
            FormTour formTour = new FormTour(tour);
            formTour.ShowDialog();
            Fill();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text != "" && txtSearch2.Text == "")
            {
                int SearchTour = Convert.ToInt32(txtSearch1.Text);
                DGVtour.DataSource = DBObjects.Entities.Tour.Where(c => c.Code_tour == SearchTour).ToList();
            }
            else
            {
                DGVtour.DataSource = DBObjects.Entities.Tour.ToList();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text == "" && txtSearch2.Text != "")
            {
                DGVtour.DataSource = DBObjects.Entities.Tour.Where(c => c.Hotel.Title_hotel == txtSearch2.Text).ToList();
            }
            else
            {
                DGVtour.DataSource = DBObjects.Entities.Tour.ToList();
            }
        }
    }
}
