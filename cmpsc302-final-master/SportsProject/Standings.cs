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
    public partial class Standings : Form
    {
        //This form takes in a team name and three scores
        //It will then add the three scores together for a total score
        //When displaying the teams, it will sort the teams from highest to lowest scores
        public Standings()
        {
            InitializeComponent();
        }

        //2D array of the scores with parrallel array for the team names
        int[,] scores = new int[5, 4];
        string[] names = new string[5];

        //counter for the number of teams entered
        int teamCounter = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            //Error checking
            if (teamCounter == 5)
            {
                MessageBox.Show("Error: maximum number of teams has been entered");
                return;
            }
            int res;
            if (textBoxR1.Text.Trim().Equals("") || textBoxR2.Text.Trim().Equals("") || textBoxR3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Error: All scores must be entered");
                return;
            }
            else if (!int.TryParse(textBoxR1.Text, out res) || !int.TryParse(textBoxR2.Text, out res) || !int.TryParse(textBoxR3.Text, out res))
            {
                MessageBox.Show("Error: All scores must be integers");
                return;
            }
            else if (int.Parse(textBoxR1.Text) < 0 || int.Parse(textBoxR2.Text) < 0 || int.Parse(textBoxR3.Text) < 0)
            {
                MessageBox.Show("Error: Scores can not be negative");
                return;
            }

            //Error checking is over now we can do the scores
            int s1 = int.Parse(textBoxR1.Text);
            int s2 = int.Parse(textBoxR2.Text);
            int s3 = int.Parse(textBoxR3.Text);

            //Adds the scores to the scoreboard array with totals
            scores[teamCounter, 0] = s1;
            scores[teamCounter, 1] = s2;
            scores[teamCounter, 2] = s3;
            scores[teamCounter, 3] = s1 + s2 + s3;
            names[teamCounter] = textBoxName.Text;
            teamCounter++;
            MessageBox.Show("Scores sucessfully submitted");

            //lets higher team scores rise to the top by swapping
            //this is essentially a bubble sort
            
            //fringe case for at least 2 teams entered and top scores being off
            if (teamCounter >= 2 && scores[0,3] < scores[1,3]) swap(0, 1);
            int tryCounter = 0;
            while (!isSorted() && tryCounter < 5)
            {
                try
                {
                    for (int i = teamCounter; i > 1; i--)
                    {
                        if (scores[i, 3] > scores[i - 1, 3]) swap(i, i - 1);
                    }
                }
                catch (IndexOutOfRangeException iore) { Console.WriteLine(""); }
                tryCounter++;
            }
        }

        private void ShowStandings_Click(object sender, EventArgs e)
        {
            teamStandings.Items.Clear();
            teamStandings.Items.Add("      Team Name | Round 1 | Round 2 | Round 3 |   Total | Rank");

            //keeps track of place
            for (int i = 0; i < teamCounter; i++)
            {
                string t = string.Format("{0,15} | {1,7} | {2,7} | {3,7} | {4,7} | {5}",
                    names[i],
                    scores[i, 0].ToString(),
                    scores[i, 1].ToString(),
                    scores[i, 2].ToString(),
                    scores[i, 3].ToString(),
                    (i+1).ToString()
                );
                teamStandings.Items.Add(t);
            }
        }

        private void swap(int a, int b)
        {
            //swaps two teams within the standings
            int[] tmp = new int[] { scores[a, 0], scores[a, 1], scores[a, 2], scores[a, 3] };

            scores[a, 0] = scores[b, 0];
            scores[a, 1] = scores[b, 1];
            scores[a, 2] = scores[b, 2];
            scores[a, 3] = scores[b, 3];

            scores[b, 0] = tmp[0];
            scores[b, 1] = tmp[1];
            scores[b, 2] = tmp[2];
            scores[b, 3] = tmp[3];

            string tmpstr = names[a];
            names[a] = names[b];
            names[b] = tmpstr;
        }

        private bool isSorted()
        {
            //determined if the scores are sorted or not
            if (teamCounter <= 3) return true;
            try
            {
                for (int i = 0; i < teamCounter - 1; i++)
                {
                    if (scores[i, 3] < scores[i + 1, 3]) return false;
                }
            }
            catch (IndexOutOfRangeException iore) { Console.WriteLine(""); }

            return true;
        }
    }
}
