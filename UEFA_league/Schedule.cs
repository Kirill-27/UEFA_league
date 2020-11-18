using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEFA_league
{
    public partial class Schedule : Form
    {
        private void InsertMatch(int team1, int team2, DateTime match_date, int judge)
        {
            matchesTableAdapter1.Insert(
                 Convert.ToInt32(matchesTableAdapter1.ScalarQuery()) + 1,
                 team1, team2, judge, match_date, 0,
                 0, 0, 0, "Group Stade", "", 0, false);
        }
        private void ScheduleForGroupe(
            List<int> Teams, DateTime firstMatch, List<int> Judges)
        {
            int days = 7;
            const int deltaDays = 7;
            InsertMatch(Teams[0], Teams[1], firstMatch, Judges[0]);
            InsertMatch(Teams[2], Teams[3], firstMatch, Judges[1]);
            
            InsertMatch(Teams[1], Teams[2], firstMatch.AddDays(days), Judges[0]);
            InsertMatch(Teams[3], Teams[0], firstMatch.AddDays(days), Judges[1]);
            days += deltaDays;
            InsertMatch(Teams[1], Teams[3], firstMatch.AddDays(days), Judges[0]);
            InsertMatch(Teams[2], Teams[0], firstMatch.AddDays(days), Judges[1]);
            days += deltaDays;
            InsertMatch(Teams[3], Teams[1], firstMatch.AddDays(days), Judges[0]);
            InsertMatch(Teams[0], Teams[2], firstMatch.AddDays(days), Judges[1]);
            days += deltaDays;
            InsertMatch(Teams[2], Teams[1], firstMatch.AddDays(days), Judges[0]);
            InsertMatch(Teams[0], Teams[3], firstMatch.AddDays(days), Judges[1]);
            days += deltaDays;
            InsertMatch(Teams[1], Teams[0], firstMatch.AddDays(days), Judges[0]);
            InsertMatch(Teams[3], Teams[2], firstMatch.AddDays(days), Judges[1]);
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
            List<int> Teams_id = new List<int>();
            List<int> Judges_id = new List<int>();
            Teams_id.Add(Convert.ToInt32(comboBox1.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox2.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox3.SelectedValue));
            Teams_id.Add(Convert.ToInt32(comboBox4.SelectedValue));
            Judges_id.Add(1);
            Judges_id.Add(2);
            ScheduleForGroupe(Teams_id, DateTime.Now, Judges_id);
            string st = "";
            for(int i = 0; i < Teams_id.Count();i++)
            {
                st += Convert.ToString(Teams_id[i]);
                st += " ";
            }
            MessageBox.Show(st);
        }
    }
}
