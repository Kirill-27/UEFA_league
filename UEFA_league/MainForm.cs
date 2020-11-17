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
using UEFA_league.Forms;

namespace UEFA_league
{
    public partial class MainForm : Form
    {

        const string ConnectionString = @"Data Source = 
        KIRILL_COMP\SQLEXPRESS;Initial Catalog = 
        UEFA_league; Integrated Security = True";
        const string pl = "Players";
        const string ju = "Judges";
        const string ma = "Matches";
        const string te = "Teams";
        const string st = "Stadiums";

        private void saveData()
        {
            stadiumsTableAdapter.Update(uEFA_leagueDataSet);
            judgesTableAdapter.Update(uEFA_leagueDataSet);
            teamsTableAdapter.Update(uEFA_leagueDataSet);
            playersTableAdapter.Update(uEFA_leagueDataSet);
            matchesTableAdapter.Update(uEFA_leagueDataSet);
        }
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.stadiums". При необходимости она может быть перемещена или удалена.
            this.stadiumsTableAdapter.Fill(this.uEFA_leagueDataSet.stadiums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.judges". При необходимости она может быть перемещена или удалена.
            this.judgesTableAdapter.Fill(this.uEFA_leagueDataSet.judges);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.matches". При необходимости она может быть перемещена или удалена.
            this.matchesTableAdapter.Fill(this.uEFA_leagueDataSet.matches);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.uEFA_leagueDataSet.teams);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.uEFA_leagueDataSet.players);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search1_but.Text = "Surname";
            search2_but.Text = "Number";
            search3_but.Text = "By all text fields";
            filter1_button.Text = "Age";
            filter2_button.Text = "Salary";
            bindingNavigator1.BindingSource = playersBindingSource; 
            dataGridView1.DataSource = playersBindingSource; 
            lable_table_name.Text = pl;
            sortToolStripMenuItem.Text = "Sort players";
            byIdToolStripMenuItem.Text = "By id";
            byTeamAndNumberToolStripMenuItem.Text = "By team and number";
            bySurnameToolStripMenuItem.Text = "By surname";
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = teamsBindingSource;
            dataGridView1.DataSource = teamsBindingSource;
            lable_table_name.Text = te;
        }

        private void stadiumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = stadiumsBindingSource;
            dataGridView1.DataSource = stadiumsBindingSource;
            lable_table_name.Text = st;
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search1_but.Text = "Team name";
            search2_but.Text = "Judge name";
            search3_but.Text = "";
            filter1_button.Text = "Total goals";
            filter2_button.Text = "Total cards";
            bindingNavigator1.BindingSource = matchesBindingSource;
            dataGridView1.DataSource = matchesBindingSource;
            lable_table_name.Text = ma;
            sortToolStripMenuItem.Text = "Sort matches";
            byIdToolStripMenuItem.Text = "By id";
            byTeamAndNumberToolStripMenuItem.Text = "By attendance";
            bySurnameToolStripMenuItem.Text = "By date";
        }

        private void judgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search1_but.Text = "Full name";
            search2_but.Text = "Nationality";
            search3_but.Text = "By all text fields";
            filter1_button.Text = "Age";
            filter2_button.Text = "Salary";
            bindingNavigator1.BindingSource = judgesBindingSource;
            dataGridView1.DataSource = judgesBindingSource;
            lable_table_name.Text = ju;
            sortToolStripMenuItem.Text = "Sort judges";
            byIdToolStripMenuItem.Text = "By id";
            byTeamAndNumberToolStripMenuItem.Text = "By age";
            bySurnameToolStripMenuItem.Text = "By salary per match";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void distributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pl = new Players();
            pl.ShowDialog();
            playersTableAdapter.Fill(uEFA_leagueDataSet.players);
            teamsTableAdapter.Fill(uEFA_leagueDataSet.teams);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qu = new QueryEdit();
            qu.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                var addP = new EditPlayer();
                addP.ShowDialog();
                playersTableAdapter.Fill(uEFA_leagueDataSet.players);
                uEFA_leagueDataSet.AcceptChanges();
            }
            if (lable_table_name.Text == ma)
            {
                var addM = new EditMatch();
                addM.ShowDialog();
                matchesTableAdapter.Fill(uEFA_leagueDataSet.matches);
                uEFA_leagueDataSet.AcceptChanges();
            }
            if (lable_table_name.Text == ju)
            {
                var addJ = new EditJudge();
                addJ.ShowDialog();
                judgesTableAdapter.Fill(uEFA_leagueDataSet.judges);
                uEFA_leagueDataSet.AcceptChanges();
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                var st = new UEFA_leagueDataSet.playersDataTable();
                playersTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditPlayer(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    Convert.ToInt32(row[3]),
                    Convert.ToInt32(row[4]),
                    row[5].ToString(),
                    Convert.ToInt32(row[6]),
                    Convert.ToInt32(row[7]));
                edt.ShowDialog();
                playersTableAdapter.Fill(uEFA_leagueDataSet.players);
                uEFA_leagueDataSet.AcceptChanges();
            }
            if (lable_table_name.Text == ma)
            {
                var st = new UEFA_leagueDataSet.matchesDataTable();
                matchesTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditMatch(
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToInt32(row[2]),
                    Convert.ToInt32(row[3]),
                    Convert.ToDateTime(row[4]),
                    Convert.ToInt32(row[5]),
                    Convert.ToInt32(row[6]),
                    Convert.ToInt32(row[7]),
                    Convert.ToInt32(row[8]),
                    row[9].ToString(),
                    row[10].ToString(),
                    Convert.ToInt32(row[11]),
                    Convert.ToBoolean(row[12]));
                edt.ShowDialog();
                matchesTableAdapter.Fill(uEFA_leagueDataSet.matches);
                uEFA_leagueDataSet.AcceptChanges();
            }
            if (lable_table_name.Text == ju)
            {
                var st = new UEFA_leagueDataSet.judgesDataTable();
                judgesTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditJudge(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    Convert.ToDateTime(row[2]),
                    row[3].ToString(),
                    Convert.ToInt32(row[4]),
                    Convert.ToInt32(row[5]),
                    row[6].ToString());
                edt.ShowDialog();
                judgesTableAdapter.Fill(uEFA_leagueDataSet.judges);
                uEFA_leagueDataSet.AcceptChanges();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                string st = "";
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    st += Convert.ToString(dataGridView1.SelectedRows[i].Cells[0].Value);
                    st += " ";
                }
                var result = MessageBox.Show(
                    $"Are you sure about deleting rows with id {st}?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    playersTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                }
                playersTableAdapter.Fill(uEFA_leagueDataSet.players);
                uEFA_leagueDataSet.AcceptChanges();
            }
            if (lable_table_name.Text == ma)
            {
                string st = "";
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    st += Convert.ToString(dataGridView1.SelectedRows[i].Cells[0].Value);
                    st += " ";
                }
                var result = MessageBox.Show(
                    $"Are you sure about deleting rows with id {st}?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    matchesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                }
                matchesTableAdapter.Fill(uEFA_leagueDataSet.matches);
                uEFA_leagueDataSet.AcceptChanges();
            }
            if (lable_table_name.Text == ju)
            {
                string st = "";
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    st += Convert.ToString(dataGridView1.SelectedRows[i].Cells[0].Value);
                    st += " ";
                }
                var result = MessageBox.Show(
                    $"Are you sure about deleting rows with id {st}?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
                {
                    judgesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                }
                judgesTableAdapter.Fill(uEFA_leagueDataSet.judges);
                uEFA_leagueDataSet.AcceptChanges();
            }
        }

        private void byTeamAndNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                dataGridView1.DataSource = playersTableAdapter.OrderPlayerByTeam();
            }
            if (lable_table_name.Text == ma)
            {
                dataGridView1.DataSource = matchesTableAdapter.OrderByAttendance();
            }
            if (lable_table_name.Text == ju)
            {
                dataGridView1.DataSource = judgesTableAdapter.OrderByAge();
            }
        }

        private void byAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                dataGridView1.DataSource = playersBindingSource;
                bindingNavigator1.BindingSource = playersBindingSource;
            }
            if (lable_table_name.Text == ma)
            {
                dataGridView1.DataSource = matchesBindingSource;
                bindingNavigator1.BindingSource = matchesBindingSource;
            }
            if (lable_table_name.Text == ju)
            {
                dataGridView1.DataSource = judgesBindingSource;
                bindingNavigator1.BindingSource = judgesBindingSource;
            }

        }

        private void bySurnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                dataGridView1.DataSource = playersTableAdapter.OrderBySurname();
            }
            if (lable_table_name.Text == ma)
            {
                dataGridView1.DataSource = matchesTableAdapter.OrderByDate();
            }
            if (lable_table_name.Text == ju)
            {
                dataGridView1.DataSource = judgesTableAdapter.OrderBySalary();
            }
        }

        private void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sortP = new PlayersSort();
            sortP.ShowDialog();
        }

        

        private void filter1_button_Click(object sender, EventArgs e)
        {
            if (lable_table_name.Text == pl)
            {
                try
                {
                    int f1 = Convert.ToInt32(filter_st1.Text),
                    f2 = Convert.ToInt32(filter_fn1.Text);
                    dataGridView1.DataSource = playersTableAdapter.FilterAge(f1, f2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ju)
            {
                try
                {
                    int f1 = Convert.ToInt32(filter_st1.Text),
                    f2 = Convert.ToInt32(filter_fn1.Text);
                    dataGridView1.DataSource = judgesTableAdapter.AgeFilter(f1, f2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ma)
            {
                try
                {
                    int f1 = Convert.ToInt32(filter_st1.Text),
                    f2 = Convert.ToInt32(filter_fn1.Text);
                    dataGridView1.DataSource = matchesTableAdapter.TotalGoalFilter(f1,f2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void filter2_button_Click(object sender, EventArgs e)
        {
            if(lable_table_name.Text == pl)
            {
                try
                {
                    int f1 = Convert.ToInt32(filter_st1.Text),
                    f2 = Convert.ToInt32(filter_fn1.Text);
                    dataGridView1.DataSource = playersTableAdapter.SalaryFilter(f1, f2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ju)
            {
                try
                {
                    int f1 = Convert.ToInt32(filter_st1.Text),
                    f2 = Convert.ToInt32(filter_fn1.Text);
                    dataGridView1.DataSource = judgesTableAdapter.SalaryFilter(f1, f2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ma)
            {
                try
                {
                    int f1 = Convert.ToInt32(filter_st1.Text),
                    f2 = Convert.ToInt32(filter_fn1.Text);
                    dataGridView1.DataSource = matchesTableAdapter.TotalCardFilter(f1, f2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = "%";
            r += SearchTextbox.Text;
            r += "%";
            if (lable_table_name.Text == pl)
            {
                try
                {
                    dataGridView1.DataSource = playersTableAdapter.SurnameSeatch(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ju)
            {
                try
                {
                    dataGridView1.DataSource = judgesTableAdapter.FullNameSearch(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ma)
            {
                try
                {
                    dataGridView1.DataSource = matchesTableAdapter.TeamSearch(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r = "%";
            r += SearchTextbox.Text;
            r += "%";
            if (lable_table_name.Text == pl)
            {
                try
                {
                    dataGridView1.DataSource =
                        playersTableAdapter.NumberSearch(Convert.ToInt32(SearchTextbox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ju)
            {
                try
                {
                    dataGridView1.DataSource = judgesTableAdapter.NationSearch(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ma)
            {
                try
                {
                    dataGridView1.DataSource = matchesTableAdapter.JudgeNameSearch(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r = "%";
            r += SearchTextbox.Text;
            r += "%";
            if (lable_table_name.Text == pl)
            {
                try
                {
                    dataGridView1.DataSource = playersTableAdapter.AllFieldSearch(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            if (lable_table_name.Text == ju)
            {
                try
                {
                    dataGridView1.DataSource = judgesTableAdapter.AllField(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }
    }
}
