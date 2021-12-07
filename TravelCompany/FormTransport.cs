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
    public partial class FormTransport : Form
    {
        private Transport transport { get; }
        public FormTransport(Transport transport)
        {
            InitializeComponent();
            this.transport = transport;
            this.Fill();
        }
        private void Fill()
        {
            txtTransport.Text = transport.Title_transport;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            transport.Title_transport = txtTransport.Text;
        }
        private void DeleteTransport()
        {
            foreach (Tour tour in DBObjects.Entities.Tour.ToList())
            {
                if (tour.Code_transport == transport.Code_transport)
                {
                    DBObjects.Entities.Tour.Remove(tour);
                }
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Transport.Where(p => p.Code_transport == transport.Code_transport).Count() == 0)
            {
                DBObjects.Entities.Transport.Add(transport);
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Transport.Where(p => p.Code_transport == transport.Code_transport).Count() > 0)
            {
                DeleteTransport();
                DBObjects.Entities.Transport.Remove(transport);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }
    }
}
