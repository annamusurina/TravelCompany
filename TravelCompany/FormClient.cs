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
    public partial class FormClient : Form
    {
        private Client client { get; }
        public FormClient(Client client)
        {
            InitializeComponent();
            this.client = client;
            this.Fill();
        }
        private void Fill()
        {
            txtFamilia.Text = client.Familia_client;
            txtName.Text = client.Name_client;
            txtOtchestvo.Text = client.Patronymic_client;
            txtPassport.Text = Convert.ToString(client.Passport);
            txtAdress.Text = client.Adress;
            txtTelephone.Text = client.Telephone;
        }

        private void txtFamilia_TextChanged(object sender, EventArgs e)
        {
            client.Familia_client = txtFamilia.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            client.Name_client = txtName.Text;
        }

        private void txtOtchestvo_TextChanged(object sender, EventArgs e)
        {
            client.Patronymic_client = txtOtchestvo.Text;
        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {
            client.Passport = Convert.ToInt32(txtPassport.Text);
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            client.Adress = txtAdress.Text;
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            client.Telephone = txtTelephone.Text;
        }
        private void DeleteClient()
        {
            foreach (Orders orders in DBObjects.Entities.Orders.ToList())
            {
                if (orders.Code_client == client.Code_client)
                {
                    DBObjects.Entities.Orders.Remove(orders);
                }
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Client.Where(p => p.Code_client == client.Code_client).Count() == 0)
            {
                DBObjects.Entities.Client.Add(client);
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Client.Where(p => p.Code_client == client.Code_client).Count() > 0)
            {
                DeleteClient();
                DBObjects.Entities.Client.Remove(client);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }
    }
}
