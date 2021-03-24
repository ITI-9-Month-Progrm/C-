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

namespace Task01
{
    public partial class titelsGridForm : Form
    {
        public titelsGridForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable titleDataTable;
        string id, title, type;
        int flag;

        //Selection
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = "Data Source=.; Initial Catalog=pubs; Integrated Security=true;";
            sqlCmd = new SqlCommand("SelectAllTitle", sqlCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            DA = new SqlDataAdapter(sqlCmd);
            titleDataTable = new DataTable();
            DA.Fill(titleDataTable);
            //one way Binding
            dataGridView1.DataSource = titleDataTable;

            //dataGridView1.Columns[0].ReadOnly = true;


            

        }
        //Update
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            id = currentRow.Cells[0].Value.ToString();
            title = currentRow.Cells[1].Value.ToString();
            type = currentRow.Cells[2].Value.ToString();
            if(id.Length<=6 && title.Length<=80 && type.Length <= 12) {
                if (currentRow != null)
                {

                    sqlCmd = new SqlCommand("updateByID", sqlCn);
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    sqlCmd.Parameters.AddWithValue("@title", title);
                    sqlCmd.Parameters.AddWithValue("@type", type);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    DA.UpdateCommand = sqlCmd;
                    flag = 1;
                }
                else
                {
                  

                }
                
            }
            else
            {
                MessageBox.Show("Please Enter Valid Data");
            }
           
            
        }
        //Deleted Record
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
               if( MessageBox.Show("Are you sure to delete?","Delete Recorde", MessageBoxButtons.YesNo) == DialogResult.Yes){

                    sqlCmd = new SqlCommand("deleteDataFromTitle", sqlCn);
                    sqlCmd.Parameters.AddWithValue("@deletedID", id);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    DA.DeleteCommand = sqlCmd;
                    MessageBox.Show("Deleted " + id);
                }
            }
        }

        //Save Changes
        //Execute Insert Command
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            foreach (DataRow Dr in titleDataTable.Rows)
            {
                switch (Dr.RowState)
                {

                    case DataRowState.Added:
                       insert(Dr);
                        break;
                }

            }
            DA.Update(titleDataTable);

        }
        private void insert(DataRow dataRow)
        {
            try
            {

                sqlCmd = new SqlCommand("insertNewData", sqlCn);

                sqlCmd.Parameters.AddWithValue("@id", dataRow["title_id"]);
                sqlCmd.Parameters.AddWithValue("@title", dataRow["title"]);
                sqlCmd.Parameters.AddWithValue("@type", dataRow["type"]);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                DA.InsertCommand = sqlCmd;


                MessageBox.Show("Added");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //getStudentsData();

            }
        }
    }
}
