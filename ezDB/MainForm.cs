using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ezDB
{
    public partial class MainForm : Form
    {
        private Form1 databaseSettings;
        OracleHandler oracleHandler;
        MySQLHandler mySqlHandler;
        OracleConnection conn = new OracleConnection();
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(OracleConnection con)
        {
            InitializeComponent();
            conn = con;
        }

        public Form1 DatabaseSettings {
            get { return databaseSettings; }
            set { databaseSettings = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Select * from " + table_nm_txt;
            //conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0));
            }
        }
    }
}
