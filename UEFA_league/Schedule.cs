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

namespace UEFA_league
{
    public partial class Schedule : Form
    {
        const string ConnectionString = @"Data Source = 
        KIRILL_COMP\SQLEXPRESS;Initial Catalog = 
        UEFA_league; Integrated Security = True";
        private void InsertMatch(int team1, int team2, DateTime match_date)
        {
            string queryText = "";
            string matchDate = "";
            string curent = Convert.ToString(match_date);
            for (int i = 0; i < curent.Length; i++)
            {
                if (curent[i] == ' ')
                {
                    break;
                }
                else matchDate += curent[i];
            }
            queryText = $@"SELECT judges.judge_id, COUNT(match_id)  
                    FROM judges
                    LEFT JOIN MATCHES
                    ON judges.judge_id = matches.judge_id
                    GROUP BY judges.judge_id, salary_per_match
                    HAVING judges.judge_id
                    NOT IN
                    (SELECT judges.judge_id FROM judges LEFT JOIN MATCHES ON judges.judge_id = matches.judge_id
                    WHERE match_date = '{matchDate}')
                    ORDER BY COUNT(match_id), salary_per_match; ";
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(queryText, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
                int judge =Convert.ToInt32( dataGridView1.Rows[0].Cells[0].Value);


                matchesTableAdapter1.Insert(
                 Convert.ToInt32(matchesTableAdapter1.ScalarQuery()) + 1,
                 team1, team2, judge, match_date, 0,
                 0, 0, 0, "Group Stade", "", 0, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }
        private void ScheduleForGroupe(
            List<int> Teams, DateTime firstMatch)
        {
            int days = 7;
            const int deltaDays = 7;
            InsertMatch(Teams[0], Teams[1], firstMatch);
            InsertMatch(Teams[2], Teams[3], firstMatch);
            
            InsertMatch(Teams[1], Teams[2], firstMatch.AddDays(days));
            InsertMatch(Teams[3], Teams[0], firstMatch.AddDays(days));
            days += deltaDays;
            InsertMatch(Teams[1], Teams[3], firstMatch.AddDays(days));
            InsertMatch(Teams[2], Teams[0], firstMatch.AddDays(days));
            days += deltaDays;
            InsertMatch(Teams[3], Teams[1], firstMatch.AddDays(days));
            InsertMatch(Teams[0], Teams[2], firstMatch.AddDays(days));
            days += deltaDays;
            InsertMatch(Teams[2], Teams[1], firstMatch.AddDays(days));
            InsertMatch(Teams[0], Teams[3], firstMatch.AddDays(days));
            days += deltaDays;
            InsertMatch(Teams[1], Teams[0], firstMatch.AddDays(days));
            InsertMatch(Teams[3], Teams[2], firstMatch.AddDays(days));
        }
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet1.judges". При необходимости она может быть перемещена или удалена.
            this.judgesTableAdapter.Fill(this.uEFA_leagueDataSet1.judges);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.uEFA_leagueDataSet.teams);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(judgesTableAdapter.CountJudes()<4)
            {
                MessageBox.Show("Too few judges to schedule");
                return;
            }

            List<int> Teams_id = new List<int>
            {
                Convert.ToInt32(comboBox1.SelectedValue),
                Convert.ToInt32(comboBox2.SelectedValue),
                Convert.ToInt32(comboBox3.SelectedValue),
                Convert.ToInt32(comboBox4.SelectedValue),
                Convert.ToInt32(comboBox5.SelectedValue),
                Convert.ToInt32(comboBox6.SelectedValue),
                Convert.ToInt32(comboBox7.SelectedValue),
                Convert.ToInt32(comboBox8.SelectedValue)
            };
            Teams_id.Sort();
            for(int i=1;i<Teams_id.Count();i++)
            {
                if(Teams_id[i]==Teams_id[i-1])
                {
                    MessageBox.Show($"Eror: more then one team_id with value {Teams_id[i]}");
                    return;
                }
            }
            Teams_id.Clear();

            Teams_id.Add(Convert.ToInt32(comboBox1.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox2.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox3.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox4.SelectedValue));
           
            ScheduleForGroupe(Teams_id, dateTimePicker1.Value);
           
            Teams_id.Clear();
            
            Teams_id.Add(Convert.ToInt32(comboBox5.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox6.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox7.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox8.SelectedValue));
            
            ScheduleForGroupe(Teams_id, dateTimePicker1.Value);
            MessageBox.Show("The schedule was completed successfully");
            button1.Visible = false;
        }
    }
}
