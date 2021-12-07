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
    public partial class FormWorkerTab : Form
    {
        public FormWorkerTab()
        {
            InitializeComponent();
            this.Fill();
        }
        private void Fill()
        {
            DGVworker.DataSource = DBObjects.Entities.Worker.ToList();
            this.DGVworker.Columns["Orders"].Visible = false;
            this.DGVworker.Columns["Code_worker"].Visible = false;
        }
        private void DGVworker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker worker = (Worker)DGVworker.Rows[e.RowIndex].DataBoundItem;
            FormWorker formWorker = new FormWorker(worker);
            formWorker.ShowDialog();
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrderTab formOrder = new FormOrderTab();
            formOrder.ShowDialog();
            this.Close();
        }
        private void btnWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            FormWorker formWorker = new FormWorker(worker);
            formWorker.ShowDialog();
            Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DGVworker.DataSource = DBObjects.Entities.Worker.Where(c => c.Familia_worker == txtSearch.Text).ToList();
            }
            else
            {
                DGVworker.DataSource = DBObjects.Entities.Worker.ToList();
            }
        }
    }
}
