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

        private void countPlayersInTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(
                @"SELECT  teams.team_name, COUNT(players.team) AS Expr1
                    FROM  teams  LEFT JOIN  players
                    ON players.team = teams.team_id
                GROUP BY teams.team_name
                ORDER BY teams.team_name", sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void countPlayersNationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(
                @"SELECT  teams.team_name, players.nationality, COUNT(player_id) AS Expr1
                    FROM  players  LEFT JOIN teams
                    ON players.team = teams.team_id
                GROUP BY teams.team_name, players.nationality
                ORDER BY teams.team_name, Expr1 DESC", sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(
                @"SELECT  teams.team_name, AVG(attendance) AS Expr1
                    FROM  matches LEFT JOIN teams
                    ON host_team_id = teams.team_id
                    WHERE was_played = 1
                GROUP BY teams.team_name
                ORDER BY Expr1 DESC", sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void judgesCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(
                @"SELECT  judges.full_name, COUNT(matches.judge_id)* judges.salary_per_match
                    AS Expr1
                    FROM  judges LEFT JOIN matches
                    ON matches.judge_id = judges.judge_id
                GROUP BY judges.full_name, judges.salary_per_match
                ORDER BY Expr1 DESC", sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }
    }
}
