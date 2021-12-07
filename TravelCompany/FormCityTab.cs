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
    public partial class FormCityTab : Form
    {
        public FormCityTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVcity.DataSource = DBObjects.Entities.City.ToList();
            this.DGVcity.Columns["Hotel"].Visible = false;
            this.DGVcity.Columns["Code_city"].Visible = false;
        }

        private void DGVcity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            City city = (City)DGVcity.Rows[e.RowIndex].DataBoundItem;
            FormCity formCity = new FormCity(city);
            formCity.ShowDialog();
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            City city = new City();
            FormCity formCity = new FormCity(city);
            formCity.ShowDialog();
            Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVcity.DataSource = DBObjects.Entities.City.Where(c => c.Title_city == txtSearch.Text).ToList();
            }
            else
            {
                DGVcity.DataSource = DBObjects.Entities.City.ToList();
            }
        }
    }
}
