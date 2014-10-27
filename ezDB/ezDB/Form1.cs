using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using MySql.Data.MySqlClient;

namespace ezDB
{
    public partial class Form1 : Form
    {
        string username;
        string pass;
        string language;
        string dbname;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "Oracle/SQL", Value = "SQL" });
            dataSource.Add(new Language() { Name = "MySQL", Value = "MySQL" });

            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cnnt_btn_Click(object sender, EventArgs e)
        {
            username = User_text.Text;
            pass = Pass_text.Text;
            language = comboBox1.Text;
            dbname = DBname_text.Text;

            MessageBox.Show(username + "\n" + pass + "\n" + language + "\n" + dbname);


            if (language == "Oracle/SQL")
            {
                try
                {
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = "User Id=" + username + ";Password=" + pass + ";Data Source=" + dbname;
                    con.Open();
                    Console.WriteLine("Connected to Oracle" + con.ServerVersion);
                    string sql = "Select * from Customer";
                    
                    OracleCommand command = new OracleCommand(sql,con);//con.CreateCommand();
                    command.CommandType = CommandType.Text;
                    OracleDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        string ACCOUNTID = (string)reader["ACCOUNTID"];
                        MessageBox.Show(ACCOUNTID);
                    }
                    con.Close();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = "server=" + dbname + ";persistsecurityinfo=True;user id=" + username + ";database=hotel";
                    con.Open();
                    Console.WriteLine("Connected to MySQL " + con.ServerVersion);
                    MySqlCommand command = new MySqlCommand();
                    string sql = "SELECT * FROM CUSTOMER";
                    command.CommandText = sql;
                    command.Connection = con;
                    Console.WriteLine("connection is: "+con.State);
                    MySqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        string ACCOUNTID = (string)reader["Name"];
                        MessageBox.Show(ACCOUNTID);
                    }
                    con.Close();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
        }
            
    }
}
