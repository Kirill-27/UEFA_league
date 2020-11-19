using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

namespace UEFA_league
{
    public partial class Report1 : Form
    {
        private const string ConnectionString = @"Data Source = 
        KIRILL_COMP\SQLEXPRESS;Initial Catalog = 
        UEFA_league; Integrated Security = True";

        private const string fileName = @"D:\Универ\3 сем\БД\Курсач\Report.docx";
        public Report1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (JudesReport.BackColor == Color.FromArgb(128, 128, 255))
            {
                
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = true;

                Word.Document document = wordApp.Documents.OpenNoRepairDialog(fileName);
                document.Activate();
                
                try
                {
                    Word.Table table = document.Tables[1];
                    Object oMissing = System.Reflection.Missing.Value;
                    int sum = 0;
                    for (int i = 0;i< dataGridView1.Rows.Count-1;i++)
                    {
                        document.Tables[1].Rows.Add(ref oMissing);
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        table.Cell(i+2, 1).Range.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                        table.Cell(i+2, 2).Range.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    }
                    ReplaceWord("{id}", Convert.ToString(sum), document);
                    document.SaveAs(@"D:\Универ\3 сем\БД\Курсач\Res.docx");
                }


                catch
                {
                    MessageBox.Show("Something went wrong.");
                }
                wordApp.Visible = false;
            }
        }

        private void ReplaceWord(string stubReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubReplace, ReplaceWith: text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JudesReport.BackColor = Color.FromArgb(128, 128, 255);
            NationalityReport.BackColor = Color.FromArgb(192, 192, 255);
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(
                @"SELECT  judges.full_name, COUNT(matches.judge_id)* judges.salary_per_match
                    AS Expr1
                    FROM  judges LEFT JOIN matches
                    ON matches.judge_id = judges.judge_id
                GROUP BY judges.full_name, judges.salary_per_match
                ORDER BY Expr1 DESC", sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JudesReport.BackColor = Color.FromArgb(192, 192, 255);
            NationalityReport.BackColor = Color.FromArgb(128, 128, 255);
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(
                @"SELECT  teams.team_name, players.nationality, COUNT(player_id) AS Expr1
                    FROM  teams  RIGHT JOIN  players
                    ON players.team = teams.team_id
                GROUP BY teams.team_name, players.nationality
                ORDER BY teams.team_name, Expr1 DESC", sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }
    }
}

        


