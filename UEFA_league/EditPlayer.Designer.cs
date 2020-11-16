namespace UEFA_league
{
    partial class EditPlayer
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
            this.Team_comboBox = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uEFAleagueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.Age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Number_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nationality_textBox = new System.Windows.Forms.TextBox();
            this.Surname_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.player_id_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.Sal_numeric = new System.Windows.Forms.NumericUpDown();
            this.teamsTableAdapter = new UEFA_league.UEFA_leagueDataSetTableAdapters.teamsTableAdapter();
            this.playersTableAdapter1 = new UEFA_league.UEFA_leagueDataSetTableAdapters.playersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFAleagueDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Team_comboBox
            // 
            this.Team_comboBox.DataSource = this.teamsBindingSource;
            this.Team_comboBox.DisplayMember = "team_name";
            this.Team_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Team_comboBox.FormattingEnabled = true;
            this.Team_comboBox.Location = new System.Drawing.Point(204, 262);
            this.Team_comboBox.Name = "Team_comboBox";
            this.Team_comboBox.Size = new System.Drawing.Size(197, 28);
            this.Team_comboBox.TabIndex = 37;
            this.Team_comboBox.ValueMember = "team_id";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.uEFAleagueDataSetBindingSource;
            // 
            // uEFAleagueDataSetBindingSource
            // 
            this.uEFAleagueDataSetBindingSource.DataSource = this.uEFA_leagueDataSet;
            this.uEFAleagueDataSetBindingSource.Position = 0;
            // 
            // uEFA_leagueDataSet
            // 
            this.uEFA_leagueDataSet.DataSetName = "UEFA_leagueDataSet";
            this.uEFA_leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(253, 348);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(98, 32);
            this.Cancel_button.TabIndex = 36;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button.Location = new System.Drawing.Point(126, 348);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(98, 32);
            this.OK_button.TabIndex = 35;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Age_numericUpDown
            // 
            this.Age_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Age_numericUpDown.Location = new System.Drawing.Point(204, 187);
            this.Age_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age_numericUpDown.Name = "Age_numericUpDown";
            this.Age_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.Age_numericUpDown.TabIndex = 34;
            this.Age_numericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Number_numericUpDown
            // 
            this.Number_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number_numericUpDown.Location = new System.Drawing.Point(204, 151);
            this.Number_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number_numericUpDown.Name = "Number_numericUpDown";
            this.Number_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.Number_numericUpDown.TabIndex = 33;
            this.Number_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nationality_textBox
            // 
            this.Nationality_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nationality_textBox.Location = new System.Drawing.Point(204, 225);
            this.Nationality_textBox.Name = "Nationality_textBox";
            this.Nationality_textBox.Size = new System.Drawing.Size(197, 26);
            this.Nationality_textBox.TabIndex = 32;
            // 
            // Surname_textBox
            // 
            this.Surname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_textBox.Location = new System.Drawing.Point(204, 111);
            this.Surname_textBox.Name = "Surname_textBox";
            this.Surname_textBox.Size = new System.Drawing.Size(197, 26);
            this.Surname_textBox.TabIndex = 31;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(204, 71);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(197, 26);
            this.Name_textBox.TabIndex = 30;
            // 
            // player_id_label
            // 
            this.player_id_label.AutoSize = true;
            this.player_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.player_id_label.Location = new System.Drawing.Point(211, 35);
            this.player_id_label.Name = "player_id_label";
            this.player_id_label.Size = new System.Drawing.Size(15, 20);
            this.player_id_label.TabIndex = 29;
            this.player_id_label.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Team";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Player_id";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.Location = new System.Drawing.Point(67, 303);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(59, 18);
            this.label_salary.TabIndex = 38;
            this.label_salary.Text = "Salary";
            // 
            // Sal_numeric
            // 
            this.Sal_numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sal_numeric.Location = new System.Drawing.Point(204, 300);
            this.Sal_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Sal_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sal_numeric.Name = "Sal_numeric";
            this.Sal_numeric.Size = new System.Drawing.Size(120, 26);
            this.Sal_numeric.TabIndex = 39;
            this.Sal_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // playersTableAdapter1
            // 
            this.playersTableAdapter1.ClearBeforeFill = true;
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(452, 420);
            this.Controls.Add(this.Sal_numeric);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.Team_comboBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Age_numericUpDown);
            this.Controls.Add(this.Number_numericUpDown);
            this.Controls.Add(this.Nationality_textBox);
            this.Controls.Add(this.Surname_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.player_id_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPlayer";
            this.Text = "EditPlayer";
            this.Load += new System.EventHandler(this.EditPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFAleagueDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Team_comboBox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.NumericUpDown Age_numericUpDown;
        private System.Windows.Forms.NumericUpDown Number_numericUpDown;
        private System.Windows.Forms.TextBox Nationality_textBox;
        private System.Windows.Forms.TextBox Surname_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label player_id_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.NumericUpDown Sal_numeric;
        private System.Windows.Forms.BindingSource uEFAleagueDataSetBindingSource;
        private UEFA_leagueDataSet uEFA_leagueDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private UEFA_leagueDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private UEFA_leagueDataSetTableAdapters.playersTableAdapter playersTableAdapter1;
    }
}