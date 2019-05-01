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
    public partial class Teams : Form
    {
        public Teams() { InitializeComponent(); }

        List<TeamClass> teamList = new List<TeamClass>();
        private void AddTeamBtn_Click(object sender, EventArgs e)
        {
            //checks to see if the name is already taken
            foreach (TeamClass tc in teamList)
            {
                if (tc.Name.ToLower().Equals(teamNameTbx.Text.ToLower()))
                {
                    MessageBox.Show("Error: Team name already taken");
                    return;
                }
            }

            //error checking for team points
            int pts;
            if (!int.TryParse(teamPointsTbx.Text, out pts))
            {
                MessageBox.Show("Error: Team points must be a number");
                return;
            }
            else if (int.Parse(teamPointsTbx.Text) <= 0)
            {
                MessageBox.Show("Error: Team points must not be negative");
                return;
            }
            TeamClass t = new TeamClass()
            {
                Name = teamNameTbx.Text,
                Points = int.Parse(teamPointsTbx.Text)
            };
            teamList.Add(t);
            writeTeamToFile(t);
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            //Loads the Teams from the file
            //This occurs as soon as the form is loaded
            try
            {
                teamList = new List<TeamClass>();
                using (StreamReader r = new StreamReader("teamsdata.json"))
                {
                    string json = r.ReadToEnd();
                    if (!json.Equals("")) teamList = JsonConvert.DeserializeObject<List<TeamClass>>(json);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void writeTeamToFile(TeamClass t)
        {
            //writes all team data to a local text (json) file
            //taken from https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm
            //also https://stackoverflow.com/questions/2291835/read-a-text-file-from-local-folder

            string json = JsonConvert.SerializeObject(teamList.ToArray());
            using (StreamWriter file = File.CreateText("teamsdata.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, teamList);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            teamsListBox.Items.Add("           Team Name | Team Points");
            foreach (TeamClass tc in teamList)
            {
                teamsListBox.Items.Add(String.Format("{0,20} | {1,11}", tc.Name, tc.Points.ToString()));
            }
        }
    }
}
