namespace UEFA_league
{
    partial class EditMatch
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
            this.components = new System.ComponentModel.Container();
            this.attendance_numeric = new System.Windows.Forms.NumericUpDown();
            this.label_salary = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.Match_id_label = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.host_team_comboBox = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.judge_comboBox = new System.Windows.Forms.ComboBox();
            this.judgesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.guest_team_comboBox = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.goal_host_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.goal_gue_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.card_host_numeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.card_gue_numeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stage_comboBox = new System.Windows.Forms.ComboBox();
            this.weather_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Was_played_checkBox = new System.Windows.Forms.CheckBox();
            this.teamsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.teamsTableAdapter();
            this.judgesTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.judgesTableAdapter();
            this.matchesTableAdapter1 = new UEFA_league.UEFA_leagueDataSetTableAdapters.matchesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal_host_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal_gue_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_host_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gue_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // attendance_numeric
            // 
            this.attendance_numeric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance_numeric.Location = new System.Drawing.Point(153, 188);
            this.attendance_numeric.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.attendance_numeric.Name = "attendance_numeric";
            this.attendance_numeric.Size = new System.Drawing.Size(120, 26);
            this.attendance_numeric.TabIndex = 57;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.Location = new System.Drawing.Point(20, 196);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(102, 18);
            this.label_salary.TabIndex = 56;
            this.label_salary.Text = "Attendance";
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(344, 295);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(98, 32);
            this.Cancel_button.TabIndex = 54;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button.Location = new System.Drawing.Point(217, 295);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(98, 32);
            this.OK_button.TabIndex = 53;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Match_id_label
            // 
            this.Match_id_label.AutoSize = true;
            this.Match_id_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Match_id_label.Location = new System.Drawing.Point(401, 9);
            this.Match_id_label.Name = "Match_id_label";
            this.Match_id_label.Size = new System.Drawing.Size(15, 18);
            this.Match_id_label.TabIndex = 47;
            this.Match_id_label.Text = "*";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(283, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(79, 18);
            this.lable1.TabIndex = 40;
            this.lable1.Text = "Match_id";
            // 
            // host_team_comboBox
            // 
            this.host_team_comboBox.DataSource = this.teamsBindingSource;
            this.host_team_comboBox.DisplayMember = "team_name";
            this.host_team_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_team_comboBox.FormattingEnabled = true;
            this.host_team_comboBox.Location = new System.Drawing.Point(145, 45);
            this.host_team_comboBox.Name = "host_team_comboBox";
            this.host_team_comboBox.Size = new System.Drawing.Size(197, 26);
            this.host_team_comboBox.TabIndex = 59;
            this.host_team_comboBox.ValueMember = "team_id";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.uEFA_leagueDataSet;
            // 
            // uEFA_leagueDataSet
            // 
            this.uEFA_leagueDataSet.DataSetName = "UEFA_leagueDataSet";
            this.uEFA_leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Host team";
            // 
            // judge_comboBox
            // 
            this.judge_comboBox.DataSource = this.judgesBindingSource;
            this.judge_comboBox.DisplayMember = "full_name";
            this.judge_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judge_comboBox.FormattingEnabled = true;
            this.judge_comboBox.Location = new System.Drawing.Point(449, 189);
            this.judge_comboBox.Name = "judge_comboBox";
            this.judge_comboBox.Size = new System.Drawing.Size(197, 26);
            this.judge_comboBox.TabIndex = 61;
            this.judge_comboBox.ValueMember = "judge_id";
            // 
            // judgesBindingSource
            // 
            this.judgesBindingSource.DataMember = "judges";
            this.judgesBindingSource.DataSource = this.uEFA_leagueDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Judge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 64;
            this.label10.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 26);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // guest_team_comboBox
            // 
            this.guest_team_comboBox.DataSource = this.teamsBindingSource1;
            this.guest_team_comboBox.DisplayMember = "team_name";
            this.guest_team_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_team_comboBox.FormattingEnabled = true;
            this.guest_team_comboBox.Location = new System.Drawing.Point(480, 45);
            this.guest_team_comboBox.Name = "guest_team_comboBox";
            this.guest_team_comboBox.Size = new System.Drawing.Size(197, 26);
            this.guest_team_comboBox.TabIndex = 67;
            this.guest_team_comboBox.ValueMember = "team_id";
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "teams";
            this.teamsBindingSource1.DataSource = this.uEFA_leagueDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Guest team";
            // 
            // goal_host_numeric
            // 
            this.goal_host_numeric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goal_host_numeric.Location = new System.Drawing.Point(153, 78);
            this.goal_host_numeric.Name = "goal_host_numeric";
            this.goal_host_numeric.Size = new System.Drawing.Size(120, 26);
            this.goal_host_numeric.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Host goals";
            // 
            // goal_gue_numeric
            // 
            this.goal_gue_numeric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goal_gue_numeric.Location = new System.Drawing.Point(557, 77);
            this.goal_gue_numeric.Name = "goal_gue_numeric";
            this.goal_gue_numeric.Size = new System.Drawing.Size(120, 26);
            this.goal_gue_numeric.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Guest goals";
            // 
            // card_host_numeric
            // 
            this.card_host_numeric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_host_numeric.Location = new System.Drawing.Point(153, 110);
            this.card_host_numeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.card_host_numeric.Name = "card_host_numeric";
            this.card_host_numeric.Size = new System.Drawing.Size(120, 26);
            this.card_host_numeric.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Host yellow card";
            // 
            // card_gue_numeric
            // 
            this.card_gue_numeric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_gue_numeric.Location = new System.Drawing.Point(558, 110);
            this.card_gue_numeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.card_gue_numeric.Name = "card_gue_numeric";
            this.card_gue_numeric.Size = new System.Drawing.Size(120, 26);
            this.card_gue_numeric.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 74;
            this.label7.Text = "Guest yellow card";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 76;
            this.label8.Text = "Stage";
            // 
            // stage_comboBox
            // 
            this.stage_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_comboBox.FormattingEnabled = true;
            this.stage_comboBox.Items.AddRange(new object[] {
            "Group Stade",
            "Eighth-final",
            "Quarter-final",
            "Semi-final",
            "Final"});
            this.stage_comboBox.Location = new System.Drawing.Point(153, 220);
            this.stage_comboBox.Name = "stage_comboBox";
            this.stage_comboBox.Size = new System.Drawing.Size(129, 26);
            this.stage_comboBox.TabIndex = 77;
            // 
            // weather_comboBox
            // 
            this.weather_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather_comboBox.FormattingEnabled = true;
            this.weather_comboBox.Location = new System.Drawing.Point(153, 252);
            this.weather_comboBox.Name = "weather_comboBox";
            this.weather_comboBox.Size = new System.Drawing.Size(129, 26);
            this.weather_comboBox.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 78;
            this.label9.Text = "Weather";
            // 
            // Was_played_checkBox
            // 
            this.Was_played_checkBox.AutoSize = true;
            this.Was_played_checkBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Was_played_checkBox.Location = new System.Drawing.Point(453, 256);
            this.Was_played_checkBox.Name = "Was_played_checkBox";
            this.Was_played_checkBox.Size = new System.Drawing.Size(118, 22);
            this.Was_played_checkBox.TabIndex = 80;
            this.Was_played_checkBox.Text = "Was played";
            this.Was_played_checkBox.UseVisualStyleBackColor = true;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // judgesTableAdapter
            // 
            this.judgesTableAdapter.ClearBeforeFill = true;
            // 
            // matchesTableAdapter1
            // 
            this.matchesTableAdapter1.ClearBeforeFill = true;
            // 
            // EditMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.Was_played_checkBox);
            this.Controls.Add(this.weather_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stage_comboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.card_gue_numeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.card_host_numeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goal_gue_numeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goal_host_numeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guest_team_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.judge_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.host_team_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attendance_numeric);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Match_id_label);
            this.Controls.Add(this.lable1);
            this.Name = "EditMatch";
            this.Text = "EditMatch";
            this.Load += new System.EventHandler(this.EditMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendance_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal_host_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal_gue_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_host_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gue_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown attendance_numeric;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label Match_id_label;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown goal_host_numeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown goal_gue_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown card_host_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown card_gue_numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Was_played_checkBox;
        private System.Windows.Forms.ComboBox host_team_comboBox;
        private System.Windows.Forms.ComboBox judge_comboBox;
        private System.Windows.Forms.ComboBox guest_team_comboBox;
        private System.Windows.Forms.ComboBox stage_comboBox;
        private System.Windows.Forms.ComboBox weather_comboBox;
        private UEFA_leagueDataSet uEFA_leagueDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private UEFA_leagueDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource judgesBindingSource;
        private UEFA_leagueDataSetTableAdapters.judgesTableAdapter judgesTableAdapter;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private UEFA_leagueDataSetTableAdapters.matchesTableAdapter matchesTableAdapter1;
    }
}