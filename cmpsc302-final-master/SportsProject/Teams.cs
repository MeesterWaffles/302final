using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

//String.Format 1 expression

namespace SportsProject
{
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)//back to main form button
        {
            this.Close();
        }

        private void Teams_Load(object sender, EventArgs e)//on load
        {
            //na
        }

        private void btnAddTeam_Click(object sender, EventArgs e)// add new team to combo lists
        {
            //each textbox entry assigned to a var
            string division = tbDivision.Text;
            string city = tbCity.Text;
            string team = tbTeam.Text;
            Match error = Regex.Match(division, @"(?i)North West|(?i)North East|(?i)South East|(?i)South West");//error checking for divisions
            
            if(!error.Success)//error checking for divisions
            {
                MessageBox.Show("Not a valid division");
                tbDivision.Clear();
                return;
            }

            //using regex (and string.Format)...
            foreach (Match mm in Regex.Matches(division, @"(?i)North East"))// if in NE division, put in NE combobox
            {
                cbNorthEast.Items.Add(string.Format("{0} {1}", city, team));
            }

            foreach (Match mm in Regex.Matches(division, @"(?i)North West")) //if in NW division, put in NW combobox
            {
                cbNorthWest.Items.Add(string.Format("{0} {1}", city, team));
            }

            foreach (Match mm in Regex.Matches(division, @"(?i)South East")) //if in SE division, put in SE combobox
            {
                cbSouthEast.Items.Add(string.Format("{0} {1}", city, team));
            }

            foreach (Match mm in Regex.Matches(division, @"(?i)South West")) //if in SW division, put in SW combobox
            {
                cbSouthWest.Items.Add(string.Format("{0} {1}", city, team));
            }

            tbCity.Clear();
            tbTeam.Clear();
            tbDivision.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //mistake
        }

        
        private void cbNorthEast_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mistake
        }
    }
}
