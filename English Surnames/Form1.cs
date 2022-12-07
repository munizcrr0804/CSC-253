/**
* 10/5/2022
* CSC 253
* Ramon Muniz
* E
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
using System.IO;



namespace English_Surnames
{
    public partial class Form1 : Form
    {
        private List<string> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<string>();
            var fileStream = new FileStream("D:/surnames.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
        }

        private void btn_SearchBylengthLonger_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            var searchLength = Convert.ToInt16(textBox1.Text);
            var searchList = list.FindAll(p => p.Length > searchLength).ToList();
            dataGridView1.DataSource = searchList.Select(x => new { Name = x }).ToList();
        }

        private void btnSearchByLengthShorter_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            var searchLength = Convert.ToInt16(textBox2.Text);
            var searchList = list.FindAll(p => p.Length < searchLength).ToList();
            dataGridView1.DataSource = searchList.Select(x => new { Name = x }).ToList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            var searchName = textBox3.Text;
            var searchList = list.FindAll(p => p.Contains(searchName));
            dataGridView1.DataSource = searchList.Select(x => new { Name = x }).ToList();
        }
    }
}
