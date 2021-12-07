using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class FormOrderTab : Form
    {
        public FormOrderTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVorders.DataSource = DBObjects.Entities.Orders.ToList();
            this.DGVorders.Columns["Code_order"].Visible = false;
            this.DGVorders.Columns["Code_worker"].Visible = false;
            this.DGVorders.Columns["Code_client"].Visible = false;
            this.DGVorders.Columns["Code_tour"].Visible = false;
            DGVtour.DataSource = DBObjects.Entities.Tour.ToList();
            this.DGVtour.Columns["Orders"].Visible = false;
            this.DGVtour.Columns["Code_hotel"].Visible = false;
            this.DGVtour.Columns["Code_transport"].Visible = false;
        }

        private void DGVorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Orders orders = (Orders)DGVorders.Rows[e.RowIndex].DataBoundItem;
            FormOrders formOrders = new FormOrders(orders);
            formOrders.ShowDialog();
            Fill();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            FormOrders formOrders = new FormOrders(orders);
            formOrders.ShowDialog();
            Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVorders.DataSource = DBObjects.Entities.Orders.Where(c => c.Client.Familia_client == txtSearch.Text).ToList();
            }
            else
            {
                DGVorders.DataSource = DBObjects.Entities.Orders.ToList();
            }
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormClientTab formClient = new FormClientTab();
            formClient.ShowDialog();
            this.Close();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormWorkerTab formWorker = new FormWorkerTab();
            formWorker.ShowDialog();
            this.Close();
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormTourTab formTour = new FormTourTab();
            formTour.ShowDialog();
            this.Close();
        }

        private void отелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormHotelTab formHotel = new FormHotelTab();
            formHotel.ShowDialog();
            this.Close();
        }

        private void городаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormCityTab formCity = new FormCityTab();
            formCity.ShowDialog();
            this.Close();
        }

        private void трaнспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormTransportTab formTransport = new FormTransportTab();
            formTransport.ShowDialog();
            this.Close();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormServicTab formServic = new FormServicTab();
            formServic.ShowDialog();
            this.Close();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            Tour tour = new Tour();
            FormTour formTour = new FormTour(tour);
            formTour.ShowDialog();
            Fill();
        }

        private void DGVtour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tour tour = (Tour)DGVtour.Rows[e.RowIndex].DataBoundItem;
            FormTour formTour = new FormTour(tour);
            formTour.ShowDialog();
            Fill();
        }

        private void btnSearchTour_Click(object sender, EventArgs e)
        {
            if (txtSearchTour.Text != "")
            {
                int SearchTour = Convert.ToInt32(txtSearchTour.Text);
                DGVtour.DataSource = DBObjects.Entities.Tour.Where(c => c.Code_tour == SearchTour).ToList();
            }
            else
            {
                DGVtour.DataSource = DBObjects.Entities.Tour.ToList();
            }
        }
    }
}
