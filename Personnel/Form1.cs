/**
* 9/14/2022
* CSC 253
* Ramon Muniz
* Personal Database
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personnel
{
    public partial class Personal : Form
    {

        string connectionString = "";
        SqlConnection connection = null;
        DataSet dataSet = null;
        SqlCommand command = null;
        DataTable dataTable = null;
        SqlDataAdapter adapter = null;
        SqlCommandBuilder builder = null;
        
        public Personal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            try
            {
                connectionString = "Data Source=.; Initial Catalog = pubs; Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database cannot be opened!");
            }
        
        
        }

        private void loadButton_Click_Click(object sender, EventArgs e)
        {
            string comm = "SELECT * FROM Employee";
            command = new SqlCommand(comm, connection);
            adapter = new SqlDataAdapter(command);
            builder = new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Employee");
            dataTable = dataSet.Tables["Employee"];
            connection.Close();
            dataGridView1.DataSource = dataSet.Tables["Employee"];
            dataGridView1.ReadOnly = true;
            saveButton.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            saveButton.Enabled = true;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            saveButton.Enabled = true;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            adapter.Update(dataTable);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            adapter.Update(dataTable);
            dataGridView1.ReadOnly = true;
            saveButton.Enabled = false;
            addButton.Enabled = false;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }
    }
}