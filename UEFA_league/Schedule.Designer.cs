namespace UEFA_league
{
    partial class Schedule
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            this.teamsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.teamsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.matchesTableAdapter1 = new UEFA_league.UEFA_leagueDataSetTableAdapters.matchesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.judgesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet1 = new UEFA_league.UEFA_leagueDataSet();
            this.judgesTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.judgesTableAdapter();
            this.judgesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.judgesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.judgesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.teamsBindingSource;
            this.comboBox1.DisplayMember = "team_name";
            this.comboBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "team_id";
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
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.teamsBindingSource1;
            this.comboBox2.DisplayMember = "team_name";
            this.comboBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(34, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 26);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "team_id";
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "teams";
            this.teamsBindingSource1.DataSource = this.uEFA_leagueDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.teamsBindingSource3;
            this.comboBox3.DisplayMember = "team_name";
            this.comboBox3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(34, 147);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 26);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.ValueMember = "team_id";
            // 
            // teamsBindingSource3
            // 
            this.teamsBindingSource3.DataMember = "teams";
            this.teamsBindingSource3.DataSource = this.uEFA_leagueDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.teamsBindingSource2;
            this.comboBox4.DisplayMember = "team_name";
            this.comboBox4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(34, 115);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(192, 26);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.ValueMember = "team_id";
            // 
            // teamsBindingSource2
            // 
            this.teamsBindingSource2.DataMember = "teams";
            this.teamsBindingSource2.DataSource = this.uEFA_leagueDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.teamsBindingSource7;
            this.comboBox5.DisplayMember = "team_name";
            this.comboBox5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(330, 147);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(192, 26);
            this.comboBox5.TabIndex = 7;
            this.comboBox5.ValueMember = "team_id";
            // 
            // teamsBindingSource7
            // 
            this.teamsBindingSource7.DataMember = "teams";
            this.teamsBindingSource7.DataSource = this.uEFA_leagueDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.teamsBindingSource6;
            this.comboBox6.DisplayMember = "team_name";
            this.comboBox6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(330, 115);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(192, 26);
            this.comboBox6.TabIndex = 6;
            this.comboBox6.ValueMember = "team_id";
            // 
            // teamsBindingSource6
            // 
            this.teamsBindingSource6.DataMember = "teams";
            this.teamsBindingSource6.DataSource = this.uEFA_leagueDataSet;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.teamsBindingSource5;
            this.comboBox7.DisplayMember = "team_name";
            this.comboBox7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(330, 83);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(192, 26);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.ValueMember = "team_id";
            // 
            // teamsBindingSource5
            // 
            this.teamsBindingSource5.DataMember = "teams";
            this.teamsBindingSource5.DataSource = this.uEFA_leagueDataSet;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.teamsBindingSource4;
            this.comboBox8.DisplayMember = "team_name";
            this.comboBox8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(330, 51);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(192, 26);
            this.comboBox8.TabIndex = 4;
            this.comboBox8.ValueMember = "team_id";
            // 
            // teamsBindingSource4
            // 
            this.teamsBindingSource4.DataMember = "teams";
            this.teamsBindingSource4.DataSource = this.uEFA_leagueDataSet;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(340, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Make schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matchesTableAdapter1
            // 
            this.matchesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Group A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Group B";
            // 
            // judgesBindingSource
            // 
            this.judgesBindingSource.DataMember = "judges";
            this.judgesBindingSource.DataSource = this.uEFA_leagueDataSet1;
            // 
            // uEFA_leagueDataSet1
            // 
            this.uEFA_leagueDataSet1.DataSetName = "UEFA_leagueDataSet";
            this.uEFA_leagueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // judgesTableAdapter
            // 
            this.judgesTableAdapter.ClearBeforeFill = true;
            // 
            // judgesBindingSource1
            // 
            this.judgesBindingSource1.DataMember = "judges";
            this.judgesBindingSource1.DataSource = this.uEFA_leagueDataSet1;
            // 
            // judgesBindingSource3
            // 
            this.judgesBindingSource3.DataMember = "judges";
            this.judgesBindingSource3.DataSource = this.uEFA_leagueDataSet1;
            // 
            // judgesBindingSource2
            // 
            this.judgesBindingSource2.DataMember = "judges";
            this.judgesBindingSource2.DataSource = this.uEFA_leagueDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Team 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Team 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Team 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Team 3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "First match date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(556, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(21, 26);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Visible = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(578, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private UEFA_leagueDataSet uEFA_leagueDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private UEFA_leagueDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private System.Windows.Forms.BindingSource teamsBindingSource3;
        private System.Windows.Forms.BindingSource teamsBindingSource2;
        private System.Windows.Forms.BindingSource teamsBindingSource7;
        private System.Windows.Forms.BindingSource teamsBindingSource6;
        private System.Windows.Forms.BindingSource teamsBindingSource5;
        private System.Windows.Forms.BindingSource teamsBindingSource4;
        private System.Windows.Forms.Button button1;
        private UEFA_leagueDataSetTableAdapters.matchesTableAdapter matchesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UEFA_leagueDataSet uEFA_leagueDataSet1;
        private System.Windows.Forms.BindingSource judgesBindingSource;
        private UEFA_leagueDataSetTableAdapters.judgesTableAdapter judgesTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource judgesBindingSource1;
        private System.Windows.Forms.BindingSource judgesBindingSource3;
        private System.Windows.Forms.BindingSource judgesBindingSource2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}