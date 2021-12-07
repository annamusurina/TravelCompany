using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class FormOrders : Form
    {
        private Orders orders { get; }
        public FormOrders(Orders orders)
        {
            InitializeComponent();
            this.orders = orders;
            this.Fill();
        }
        private void Fill()
        {
            string client_fio = "";
            string worker_fio = "";
            cbCodeClient.DataSource = DBObjects.Entities.Client.ToList();
            foreach (Client client in DBObjects.Entities.Client.ToList())
            {
                if (orders.Code_client == client.Code_client)
                {
                    client_fio = client.ToString();                   
                   
                }
            }
            for(int i = 0; i < cbCodeClient.Items.Count; i++)
                if(cbCodeClient.Items[i].ToString() == client_fio)
                    cbCodeClient.SelectedIndex = i;

            txtCodeTour.Text = Convert.ToString(orders.Code_tour);
            cbCodeWorker.DataSource = DBObjects.Entities.Worker.ToList();
            foreach (Worker worker in DBObjects.Entities.Worker.ToList())
            {
                if (orders.Code_worker == worker.Code_worker)
                {
                    worker_fio = worker.ToString();

                }
            }
            for (int i = 0; i < cbCodeWorker.Items.Count; i++)
                if (cbCodeWorker.Items[i].ToString() == worker_fio)
                    cbCodeWorker.SelectedIndex = i;
           
            DateTime data = new DateTime(1753, 1, 1, 0, 0, 0);
            if (orders.Registration_date > data)
            {
                DateRegistr.Value = orders.Registration_date;
            }
            

            DGVtour.DataSource = DBObjects.Entities.Tour.ToList();
            this.DGVtour.Columns["Orders"].Visible = false;
            this.DGVtour.Columns["Code_hotel"].Visible = false;
            this.DGVtour.Columns["Code_transport"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Orders.Where(p => p.Code_order == orders.Code_order).Count() == 0)
            {
                Save();
                DBObjects.Entities.Orders.Add(orders);
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Orders.Where(p => p.Code_order == orders.Code_order).Count() > 0)
            {
                DBObjects.Entities.Orders.Remove(orders);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }
        private void txtCodeTour_TextChanged_1(object sender, EventArgs e)
        {
            orders.Code_tour = Convert.ToInt32(txtCodeTour.Text);
        }
        private void Save()
        {
            foreach (Client client in DBObjects.Entities.Client.ToList())
            {
                if (cbCodeClient.SelectedItem.ToString() == client.ToString())
                {
                    orders.Code_client = client.Code_client;
                }
            }
            foreach (Worker worker in DBObjects.Entities.Worker.ToList())
            {
                if (cbCodeWorker.SelectedItem.ToString() == worker.ToString())
                {
                    orders.Code_worker = worker.Code_worker;
                }
            }
        }
        private void DGVtour_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tour tour = (Tour)DGVtour.Rows[e.RowIndex].DataBoundItem;
            txtCodeTour.Text = Convert.ToString(tour.Code_tour);
        }

        private void DateRegistr_ValueChanged(object sender, EventArgs e)
        {
            orders.Registration_date = DateRegistr.Value;
        }
    }
}
