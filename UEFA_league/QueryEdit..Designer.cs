namespace UEFA_league
{
    partial class QueryEdit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.DoSQLbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.TestInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.countPlayersInTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countPlayersNationalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.judgesCostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 234);
            this.dataGridView1.TabIndex = 9;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(508, 133);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(109, 35);
            this.Exitbutton.TabIndex = 8;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // DoSQLbutton
            // 
            this.DoSQLbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoSQLbutton.Location = new System.Drawing.Point(508, 46);
            this.DoSQLbutton.Name = "DoSQLbutton";
            this.DoSQLbutton.Size = new System.Drawing.Size(109, 37);
            this.DoSQLbutton.TabIndex = 7;
            this.DoSQLbutton.Text = "Do SQL";
            this.DoSQLbutton.UseVisualStyleBackColor = true;
            this.DoSQLbutton.Click += new System.EventHandler(this.DoSQLbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(508, 89);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(109, 38);
            this.Clearbutton.TabIndex = 6;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // TestInput
            // 
            this.TestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestInput.Location = new System.Drawing.Point(23, 46);
            this.TestInput.Name = "TestInput";
            this.TestInput.Size = new System.Drawing.Size(470, 122);
            this.TestInput.TabIndex = 5;
            this.TestInput.Text = "SELECT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countPlayersInTeamsToolStripMenuItem,
            this.countPlayersNationalityToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.judgesCostsToolStripMenuItem,
            this.yellowCardsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // countPlayersInTeamsToolStripMenuItem
            // 
            this.countPlayersInTeamsToolStripMenuItem.Name = "countPlayersInTeamsToolStripMenuItem";
            this.countPlayersInTeamsToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.countPlayersInTeamsToolStripMenuItem.Text = "Count players in teams";
            this.countPlayersInTeamsToolStripMenuItem.Click += new System.EventHandler(this.countPlayersInTeamsToolStripMenuItem_Click);
            // 
            // countPlayersNationalityToolStripMenuItem
            // 
            this.countPlayersNationalityToolStripMenuItem.Name = "countPlayersNationalityToolStripMenuItem";
            this.countPlayersNationalityToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.countPlayersNationalityToolStripMenuItem.Text = "Count players nationality";
            this.countPlayersNationalityToolStripMenuItem.Click += new System.EventHandler(this.countPlayersNationalityToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // judgesCostsToolStripMenuItem
            // 
            this.judgesCostsToolStripMenuItem.Name = "judgesCostsToolStripMenuItem";
            this.judgesCostsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.judgesCostsToolStripMenuItem.Text = "Judges costs";
            this.judgesCostsToolStripMenuItem.Click += new System.EventHandler(this.judgesCostsToolStripMenuItem_Click);
            // 
            // yellowCardsToolStripMenuItem
            // 
            this.yellowCardsToolStripMenuItem.Name = "yellowCardsToolStripMenuItem";
            this.yellowCardsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yellowCardsToolStripMenuItem.Text = "Budgets";
            this.yellowCardsToolStripMenuItem.Click += new System.EventHandler(this.yellowCardsToolStripMenuItem_Click);
            // 
            // QueryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(656, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.DoSQLbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.TestInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QueryEdit";
            this.Text = "Query Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button DoSQLbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.RichTextBox TestInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem countPlayersInTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countPlayersNationalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem judgesCostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowCardsToolStripMenuItem;
    }
}