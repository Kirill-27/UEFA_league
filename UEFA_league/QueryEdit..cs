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

namespace UEFA_league
{
    public partial class QueryEdit : Form
    {
        const string ConnectionString = @"Data Source = 
        KIRILL_COMP\SQLEXPRESS;Initial Catalog = 
        UEFA_league; Integrated Security = True";
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void DoSQLbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            TestInput.Clear(); 
            TestInput.Text = "SELECT";
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }     
    }
}
