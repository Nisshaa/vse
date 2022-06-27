using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test2.forms;


namespace test2
{
    public partial class Mer : Form
    {
        Connect con = new Connect();
        

        public Mer()
        {
            InitializeComponent();
        }

        private void Mer_Load(object sender, EventArgs e)
        {
            string qwery = "select * from meropr";
            dataGridView1.DataSource = con.CO(qwery).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            awf f1 = new awf();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO meropr( Событие, Город) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            con.SIDU(sql);
            MessageBox.Show("Запись добавлена");
        }

    }
}


