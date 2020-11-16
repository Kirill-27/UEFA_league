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
    public partial class MainForm : Form
    {
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
            bindingNavigator1.BindingSource = playersBindingSource; 
            dataGridView1.DataSource = playersBindingSource; 
            lable_table_name.Text = "Players";
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = teamsBindingSource;
            dataGridView1.DataSource = teamsBindingSource;
            lable_table_name.Text = "Teams";
        }

        private void stadiumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = stadiumsBindingSource;
            dataGridView1.DataSource = stadiumsBindingSource;
            lable_table_name.Text = "Stadiums";
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = matchesBindingSource;
            dataGridView1.DataSource = matchesBindingSource;
            lable_table_name.Text = "Matches";
        }

        private void judgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = judgesBindingSource;
            dataGridView1.DataSource = judgesBindingSource;
            lable_table_name.Text = "Judges";
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
            var add = new EditPlayer();
            add.ShowDialog();
        }
    }
}
