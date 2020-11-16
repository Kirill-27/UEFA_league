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
    public partial class EditPlayer : Form
    { 
        private readonly int id;

        /// true - если запись модифицируется, false - если создаѐтся новая  
        readonly bool edit;
       
        public EditPlayer()
        {
            InitializeComponent();
            playersTableAdapter1.Fill(uEFA_leagueDataSet.players);
            teamsTableAdapter.Fill(uEFA_leagueDataSet.teams);
            edit = false;
            player_id_label.Text = Convert.ToString
               (Convert.ToInt32(playersTableAdapter1.ScalarQuery()) + 1);
        }
        public EditPlayer(int player_id, string name, string surname, int number,
            int age, string nationality, int team_id , int salary)
        {
            InitializeComponent();
            teamsTableAdapter.Fill(uEFA_leagueDataSet.teams);
            playersTableAdapter1.Fill(uEFA_leagueDataSet.players);
            Team_comboBox.SelectedValue = team_id;
            player_id_label.Text = Convert.ToString(player_id);
            edit = true;
            id = player_id;
            Name_textBox.Text = name;
            Surname_textBox.Text = surname;
            Number_numericUpDown.Value = number;
            Age_numericUpDown.Value = age;
            Nationality_textBox.Text = nationality;
            Sal_numeric.Value = salary;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                playersTableAdapter1.UpdateQuery(id,
                    Name_textBox.Text,
                Surname_textBox.Text,
                Convert.ToInt32(Number_numericUpDown.Value),
                Convert.ToInt32(Age_numericUpDown.Value),
                Nationality_textBox.Text,
                Convert.ToInt32(Team_comboBox.SelectedValue),
                Sal_numeric.Value);
            }
            else
            {
                playersTableAdapter1.Insert(
                Convert.ToInt32(playersTableAdapter1.ScalarQuery()) + 1,
                Name_textBox.Text,
                Surname_textBox.Text,
                Convert.ToInt32(Number_numericUpDown.Value),
                Convert.ToInt32(Age_numericUpDown.Value),
                Nationality_textBox.Text,
                Convert.ToInt32(Team_comboBox.SelectedValue),
                Sal_numeric.Value);
            }
            Close();
        }
    }
}
