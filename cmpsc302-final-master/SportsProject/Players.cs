using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProject
{
    public partial class Players : Form
    {
        /*
         * This form has a single clickable button that will accept a new player and add
         * it to a list of either active or inactive players. Once a player is added, the
         * list is displayed in the list box
         */
     
        List<PlayerActive> playerListActive = new List<PlayerActive>();
        List<PlayerInactive> playerListInactive = new List<PlayerInactive>();
        List<TeamClass> teamList = new List<TeamClass>();
        public Players() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reads a player front the form and adds it to either the active or inactive player list
            int result;
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            int wins = 0;
            int losses = 0;
            int points = 0;
            int age = 0;
            int active = -1;

            //error checking begin
            if(int.TryParse(txtAge.Text, out result))
            {
                age = int.Parse(txtAge.Text);
                if(age <= 0) {
                    MessageBox.Show("Error: Age must be greater than 0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error: Age is required and must be in numerical format");
                return;
            }

            if ((!int.TryParse(txtWins.Text, out result)) && rbActive.Checked)
            {
                MessageBox.Show("Error: Number of wins must be a number and is required for active player");
                return;
            }
            else if (!(int.TryParse(txtLosses.Text, out result)) && rbActive.Checked)
            {
                MessageBox.Show("Number of losses must be a number and is required for active player");
                return;
            }
            else if (!(int.TryParse(txtPoints.Text, out result)) && rbActive.Checked)
            {
                MessageBox.Show("Error: Number of points must be a number and is required for active player");
                return;
            }
            //error checking end

            if (rbActive.Checked)
            {
                active = 0;
            }
            else if(rbInactive.Checked)
            {
                active = 1;
            }
            switch (active)
            {
                case 0: //active
                    try
                    {
                        PlayerActive pActive = new PlayerActive
                        {
                            fName = fName,
                            lName = lName,
                            Age = age,
                            Wins = wins,
                            Losses = losses,
                            Points = points,
                            Active = true,
                        };
                        playerListActive.Add(pActive);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message);} //exception handling is here. thrown in the PlayerActive class
                    
                    MessageBox.Show("Player " + fName + " " + lName + " has been added to the list of active players");
                    break;
                case 1: //inactive
                    PlayerInactive pInactive = new PlayerInactive
                    {
                        fName = fName,
                        lName = lName,
                        Age = age,
                        Active = false
                    };
                    playerListInactive.Add(pInactive);
                    MessageBox.Show("Player " + fName + " " + lName + " has been added to the list of inactive players");
                    break;
                default:
                    return;
            }
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtWins.Clear();
            txtLosses.Clear();
            txtPoints.Clear();
        }

        private void ShActiveBtn_Click(object sender, EventArgs e)
        {
            //Show all players that are currently active
            listBox1.Items.Clear();
            listBox1.Items.Add("First Name | Last Name | Age | Wins | Losses | Points | Active");
            foreach (PlayerActive pl in playerListActive)
            {
                string s = String.Format("{0,10} | {1,9} | {2,2} | {3,6} | {4,6} | {5,6} ",
                    pl.fName, pl.lName, pl.Age.ToString(), pl.Wins.ToString(), pl.Losses.ToString(),
                    pl.Points.ToString(), pl.Active.ToString());
                listBox1.Items.Add(s);
            }
        }

        private void ShInactiveBtn_Click(object sender, EventArgs e)
        {
            //Show all players that are currently inactive
            listBox1.Items.Clear();
            listBox1.Items.Add("First Name | Last Name | Age | Wins | Losses | Points | Active");
            foreach (PlayerInactive pl in playerListInactive)
            {
                string s = String.Format("{0,10} | {1,9} | {2,3} |    N/A |    N/A |    N/A | {3}",
                    pl.fName, pl.lName, pl.Age.ToString(), pl.Active.ToString());
                listBox1.Items.Add(s);
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            //Show all players 
            listBox1.Items.Clear();
            listBox1.Items.Add("First Name | Last Name | Age | Wins | Losses | Points | Active");
            foreach (PlayerActive pl in playerListActive)
            {
                string s = String.Format("{0,10} | {1,9} | {2,3} | {3,6} | {4,6} | {5,6} ",
                    pl.fName, pl.lName, pl.Age.ToString(), pl.Wins.ToString(), pl.Losses.ToString(),
                    pl.Points.ToString(), pl.Active.ToString());
                listBox1.Items.Add(s);
            }
            foreach (PlayerInactive pl in playerListInactive)
            {
                string s = String.Format("{0,10} | {1,9} | {2,3} |    N/A |    N/A |    N/A | {3}",
                    pl.fName, pl.lName, pl.Age.ToString(), pl.Active.ToString());
                listBox1.Items.Add(s);
            }
        }

        private void Players_Load(object sender, EventArgs e)
        {

        }
    }
}
