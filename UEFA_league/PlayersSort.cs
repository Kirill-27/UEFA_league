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
    public partial class PlayersSort : Form
    {
        public PlayersSort()
        {
            InitializeComponent();
        }

        private void PlayersSort_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uEFA_leagueDataSet.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.uEFA_leagueDataSet.players);

        }
    }
}
