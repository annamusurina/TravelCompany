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
    public partial class FormCity : Form
    {
        private City city { get; }
        public FormCity(City city)
        {
            InitializeComponent();
            this.city = city;
            this.Fill();
        }
        private void Fill()
        {
            txtCity.Text = city.Title_city;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            city.Title_city = txtCity.Text;
        }
        private void DeleteCity()
        {
            foreach (Hotel hotel in DBObjects.Entities.Hotel.ToList())
            {
                if (hotel.Code_city == city.Code_city)
                {
                    DBObjects.Entities.Hotel.Remove(hotel);
                }
            }
            DBObjects.Entities.SaveChanges();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.City.Where(p => p.Code_city == city.Code_city).Count() == 0)
            {
                DBObjects.Entities.City.Add(city);
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.City.Where(p => p.Code_city == city.Code_city).Count() > 0)
            {
                DeleteCity();
                DBObjects.Entities.City.Remove(city);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }
    }
}
