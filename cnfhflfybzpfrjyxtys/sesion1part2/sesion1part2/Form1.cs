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

namespace sesion1part2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC310-15\SQLEXPRESS;Initial Catalog=abonent;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentDataSet1.roboo". При необходимости она может быть перемещена или удалена.
            this.robooTableAdapter.Fill(this.abonentDataSet1.roboo);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query2 = $"INSERT INTO [dbo].[ababa]([типОборудывания],[адресАбонента],[порт]" +
               $",[типПорта],[ip-адрес],[мас-адрес]" +
               $",[Абонент]) " +
               $"values ('" + типTextBox.Text + "','" + адресTextBox.Text + "','" + (Convert.ToInt32(колВоПортовTextBox.Text) + 1).ToString() + "','" + типПортовTextBox.Text + "'" +
               ",'" + ip_адресTextBox.Text + "','" + мас_адресTextBox.Text + "','" + textBox1.Text + "')";
            SqlCommand Command2 = new SqlCommand(Query2, con);
            Command2.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено в бд");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string que = $"insert into [dbo].[asa]([точкаПодключения],[переченьОборудывания],[портИадрес],[наКарте])" +
                $"values ('" + точкаПодключенияTextBox.Text + "','" + типTextBox.Text + "','" + типПортовTextBox.Text + "','" + "178.79.17"+ "')"; 
            SqlCommand com = new SqlCommand(que, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлено в бд");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
