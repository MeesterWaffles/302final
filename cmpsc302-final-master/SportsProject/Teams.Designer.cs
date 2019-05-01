namespace SportsProject
{
    partial class Teams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDivision = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNorthEast = new System.Windows.Forms.ComboBox();
            this.cbSouthEast = new System.Windows.Forms.ComboBox();
            this.cbNorthWest = new System.Windows.Forms.ComboBox();
            this.cbSouthWest = new System.Windows.Forms.ComboBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "North East";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Team: ";
            // 
            // tbTeam
            // 
            this.tbTeam.Location = new System.Drawing.Point(161, 181);
            this.tbTeam.Name = "tbTeam";
            this.tbTeam.Size = new System.Drawing.Size(141, 20);
            this.tbTeam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Division: ";
            // 
            // tbDivision
            // 
            this.tbDivision.Location = new System.Drawing.Point(161, 223);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.Size = new System.Drawing.Size(141, 20);
            this.tbDivision.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(363, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 46);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "North West";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "South East";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "South West";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Teams";
            // 
            // cbNorthEast
            // 
            this.cbNorthEast.FormattingEnabled = true;
            this.cbNorthEast.Items.AddRange(new object[] {
            "Pittsburgh Power",
            "New York Nuggets",
            "Boston Bruisers"});
            this.cbNorthEast.Location = new System.Drawing.Point(493, 181);
            this.cbNorthEast.Name = "cbNorthEast";
            this.cbNorthEast.Size = new System.Drawing.Size(121, 21);
            this.cbNorthEast.TabIndex = 15;
            this.cbNorthEast.SelectedIndexChanged += new System.EventHandler(this.cbNorthEast_SelectedIndexChanged);
            // 
            // cbSouthEast
            // 
            this.cbSouthEast.FormattingEnabled = true;
            this.cbSouthEast.Items.AddRange(new object[] {
            "Nashville Nightmare",
            "Atlanta Aces",
            "Miami Monsters"});
            this.cbSouthEast.Location = new System.Drawing.Point(493, 251);
            this.cbSouthEast.Name = "cbSouthEast";
            this.cbSouthEast.Size = new System.Drawing.Size(121, 21);
            this.cbSouthEast.TabIndex = 16;
            // 
            // cbNorthWest
            // 
            this.cbNorthWest.FormattingEnabled = true;
            this.cbNorthWest.Items.AddRange(new object[] {
            "Minneapolis Magic",
            "Seattle Strikers",
            "Portland Punishers"});
            this.cbNorthWest.Location = new System.Drawing.Point(493, 319);
            this.cbNorthWest.Name = "cbNorthWest";
            this.cbNorthWest.Size = new System.Drawing.Size(121, 21);
            this.cbNorthWest.TabIndex = 17;
            // 
            // cbSouthWest
            // 
            this.cbSouthWest.FormattingEnabled = true;
            this.cbSouthWest.Items.AddRange(new object[] {
            "Dallas Dragsters",
            "Houston Heroes",
            "Vegas Victory"});
            this.cbSouthWest.Location = new System.Drawing.Point(493, 386);
            this.cbSouthWest.Name = "cbSouthWest";
            this.cbSouthWest.Size = new System.Drawing.Size(121, 21);
            this.cbSouthWest.TabIndex = 18;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(136, 271);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 19;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Divisions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "City:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(161, 142);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(141, 20);
            this.tbCity.TabIndex = 22;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.cbSouthWest);
            this.Controls.Add(this.cbNorthWest);
            this.Controls.Add(this.cbSouthEast);
            this.Controls.Add(this.cbNorthEast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbDivision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDivision;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNorthEast;
        private System.Windows.Forms.ComboBox cbSouthEast;
        private System.Windows.Forms.ComboBox cbNorthWest;
        private System.Windows.Forms.ComboBox cbSouthWest;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCity;
    }
}