namespace UEFA_league
{
    partial class Report1
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
            this.GetReportButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NationalityReport = new System.Windows.Forms.Button();
            this.JudesReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetReportButton
            // 
            this.GetReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetReportButton.Location = new System.Drawing.Point(487, 330);
            this.GetReportButton.Name = "GetReportButton";
            this.GetReportButton.Size = new System.Drawing.Size(149, 37);
            this.GetReportButton.TabIndex = 0;
            this.GetReportButton.Text = "Get report";
            this.GetReportButton.UseVisualStyleBackColor = true;
            this.GetReportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 333);
            this.dataGridView1.TabIndex = 10;
            // 
            // NationalityReport
            // 
            this.NationalityReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NationalityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NationalityReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalityReport.Location = new System.Drawing.Point(458, 100);
            this.NationalityReport.Name = "NationalityReport";
            this.NationalityReport.Size = new System.Drawing.Size(178, 50);
            this.NationalityReport.TabIndex = 11;
            this.NationalityReport.Text = "Nationality report";
            this.NationalityReport.UseVisualStyleBackColor = false;
            this.NationalityReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // JudesReport
            // 
            this.JudesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.JudesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JudesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JudesReport.Location = new System.Drawing.Point(458, 34);
            this.JudesReport.Name = "JudesReport";
            this.JudesReport.Size = new System.Drawing.Size(178, 50);
            this.JudesReport.TabIndex = 12;
            this.JudesReport.Text = "Judes report";
            this.JudesReport.UseVisualStyleBackColor = false;
            this.JudesReport.Click += new System.EventHandler(this.button3_Click);
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(666, 394);
            this.Controls.Add(this.JudesReport);
            this.Controls.Add(this.NationalityReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetReportButton);
            this.Name = "Report1";
            this.Text = "Report1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetReportButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NationalityReport;
        private System.Windows.Forms.Button JudesReport;
    }
}