using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISYS4363GroupProject
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=essql1.walton.uark.edu; Initial Catalog=PROJECTF2101;User ID=PROJECTF2101;Password=EU79sgo$";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        string accountNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_CreateAcct_Click(object sender, EventArgs e)
        {
            AccountPanel.Visible = true;
            MenuPanel.Visible = false;
            ReportPanel.Visible = false;
            AccountPanel.Dock = DockStyle.Fill;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            AccountPanel.Visible = false;
            MenuPanel.Visible = false;
            LoginPanel.Visible = true;
            LoginPanel.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 880;
            this.Height = 765;

            MenuPanel.Visible = true;
            MenuPanel.Dock = DockStyle.Fill;
            AccountPanel.Visible = false;
            ReportPanel.Visible = false;
            LoginPanel.Visible = false;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "SELECT username, AccountPassword, AccountID FROM Account WHERE AccountID = (SELECT AccountID FROM Account WHERE username = '" + TxtBox_Username.Text + "' AND AccountPassword = '" + TxtBox_Password.Text + "')";
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            if (datareader.HasRows)
            {
                while (datareader.Read())
                {
                    if (datareader[0].ToString() == TxtBox_Username.Text && datareader[1].ToString() == TxtBox_Password.Text)
                    {
                        accountNumber = datareader[2].ToString();
                        AccountPanel.Visible = false;
                        MenuPanel.Visible = false;
                        ReportPanel.Visible = true;
                        TxtBox_Username.Clear();
                        TxtBox_Password.Clear();
                        MessageBox.Show("Welcome!");
                    }

                    else
                    {
                        MessageBox.Show("Login information is incorrect. Please try again.");
                        TxtBox_Username.Clear();
                        TxtBox_Password.Clear();
                    }
                    connection.Close();
                    command.Dispose();
                    datareader.Close();
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ReportPanel.Visible = true;
            MenuPanel.Visible = false;
            AccountPanel.Visible = false;
            ReportPanel.Dock = DockStyle.Fill;
        }

        private void Btn_CASubmit_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "INSERT INTO Accounts (Name, Email, Username, AccountPassword) VALUES (@name, @em, @user, @pw)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", TxtBox_Name.Text);
            command.Parameters.AddWithValue("@em", TxtBox_Email.Text);
            command.Parameters.AddWithValue("@user", TxtBox_Username.Text);
            command.Parameters.AddWithValue("@pw", TxtBox_Password.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Account creation was successful!");
            connection.Close();
            command.Dispose();
            AccountPanel.Visible = false;
            MenuPanel.Visible = true;
            ReportPanel.Visible = false;
            LoginPanel.Visible = false;


        }

        private void Label_MRTool_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
            MenuPanel.Dock = DockStyle.Fill;
            AccountPanel.Visible = false;
            ReportPanel.Visible = false;
            LoginPanel.Visible = false;
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "SELECT Email, AccountPassword, AccountID FROM Accounts WHERE AccountID = (SELECT AccountID FROM Accounts WHERE email = '" + txtLoginEmail.Text + "' AND AccountPassword = '" + txtLoginPassword.Text + "')";
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();

            if (datareader.HasRows)
            {
                while (datareader.Read())
                {

                    if (datareader[0].ToString() == txtLoginEmail.Text && datareader[1].ToString() == txtLoginPassword.Text)
                    {
                        accountNumber = datareader[2].ToString();
                        MessageBox.Show("Welcome!");
                        LoginPanel.Visible = false;
                        ReportPanel.Visible = true;
                        ReportPanel.Dock = DockStyle.Fill;

                        txtLoginEmail.Clear();
                        txtLoginPassword.Clear();
                    }

                }
            }
            else
            {
                MessageBox.Show("Login information was incorrect. Please try again or return to the main menu.");
                txtLoginEmail.Clear();
                txtLoginPassword.Clear();
            }

            connection.Close();
            command.Dispose();
            datareader.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Movie_Title.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Movie_Rating.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Movie_Directors.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Movie_Actors.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Movie_Genre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Movie_Metascore.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            var sql2 = "SELECT Name, MovieRating, Directors, Stars, MovieGenre, Metascore FROM Run_Results$ WHERE Name LIKE '" + TxtBox_Search.Text + "%'";
                var da = new SqlDataAdapter(sql2, connection);
                var ds = new DataSet();
                da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PicBox_Report_Click(object sender, EventArgs e)
        {

        }
    }
    }
