using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezDB
{
    public partial class MainForm : Form
    {
        private Form1 databaseSettings;
        OracleHandler oracleHandler;
        MySQLHandler mySqlHandlre;

        public MainForm()
        {
            InitializeComponent();
        }

        public Form1 DatabaseSettings {
            get { return databaseSettings; }
            set { databaseSettings = value; }
        }
    }
}
