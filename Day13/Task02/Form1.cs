using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class DVForm : Form
    {
        public DVForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable titleDataTable;
        BindingSource BS;
        BindingNavigator BNav;
        private void DVForm_Load(object sender, EventArgs e)
        {
            
            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=.; Initial Catalog=pubs; Integrated Security=true;";
            sqlCmd = new SqlCommand("SelectAllTitle", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            DA = new SqlDataAdapter(sqlCmd);
            titleDataTable = new DataTable();
            DA.Fill(titleDataTable);
            BS = new BindingSource(titleDataTable, "");
            BNav = new BindingNavigator(true);
            this.Controls.Add(BNav);
            BNav.Dock = DockStyle.Top;
            BNav.BindingSource = BS;



            txtID.DataBindings.Add("Text", BS, "title_id");
            txtTitle.DataBindings.Add("Text", BS, "title");
            txtType.DataBindings.Add("Text", BS, "type");
            txtPubName.DataBindings.Add("Text", BS, "pub_name");
            txtPrice.DataBindings.Add("Text", BS, "price");
            txtAdv.DataBindings.Add("Text", BS, "advance");
            txtRoy.DataBindings.Add("Text", BS, "royalty");
            txtSales.DataBindings.Add("Text", BS, "ytd_sales");
            txtNote.DataBindings.Add("Text", BS, "notes");
            txtDate.DataBindings.Add("Text", BS, "pubdate");


            







        }
    }
}
