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

namespace Connect
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HOME-PC\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                btn_connect.Text = "Disconnect";
                lbl_result.Text = "Connection open";
                return;
            }
            conn.Close();
            btn_connect.Text = "Connect";
            lbl_result.Text = "Connection closed";
        }
    }
}
