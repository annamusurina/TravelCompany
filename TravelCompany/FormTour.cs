using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class FormTour : Form
    {
        private Tour tour { get; }
        public FormTour(Tour tour)
        {
            InitializeComponent();
            this.tour = tour;
            this.Fill();
        }
        private void Fill()
        {
            string hotel_title = "";
            cbCodeHotel.DataSource = DBObjects.Entities.Hotel.ToList();
            foreach (Hotel hotel in DBObjects.Entities.Hotel.ToList())
            {
                if (tour.Code_hotel == hotel.Code_hotel)
                {
                    hotel_title = hotel.ToString();
                }
            }
            for (int i = 0; i < cbCodeHotel.Items.Count; i++)
                if (cbCodeHotel.Items[i].ToString() == hotel_title)
                    cbCodeHotel.SelectedIndex = i;

            cbCodeTransport.DataSource = DBObjects.Entities.Transport.ToList();
            string transport_title = "";
            foreach (Transport transport in DBObjects.Entities.Transport.ToList())
            {
                if (tour.Code_transport == transport.Code_transport)
                {
                    transport_title = transport.ToString();
                }
            }
            for (int i = 0; i < cbCodeTransport.Items.Count; i++)
                if (cbCodeTransport.Items[i].ToString() == transport_title)
                    cbCodeTransport.SelectedIndex = i;

            txtNumber.Text = Convert.ToString(tour.Number_of_people);
            txtFromWhere.Text = tour.From_Where;
            txtToWhere.Text = tour.To_Where;
            txtPrice.Text = Convert.ToString(tour.Price);
            txtOpisanie.Text = tour.Descriptions;
            DateTime data = new DateTime(1753, 1, 1, 0, 0, 0);
            if (tour.Arrival_date > data)
            {
                DateTo.Value = tour.Arrival_date;
            }
            if (tour.Departure_date > data)
            {
                DateFrom.Value = tour.Departure_date;
            }

        }
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            tour.Number_of_people = Convert.ToInt32(txtNumber.Text);
        }

        private void txtFromWhere_TextChanged(object sender, EventArgs e)
        {
            tour.From_Where = txtFromWhere.Text;
        }

        private void txtToWhere_TextChanged(object sender, EventArgs e)
        {
            tour.To_Where = txtToWhere.Text;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            tour.Price = Convert.ToDouble(txtPrice.Text);
        }
        private void txtOpisanie_TextChanged(object sender, EventArgs e)
        {
            tour.Descriptions = txtOpisanie.Text;
        }
        private void Save()
        {
            foreach (Hotel hotel in DBObjects.Entities.Hotel.ToList())
            {
                if (cbCodeHotel.SelectedItem.ToString() == hotel.ToString())
                {
                    tour.Code_hotel = hotel.Code_hotel;
                }
            }
            foreach (Transport transport in DBObjects.Entities.Transport.ToList())
            {
                if (cbCodeTransport.SelectedItem.ToString() == transport.ToString())
                {
                    tour.Code_transport = transport.Code_transport;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Tour.Where(p => p.Code_tour == tour.Code_tour).Count() == 0)
            {
                Save();
                DBObjects.Entities.Tour.Add(tour);
            }
            DBObjects.Entities.SaveChanges();
        }
        private void DeleteTour()
        {
            foreach (Orders orders in DBObjects.Entities.Orders.ToList())
            {
                if (orders.Code_tour == tour.Code_tour)
                {
                    DBObjects.Entities.Orders.Remove(orders);
                }
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Tour.Where(p => p.Code_tour == tour.Code_tour).Count() > 0)
            {
                DeleteTour();
                DBObjects.Entities.Tour.Remove(tour);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            tour.Departure_date = DateFrom.Value;
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            tour.Arrival_date = DateTo.Value;
        }
    }
}
