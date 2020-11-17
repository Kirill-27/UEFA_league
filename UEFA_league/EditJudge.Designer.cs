namespace UEFA_league.Forms
{
    partial class EditJudge
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
            this.Sal_numeric = new System.Windows.Forms.NumericUpDown();
            this.label_salary = new System.Windows.Forms.Label();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.Age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nationality_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.judge_id_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.judgesTableAdapter1 = new UEFA_league.UEFA_leagueDataSetTableAdapters.judgesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uEFA_leagueDataSet = new UEFA_league.UEFA_leagueDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Sal_numeric
            // 
            this.Sal_numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sal_numeric.Location = new System.Drawing.Point(204, 190);
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
            this.Sal_numeric.TabIndex = 57;
            this.Sal_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.Location = new System.Drawing.Point(40, 193);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(152, 18);
            this.label_salary.TabIndex = 56;
            this.label_salary.Text = "Salary_per_match";
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Category_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Items.AddRange(new object[] {
            "Select Group",
            "Select Group 2",
            "Level 1",
            "Level 2a",
            "Level 2b"});
            this.Category_comboBox.Location = new System.Drawing.Point(204, 225);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(197, 28);
            this.Category_comboBox.TabIndex = 55;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(303, 285);
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
            this.OK_button.Location = new System.Drawing.Point(199, 285);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(98, 32);
            this.OK_button.TabIndex = 53;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Age_numericUpDown
            // 
            this.Age_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Age_numericUpDown.Location = new System.Drawing.Point(204, 155);
            this.Age_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age_numericUpDown.Name = "Age_numericUpDown";
            this.Age_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.Age_numericUpDown.TabIndex = 52;
            this.Age_numericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Nationality_textBox
            // 
            this.Nationality_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nationality_textBox.Location = new System.Drawing.Point(204, 120);
            this.Nationality_textBox.Name = "Nationality_textBox";
            this.Nationality_textBox.Size = new System.Drawing.Size(197, 26);
            this.Nationality_textBox.TabIndex = 50;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(204, 51);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(197, 26);
            this.Name_textBox.TabIndex = 48;
            // 
            // judge_id_label
            // 
            this.judge_id_label.AutoSize = true;
            this.judge_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.judge_id_label.Location = new System.Drawing.Point(200, 23);
            this.judge_id_label.Name = "judge_id_label";
            this.judge_id_label.Size = new System.Drawing.Size(15, 20);
            this.judge_id_label.TabIndex = 47;
            this.judge_id_label.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Work beginning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Judge_id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 26);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // judgesTableAdapter1
            // 
            this.judgesTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.uEFA_leagueDataSet;
            this.bindingSource1.Position = 0;
            // 
            // uEFA_leagueDataSet
            // 
            this.uEFA_leagueDataSet.DataSetName = "UEFA_leagueDataSet";
            this.uEFA_leagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(451, 354);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Sal_numeric);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.Category_comboBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Age_numericUpDown);
            this.Controls.Add(this.Nationality_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.judge_id_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditJudge";
            this.Text = "EditJudge";
            ((System.ComponentModel.ISupportInitialize)(this.Sal_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uEFA_leagueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Sal_numeric;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.NumericUpDown Age_numericUpDown;
        private System.Windows.Forms.TextBox Nationality_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label judge_id_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private UEFA_leagueDataSetTableAdapters.judgesTableAdapter judgesTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private UEFA_leagueDataSet uEFA_leagueDataSet;
    }
}