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

namespace ymriteXyesosi
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-B9NL3QIJ\SQLEXPRESS;Initial Catalog=abonent;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborDataSet2.roboo". При необходимости она может быть перемещена или удалена.
            this.robooTableAdapter1.Fill(this.oborDataSet2.roboo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborDataSet1.roboo". При необходимости она может быть перемещена или удалена.
            this.robooTableAdapter.Fill(this.oborDataSet1.roboo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborDataSet.robo". При необходимости она может быть перемещена или удалена.
            this.roboTableAdapter.Fill(this.oborDataSet.robo);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query2 = $"INSERT INTO [dbo].[ababa]([типОборудывания],[адресАбонента],[порт]" +
               $",[типПорта],[ip-адрес],[мас-адрес]" +
               $",[Абонент]) " +
               $"values ('" + типTextBox.Text + "','" + адресTextBox.Text + "','" + (Convert.ToInt32(колВоПортовTextBox.Text) + 1).ToString() + "','" + типПортовTextBox.Text + "'" +
               ",'" + ip_адресTextBox.Text + "','" + mac_адрес12цифрTextBox.Text + "','" + textBox1.Text + "')";
            SqlCommand Command2 = new SqlCommand(Query2, con);
            Command2.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено в бд");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string que = $"insert into [dbo].[asa]([точкаПодключения],[переченьОборудывания],[портИадресподключения],[наКарте])" +
                $"values ('"+ точкаПодключенияTextBox.Text + "','"+ типTextBox.Text + "','"+ типПортовTextBox.Text + "','"+"178.79.147.17"+"')";
            SqlCommand com = new SqlCommand(que, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено в бд");
        }
    }
}
