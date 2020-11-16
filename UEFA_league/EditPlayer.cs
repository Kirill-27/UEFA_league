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
        public EditPlayer()
        {
            InitializeComponent();
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.uEFA_leagueDataSet.teams);

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
