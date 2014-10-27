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
        string username,
               pass,
               language,
               srvrName,
               dbname;

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
            srvrName = txtBx_SrvrName.Text;
            dbname = DBname_text.Text;

            bool open = false;

            //MessageBox.Show(username + "\n" + pass + "\n" + language + "\n" + dbname);

            if (language == "Oracle/SQL") {
                try {
                    using (OracleConnection con = new OracleConnection()) {
                        con.ConnectionString = "User Id=" + username + ";Password=" + pass + ";Data Source=" + srvrName;
                        string sql = "select * from room";
                        using (OracleCommand cmd = new OracleCommand(sql, con)) {
                            cmd.CommandType = CommandType.Text;
                            con.Open();
                            MainForm mainForm = new MainForm();
                            mainForm.DatabaseSettings = this;
                            this.Hide();
                            mainForm.Show();
                            //using (OracleDataReader reader = cmd.ExecuteReader()) {
                            //    while (reader.Read()) {
                            //        Object[] row = new Object[20];
                            //        reader.GetOracleValues(row);
                            //        foreach (Object obj in row) {
                            //            if (obj != null)
                            //                Console.WriteLine(obj.ToString());
                            //            else
                            //                break;
                            //        }
                            //    }
                            //}
                        }
                        con.Close();
                    }
                }
                catch (Exception error) {
                    Console.WriteLine(error.ToString());
                }
            }
            else {
                try {
                    using ( MySqlConnection con = new MySqlConnection() ) {
                        con.ConnectionString = "server=" + srvrName + ";persistsecurityinfo=True;user id=" + username + ";database=" + dbname;
                        string sql = "SELECT * FROM CUSTOMER";
                        using ( MySqlCommand cmd = new MySqlCommand(sql, con) ) {
                            con.Open();
                            //using ( MySqlDataReader reader = cmd.ExecuteReader() ) {
                            //    while ( reader.Read() ) {
                            //        string ACCOUNTID = (string)reader["Name"];
                            //        MessageBox.Show(ACCOUNTID);
                            //    }
                            //}
                        }
                        con.Close();
                    }
                }
                catch (Exception error) {
                    Console.WriteLine(error.ToString());
                }
            }
        }            
    }
}
