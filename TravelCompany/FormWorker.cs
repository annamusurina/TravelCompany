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
    public partial class FormWorker : Form
    {
        private Worker worker { get; }
        public FormWorker(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            this.Fill();
        }
        private void Fill()
        {
            txtFamilia.Text = worker.Familia_worker;
            txtName.Text = worker.Name_worker;
            txtOtchestvo.Text = worker.Patronymic_worker;
            txtPassport.Text = Convert.ToString(worker.Passport);
            txtTelephone.Text = worker.Telephone;
        }
        private void txtFamilia_TextChanged(object sender, EventArgs e)
        {
            worker.Familia_worker = txtFamilia.Text;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            worker.Name_worker = txtName.Text;
        }
        private void txtOtchestvo_TextChanged(object sender, EventArgs e)
        {
            worker.Patronymic_worker = txtOtchestvo.Text;
        }
        private void txtPassport_TextChanged(object sender, EventArgs e)
        {
            worker.Passport = Convert.ToInt32(txtPassport.Text);
        }
        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            worker.Telephone = txtTelephone.Text;
        }
        private void DeleteWorker()
        {
            foreach (Orders orders in DBObjects.Entities.Orders.ToList())
            {
                if (orders.Code_worker == worker.Code_worker)
                {
                    DBObjects.Entities.Orders.Remove(orders);
                }
            }
            DBObjects.Entities.SaveChanges();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Worker.Where(p => p.Code_worker == worker.Code_worker).Count() == 0)
            {
                DBObjects.Entities.Worker.Add(worker);
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Worker.Where(p => p.Code_worker == worker.Code_worker).Count() > 0)
            {
                DeleteWorker();
                DBObjects.Entities.Worker.Remove(worker);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }
    }
}
