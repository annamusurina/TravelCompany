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
    public partial class FormServic : Form
    {
        private Servic servic { get; }
        public FormServic(Servic servic)
        {
            InitializeComponent();
            this.servic = servic;
            this.Fill();
        }
        private void Fill()
        {
            txtServic.Text = servic.Title_service;
        }

        private void txtServic_TextChanged(object sender, EventArgs e)
        {
            servic.Title_service = txtServic.Text;
        }

        private void DeleteServic()
        {
            foreach (Additional_feature additionalF in DBObjects.Entities.Additional_feature.ToList())
            {
                if (additionalF.Code_service == servic.Code_service)
                {
                    DBObjects.Entities.Additional_feature.Remove(additionalF);
                }
            }
            DBObjects.Entities.SaveChanges();
        }
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Servic.Where(p => p.Code_service == servic.Code_service).Count() == 0)
            {
                DBObjects.Entities.Servic.Add(servic);
            }
            DBObjects.Entities.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBObjects.Entities.Servic.Where(p => p.Code_service == servic.Code_service).Count() > 0)
            {
                DeleteServic();
                DBObjects.Entities.Servic.Remove(servic);
                DBObjects.Entities.SaveChanges();
            }
            Close();
        }
    }
}
