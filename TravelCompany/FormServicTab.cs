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
    public partial class FormServicTab : Form
    {
        public FormServicTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVservic.DataSource = DBObjects.Entities.Servic.ToList();
            this.DGVservic.Columns["Additional_feature"].Visible = false;
            this.DGVservic.Columns["Code_service"].Visible = false;
        }

        private void DGVservic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Servic servic = (Servic)DGVservic.Rows[e.RowIndex].DataBoundItem;
            FormServic formServic = new FormServic(servic);
            formServic.ShowDialog();
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Servic servic = new Servic();
            FormServic formServic = new FormServic(servic);
            formServic.ShowDialog();
            Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVservic.DataSource = DBObjects.Entities.Servic.Where(c => c.Title_service == txtSearch.Text).ToList();
            }
            else
            {
                DGVservic.DataSource = DBObjects.Entities.Servic.ToList();
            }
        }
    }
}
