using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Product> products = new List<Product>();

        private void Form1_Load(object sender, EventArgs e)

        {

            // Define your connection string

            string str = @"Persist Security Info=False;Integrated Security=true;Initial Catalog=Reporting;server=(local)";

            // Create connection object

            SqlConnection con = new SqlConnection(str);

            try

            {

                // Sql command to retrieve details from Product table

                string com = "Select * from Product";

                // Use dataset

                SqlDataAdapter adpt = new SqlDataAdapter(com, con);

                DataSet myDataSet = new DataSet();

                adpt.Fill(myDataSet, "ProductDetails");

                DataTable myDataTable = myDataSet.Tables[0];

                // go through all the rows

                foreach (DataRow row in myDataTable.Rows)

                {

                    // Create new object and add it to list

                    products.Add(new Product(row["Product_Number"].ToString(), row["Description"].ToString(), int.Parse(row["Units_On_Hand"].ToString()),

                    double.Parse(row["Price"].ToString())));

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error:" + ex.Message);

            }

            finally

            {

                con.Close();

            }

        }

        private void btnViewByNumber_Click(object sender, EventArgs e)

        {

            // Use LINQ to filter the results

            var results = products.Where(x => x.ProductNumber.ToLower() == txtProductNumber.Text.Trim().ToLower());

            // display the results in the results textbox

            txtResults.Text = ""; // clear any previous results

            foreach (Product product in results)

            {

                txtResults.Text += product.ToString() + "\n";

            }

        }

        private void btnViewByDesc_Click(object sender, EventArgs e)

        {

            // Use LINQ to filter the results

            var results = products.Where(x => x.ProductNumber.ToLower().Contains(txtProductNumber.Text.Trim().ToLower()));

            // display the results in the results textbox

            txtResults.Text = ""; // clear any previous results

            foreach (Product product in results)

            {

                txtResults.Text += product.ToString() + Environment.NewLine;

            }

        }

    }

}