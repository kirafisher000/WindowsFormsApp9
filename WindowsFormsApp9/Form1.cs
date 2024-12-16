using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        DB_Library db = new DB_Library(@"Data Source=DESKTOP-1T4V3C1\SQLEXPRESS;Initial Catalog=DB_Library;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            var custquery = db.Find_readers_book(a);
            List<Find_readers_bookResult> test = new List<Find_readers_bookResult>();
            string msg = "";
            foreach (Find_readers_bookResult Procedure in custquery)
            {
                test.Add(Procedure);
            }
            dataGridView1.DataSource = test;
            textBox1.Text = "";

        }
    }
}
