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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamPointsTbx = new System.Windows.Forms.TextBox();
            this.teamNameTbx = new System.Windows.Forms.TextBox();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.teamPointsTbx);
            this.groupBox1.Controls.Add(this.teamNameTbx);
            this.groupBox1.Controls.Add(this.addTeamBtn);
            this.groupBox1.Location = new System.Drawing.Point(45, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team Points:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team Name:";
            // 
            // teamPointsTbx
            // 
            this.teamPointsTbx.Location = new System.Drawing.Point(105, 68);
            this.teamPointsTbx.Name = "teamPointsTbx";
            this.teamPointsTbx.Size = new System.Drawing.Size(100, 20);
            this.teamPointsTbx.TabIndex = 2;
            // 
            // teamNameTbx
            // 
            this.teamNameTbx.Location = new System.Drawing.Point(105, 42);
            this.teamNameTbx.Name = "teamNameTbx";
            this.teamNameTbx.Size = new System.Drawing.Size(100, 20);
            this.teamNameTbx.TabIndex = 1;
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.Location = new System.Drawing.Point(120, 177);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(85, 37);
            this.addTeamBtn.TabIndex = 0;
            this.addTeamBtn.Text = "Submit new team";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            this.addTeamBtn.Click += new System.EventHandler(this.AddTeamBtn_Click);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teamPointsTbx;
        private System.Windows.Forms.TextBox teamNameTbx;
        private System.Windows.Forms.Button addTeamBtn;
    }
}