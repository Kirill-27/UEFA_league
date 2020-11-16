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
    public partial class EditMatch : Form
    {
        private readonly int id;
        /// true - если запись модифицируется, false - если создаѐтся новая  
        readonly bool edit;
        public EditMatch()
        {
            InitializeComponent();
            matchesTableAdapter1.Fill(uEFA_leagueDataSet.matches);
            teamsTableAdapter.Fill(uEFA_leagueDataSet.teams);
            judgesTableAdapter.Fill(uEFA_leagueDataSet.judges);
            edit = false;
            Match_id_label.Text = Convert.ToString
                (Convert.ToInt32(matchesTableAdapter1.ScalarQuery()) + 1);
        }

        public EditMatch(int match_id, int host_team_id, int guest_team_id,
            int judge_id, DateTime date, int host_goals, int guest_goals,
            int host_card, int guest_card, string stage, string weather,
            int attendance , bool was_played)
        {
            InitializeComponent();
            matchesTableAdapter1.Fill(uEFA_leagueDataSet.matches);
            teamsTableAdapter.Fill(uEFA_leagueDataSet.teams);
            judgesTableAdapter.Fill(uEFA_leagueDataSet.judges);
            Match_id_label.Text = Convert.ToString(match_id);
            edit = true;
            id = match_id;
            host_team_comboBox.SelectedValue = host_team_id;
            guest_team_comboBox.SelectedValue = guest_team_id;
            judge_comboBox.SelectedValue = judge_id;
            dateTimePicker1.Value = date;
            goal_host_numeric.Value = host_goals;
            goal_gue_numeric.Value = guest_goals;
            card_host_numeric.Value = host_card;
            card_gue_numeric.Value = guest_card;
            stage_comboBox.Text = stage;
            weather_comboBox.Text = weather;
            attendance_numeric.Value = attendance;
            Was_played_checkBox.Checked = was_played;
        }
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditMatch_Load(object sender, EventArgs e)
        {
           
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                matchesTableAdapter1.UpdateQuery(id,
                Convert.ToInt32(host_team_comboBox.SelectedValue),
                Convert.ToInt32(guest_team_comboBox.SelectedValue),
                Convert.ToInt32(judge_comboBox.SelectedValue),
                Convert.ToString(dateTimePicker1.Value),
                Convert.ToInt32(goal_host_numeric.Value),
                Convert.ToInt32(goal_gue_numeric.Value),
                Convert.ToInt32(card_host_numeric.Value),
                Convert.ToInt32(card_gue_numeric.Value),
                stage_comboBox.Text,
                weather_comboBox.Text,
                Convert.ToInt32(attendance_numeric.Value),
                Was_played_checkBox.Checked);
            }
            else
            {
                 matchesTableAdapter1.Insert(
                 Convert.ToInt32(matchesTableAdapter1.ScalarQuery())+1,
                 Convert.ToInt32(host_team_comboBox.SelectedValue),
                 Convert.ToInt32(guest_team_comboBox.SelectedValue),
                 Convert.ToInt32(judge_comboBox.SelectedValue),
                 Convert.ToDateTime(dateTimePicker1.Value),
                 Convert.ToInt32(goal_host_numeric.Value),
                 Convert.ToInt32(goal_gue_numeric.Value),
                 Convert.ToInt32(card_host_numeric.Value),
                 Convert.ToInt32(card_gue_numeric.Value),
                 stage_comboBox.Text,
                 weather_comboBox.Text,
                 Convert.ToInt32(attendance_numeric.Value),
                 Was_played_checkBox.Checked);

            }
            Close();
        }
    }
}
