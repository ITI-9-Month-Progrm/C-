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
        SqlCommand sqlCmd, sqlCmdInsert, sqlCmdUpdate, sqlCmdDelete;
        SqlDataAdapter DA;
        DataTable titleDataTable;
        BindingSource BS;

        private void btnInsert_Click(object sender, EventArgs e)
        {

            sqlCmdInsert.Parameters.AddWithValue("@id", txtID.Text);
            sqlCmdInsert.Parameters.AddWithValue("@title", txtTitle.Text);
            sqlCmdInsert.Parameters.AddWithValue("@type", txtType.Text);
            DA.InsertCommand = sqlCmdInsert;
            MessageBox.Show("Added");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            sqlCmdUpdate.Parameters.AddWithValue("@id", txtID.Text);
            sqlCmdUpdate.Parameters.AddWithValue("@title", txtTitle.Text);
            sqlCmdUpdate.Parameters.AddWithValue("@type", txtType.Text);
            DA.UpdateCommand = sqlCmdUpdate;
            MessageBox.Show("Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlCmdDelete.Parameters.AddWithValue("@deletedID", txtID.Text);
            DA.DeleteCommand = sqlCmdDelete;
            MessageBox.Show("Deleted");
        }

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
            //Binding El Data

            txtID.DataBindings.Add("Text", BS, "title_id");
            txtTitle.DataBindings.Add("Text", BS, "title");
            txtType.DataBindings.Add("Text", BS, "type");
            txtPubName.DataBindings.Add("Text", BS, "pub_name");
            txtPrice.DataBindings.Add("Text", BS, "price");
            txtAdv.DataBindings.Add("Text", BS, "advance");
            txtRoy.DataBindings.Add("Text", BS, "royalty");
            txtSales.DataBindings.Add("Text", BS, "ytd_sales");
            txtNote.DataBindings.Add("Text", BS, "notes");
            dateTimePicker1.DataBindings.Add("Text", BS, "pubdate");

            //Insert, Update, Delete Commends
            sqlCmdInsert = new SqlCommand("insertNewData", sqlCon);
            sqlCmdInsert.CommandType = CommandType.StoredProcedure;

            sqlCmdUpdate = new SqlCommand("updateByID", sqlCon);
            sqlCmdUpdate.CommandType = CommandType.StoredProcedure;

            sqlCmdDelete = new SqlCommand("deleteDataFromTitle", sqlCon);
            sqlCmdDelete.CommandType = CommandType.StoredProcedure;



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BS.EndEdit();
            DA.Update(titleDataTable);
        }
    }
}
