using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Entities;
using BusinessLogicLayer.EntityList;
using BusinessLogicLayer.EntityManager;

namespace UI_Layer
{
    public partial class DV_Form : Form
    {
        TitleList titles;
        BindingSource titleBS;
        PublisherList publishers;
        BindingSource publisherBS;
        BindingNavigator BindNav;

        public DV_Form()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            this.Close();
            landingPage.Show();
        }

        private void DV_Form_Load(object sender, EventArgs e)
        {
            titles = TitleManager.ShowData();
            titleBS = new BindingSource(titles, "");

            publishers = PublisherManager.ShowPublisherData();
            publisherBS = new BindingSource(publishers, "");
            pubComboBox.DataSource = publisherBS;
            pubComboBox.DisplayMember = "pub_name";
            pubComboBox.ValueMember = "pub_id";

            titleID.DataBindings.Add("Text", titleBS, "title_id", true);
            title.DataBindings.Add("Text", titleBS, "title", true);
            type.DataBindings.Add("Text", titleBS, "type", true);
            pubComboBox.DataBindings.Add("SelectedValue", titleBS, "pub_id", true);
            price.DataBindings.Add("Text", titleBS, "price", true);
            advance.DataBindings.Add("Text", titleBS, "advance", true);
            royal.DataBindings.Add("Value", titleBS, "royalty", true);
            sales.DataBindings.Add("Value", titleBS, "ytd_sales", true);
            notes.DataBindings.Add("Text", titleBS, "notes", true);
            date.DataBindings.Add("Value", titleBS, "pubdate", true);

            BindNav = new BindingNavigator(true);
            this.Controls.Add(BindNav);
            BindNav.Dock = DockStyle.Top;
            BindNav.BindingSource = titleBS;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            TitleManager.InsertNewTitle(titleID.Text, title.Text, type.Text);
            titleBS.EndEdit();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            TitleManager.DeleteTitleById(titleID.Text);
            titleBS.EndEdit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TitleManager.UpdateTitleById(titleID.Text, title.Text, type.Text);
            titleBS.EndEdit();
        }

        
    }
}
