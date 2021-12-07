using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class FormClientTab : Form
    {
        public FormClientTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVclient.DataSource = DBObjects.Entities.Client.ToList();
            this.DGVclient.Columns["Orders"].Visible = false;
            this.DGVclient.Columns["Code_client"].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            FormClient formClient = new FormClient(client);
            formClient.ShowDialog();
            Fill();
        }

        private void DGVclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = (Client)DGVclient.Rows[e.RowIndex].DataBoundItem;
            FormClient formClient = new FormClient(client);
            formClient.ShowDialog();
            Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVclient.DataSource = DBObjects.Entities.Client.Where(c => c.Familia_client == txtSearch.Text).ToList();
            }
            else
            {
                DGVclient.DataSource = DBObjects.Entities.Client.ToList();
            }
        }
    }
}
