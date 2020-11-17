using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEFA_league.Forms
{
    public partial class EditJudge : Form
    {
        private readonly int id;
        /// true - если запись модифицируется, false - если создаѐтся новая  
        readonly bool edit;
        
        public EditJudge()
        {
            InitializeComponent();
            judgesTableAdapter1.Fill(uEFA_leagueDataSet.judges);
            edit = false;
            judge_id_label.Text = Convert.ToString
                (Convert.ToInt32(judgesTableAdapter1.ScalarQuery()) + 1);
        }

        public EditJudge(int judge_id,
            string full_name ,
	        DateTime work_beginning ,
	        string nationality ,
	        int age,
            int salary_per_match,
            string category)
        {
            InitializeComponent();
            judgesTableAdapter1.Fill(uEFA_leagueDataSet.judges);
            judge_id_label.Text = Convert.ToString(judge_id);
            edit = true;
            id = judge_id;
            Name_textBox.Text = full_name;
            dateTimePicker1.Value = work_beginning;
            Nationality_textBox.Text = nationality;
            Age_numericUpDown.Value = age;
            Sal_numeric.Value = salary_per_match;
            Category_comboBox.Text = category;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                judgesTableAdapter1.UpdateQuery(id,
                    Name_textBox.Text,
                Convert.ToString(dateTimePicker1.Value),
                Nationality_textBox.Text,
                Convert.ToInt32(Age_numericUpDown.Value),
                Convert.ToInt32(Sal_numeric.Value),
                Category_comboBox.Text);
            }
            else
            {
                judgesTableAdapter1.Insert(
                Convert.ToInt32(judgesTableAdapter1.ScalarQuery()) + 1,
                Name_textBox.Text,
                Convert.ToDateTime(dateTimePicker1.Value),
                Nationality_textBox.Text,
                Convert.ToInt32(Age_numericUpDown.Value),
                Convert.ToInt32(Sal_numeric.Value),
                Category_comboBox.Text);
            }
            Close();
        }
    }
}
