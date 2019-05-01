using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)//exit
        {
            this.Close();
        }

        private void btnTeams_Click(object sender, EventArgs e)//opens modal form about teams in league
        {
            Teams formTeams = new Teams();
            formTeams.ShowDialog(); 
        }

        private void btnPlayers_Click(object sender, EventArgs e)//opens modal form about players in league
        {
            Players formPlayers = new Players();
            formPlayers.ShowDialog(); 
        }

        private void btnStandings_Click(object sender, EventArgs e)//opens modeless form about standings in league
        {
            Standings formStandings = new Standings();
            formStandings.Show();
        }
    }
}
