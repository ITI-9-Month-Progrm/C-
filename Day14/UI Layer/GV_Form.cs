using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.Entities;
using BusinessLogicLayer.EntityList;
using BusinessLogicLayer.EntityManager;

namespace UI_Layer
{
    public partial class GV_Form : Form
    {
        // Data Used
        private string titleID;
        private TitleList titles;
        private BindingSource titlesBS;
        private PublisherList publishers;
        private BindingSource publisherBS;
        DataGridViewComboBoxColumn dgvComboBoxCol;

        //Functions Used
        public GV_Form()
        {
            InitializeComponent();
        }

        private void btnHomeFromGV_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            this.Close();
            landingPage.Show();
        }
    
        // Show Data
        private void GV_Form_Load(object sender, EventArgs e)
        {
            titles = TitleManager.ShowData();
            titlesBS = new BindingSource(titles, "");
            dgvTitle.DataSource = titlesBS;
            publishers = PublisherManager.ShowPublisherData();
            publisherBS = new BindingSource(publishers, "");
            dgvComboBoxCol = new DataGridViewComboBoxColumn();
            dgvComboBoxCol.DataSource = publisherBS;
            dgvComboBoxCol.HeaderText = "Publisher";
            dgvComboBoxCol.DisplayMember = "pub_name";
            dgvComboBoxCol.ValueMember = "pub_id";
            dgvComboBoxCol.DataPropertyName = "pub_id";
            dgvTitle.Columns.Add(dgvComboBoxCol);
            dgvTitle.Columns["pub_id"].Visible = false;
            dgvTitle.Columns["State"].Visible = false;
        }

        // Delete Item
        private void dgvTitle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            titleID = dgvTitle.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Recorde", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool res = TitleManager.DeleteTitleById(titleID);
                    if (res)
                    {MessageBox.Show("Deleted succeeded"); }
                    else { MessageBox.Show("Deleted Failed"); }


                    }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTitle.EndEdit();
            foreach(var item in titles)
            {
                Trace.WriteLine(item.title_id +  item.State);
               if(item.State == EntityState.Added)
                {
                    TitleManager.InsertNewTitle(item.title_id, item.title, item.type);
                }
               if(item.State == EntityState.Modified)
                {
                    TitleManager.UpdateTitleById(item.title_id, item.title, item.type);
                }
            }
            MessageBox.Show("Data Saved Successfully!", "Save",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
