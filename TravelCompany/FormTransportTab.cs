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
    public partial class FormTransportTab : Form
    {
        public FormTransportTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVtransport.DataSource = DBObjects.Entities.Transport.ToList();
            this.DGVtransport.Columns["Tour"].Visible = false;
            this.DGVtransport.Columns["Code_transport"].Visible = false;
        }
        private void DGVtransport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Transport transport = (Transport)DGVtransport.Rows[e.RowIndex].DataBoundItem;
            FormTransport formTransport = new FormTransport(transport);
            formTransport.ShowDialog();
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            FormTransport formTransport = new FormTransport(transport);
            formTransport.ShowDialog();
            Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVtransport.DataSource = DBObjects.Entities.Transport.Where(c => c.Title_transport == txtSearch.Text).ToList();
            }
            else
            {
                DGVtransport.DataSource = DBObjects.Entities.Transport.ToList();
            }
        }
    }
}
