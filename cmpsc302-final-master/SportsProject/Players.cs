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
    public partial class Players : Form
    {
        List<PlayerActive> playerListActive = new List<PlayerActive>();
        List<PlayerInactive> playerListInactive = new List<PlayerInactive>();
        public Players() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            int wins = 0;
            int losses = 0;
            int points = 0;
            int age = 0;
            int active = -1;

            if(int.TryParse(txtAge.Text, out result))
            {
                age = int.Parse(txtAge.Text);
                if(age > 0) { }
                else { return; }
            }
            else { return; }

            if (int.TryParse(txtWins.Text, out result))
            {
                wins = int.Parse(txtAge.Text);
                if(wins >= 0) { }
                else { return; }
            }
            else { return; }

            if (int.TryParse(txtLosses.Text, out result))
            {
                losses = int.Parse(txtLosses.Text);
                if(losses >= 0) { }
                else { return; }
            }
            else { return; }

            if (int.TryParse(txtPoints.Text, out result))
            {
                points = int.Parse(txtPoints.Text);
                if(points >= 0) { }
                else { return; }
            }
            else { return; }

            if(rbActive.Checked)
            {
                active = 0;
            }
            else if(rbInactive.Checked)
            {
                active = 1;
            }
            switch(active)
            {
                case 0: //active
                    PlayerActive pActive = new PlayerActive
                    {
                        fName = fName,
                        lName = lName,
                        Age = age,
                        Wins = wins,
                        Losses = losses,
                        Points = points,
                        Active = true
                    };
                    playerListActive.Add(pActive);
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
                    break;
                default:
                    return;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("First Name | Last Name | Wins | Losses | Points | Active");
            foreach (PlayerActive pl in playerListActive)
            {
                string s = String.Format("{0} | {1} | {2} | {3} | {4} | {5} ", 
                    pl.fName, pl.lName, pl.Age.ToString(), pl.Wins.ToString(), pl.Losses.ToString(),
                    pl.Points.ToString(), pl.Active.ToString());
                listBox1.Items.Add(s);
            }
            foreach (PlayerInactive pl in playerListInactive)
            {
                string s = String.Format("{0} | {1} | {2} | 0 | 0 | 0 | {3}",
                    pl.fName, pl.lName, pl.Age.ToString(), pl.Active.ToString());
                listBox1.Items.Add(s);
            }
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtWins.Clear();
            txtLosses.Clear();
            txtPoints.Clear();
        }
    }
}
