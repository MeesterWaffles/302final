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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            Teams formTeams = new Teams();
            formTeams.ShowDialog(); 
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            Players formPlayers = new Players();
            formPlayers.ShowDialog(); 
        }

        private void btnStandings_Click(object sender, EventArgs e)
        {
            Standings formStandings = new Standings();
            formStandings.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
