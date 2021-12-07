using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class FormHotel : Form
    {
        private Hotel hotel { get; }
        private Additional_feature add { get; }
        
        public FormHotel(Hotel hotel, Additional_feature add)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.add = add;
            this.Fill();
        }
        private void Fill()
        {
            string city_title = "";
            txtTitle.Text = hotel.Title_hotel;
            nudReiting.Text = Convert.ToString(hotel.Rating);
            txtOpisanie.Text = hotel.Descriptions;
            CLBadd.DataSource = DBObjects.Entities.Servic.ToList();

            cbCodeCity.DataSource = DBObjects.Entities.City.ToList();
            foreach (City city in DBObjects.Entities.City.ToList())
            {
                if (hotel.Code_city == city.Code_city)
                {
                    city_title = city.ToString();

                }
            }
            for (int i = 0; i < cbCodeCity.Items.Count; i++)
                if (cbCodeCity.Items[i].ToString() == city_title)
                    cbCodeCity.SelectedIndex = i;

            if (DBObjects.Entities.Additional_feature.Where(p => p.Code_hotel == hotel.Code_hotel).Count() > 0)
            {
                foreach (Additional_feature additional_f in DBObjects.Entities.Additional_feature.ToList())
                {
                    int nomerBox = 0;
                    foreach (Servic service in DBObjects.Entities.Servic.ToList())
                    {
                        if ((additional_f.Code_service == service.Code_service) && (additional_f.Code_hotel == hotel.Code_hotel))
                        {
                            CLBadd.SetItemCheckState(nomerBox, CheckState.Checked);
                        }
                        nomerBox++;
                    }
                }
            }

        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            hotel.Title_hotel = txtTitle.Text;
        }

        private void nudReiting_ValueChanged(object sender, EventArgs e)
        {
            hotel.Rating = Convert.ToInt32(nudReiting.Text);
        }

        private void txtOpisanie_TextChanged(object sender, EventArgs e)
        {
            hotel.Descriptions = txtOpisanie.Text;
        }

        private void DeleteTour()
        {
            foreach (Tour tour in DBObjects.Entities.Tour.ToList())
            {
                if (tour.Code_hotel == hotel.Code_hotel)
                {
                    DBObjects.Entities.Tour.Remove(tour);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Hotel.Where(p => p.Code_hotel == hotel.Code_hotel).Count() == 0)
            {
                SaveCity();
                DBObjects.Entities.Hotel.Add(hotel);
            }
            SaveFeature();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Hotel.Where(p => p.Code_hotel == hotel.Code_hotel).Count() > 0)
            {
                DeleteFeature();
                DeleteTour();
                DBObjects.Entities.Hotel.Remove(hotel);
                DBObjects.Entities.SaveChanges();                
            }
            Close();
        }
        private void SaveCity()
        {
            //сохранение города
            foreach (City city in DBObjects.Entities.City.ToList())
            {
                if (cbCodeCity.SelectedItem.ToString() == city.ToString())
                {
                    hotel.Code_city = city.Code_city;
                }
            }
        }
        private void SaveFeature()
        {
            //сохранение возможностей
            int nomerServic = 1;
            for (int i = 0; i < CLBadd.Items.Count; i++)
            {
                if (CLBadd.GetItemChecked(i))
                {
                    int count = 0;
                    string service_title = CLBadd.Items[i].ToString();
                    foreach (Servic servic in DBObjects.Entities.Servic.ToList())
                    {
                        if (servic.ToString() == service_title)
                        {
                            nomerServic = servic.Code_service;
                        }
                    }
                    foreach (Additional_feature additionalF in DBObjects.Entities.Additional_feature.ToList())
                    {
                        if ((additionalF.Code_service == nomerServic) && (additionalF.Code_hotel == hotel.Code_hotel))
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        add.Code_hotel = hotel.Code_hotel;
                        add.Code_service = nomerServic;
                        DBObjects.Entities.Additional_feature.Add(add);
                        DBObjects.Entities.SaveChanges();
                    }
                }
                else
                {
                    string service_title = CLBadd.Items[i].ToString();
                    foreach (Servic servic in DBObjects.Entities.Servic.ToList())
                    {
                        if (servic.ToString() == service_title)
                        {
                            nomerServic = servic.Code_service;
                        }
                    }
                    foreach (Additional_feature additionalF in DBObjects.Entities.Additional_feature.ToList())
                    {
                        if ((additionalF.Code_service == nomerServic) && (additionalF.Code_hotel == hotel.Code_hotel))
                        {
                            DBObjects.Entities.Additional_feature.Remove(additionalF);
                        }
                    }
                }
            }
            DBObjects.Entities.SaveChanges();
        }
        private void DeleteFeature()
        {
            int nomerServic = 1;
            for (int i = 0; i < CLBadd.Items.Count; i++)
            {                    
                string service_title = CLBadd.Items[i].ToString();
                foreach (Servic servic in DBObjects.Entities.Servic.ToList())
                {
                    if (servic.ToString() == service_title)
                    {
                        nomerServic = servic.Code_service;
                    }
                }
                foreach (Additional_feature additionalF in DBObjects.Entities.Additional_feature.ToList())
                {
                    if ((additionalF.Code_service == nomerServic) && (additionalF.Code_hotel == hotel.Code_hotel))
                    {
                        DBObjects.Entities.Additional_feature.Remove(additionalF);
                    }
                }                
            }
            DBObjects.Entities.SaveChanges();
        }
    }
}
