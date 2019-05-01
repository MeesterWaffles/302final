using System;
using System.IO;
using System.Windows.Forms;

namespace SportsProject
{
    public partial class MainForm : Form
    {
        /* This main form serves only as a sort of launcher for others forms. The user can
         * choose to launch the players, teams, or team standings forms. There is also an
         * exit button.
         */
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            //this will avoid an exception caused by no teams being created yet
            if(!File.Exists("teamsdata.json")) File.Create("teamsdata.json").Dispose();

            //Shows the teams form
            Teams formTeams = new Teams();
            formTeams.ShowDialog(); 
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            //Shows the players form
            Players formPlayers = new Players();
            formPlayers.ShowDialog(); 
        }

        private void btnStandings_Click(object sender, EventArgs e)
        {
            //Shows the standings form
            Standings formStandings = new Standings();
            formStandings.ShowDialog();
        }

    }
}
