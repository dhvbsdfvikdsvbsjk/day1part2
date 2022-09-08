using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Timers;

namespace day1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int m_counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            var timer = new System.Timers.Timer();
            timer.Interval = 900;
            timer.Elapsed += tim;
            timer.Start();
            while(m_counter < 10)
            {
                refresh.IsEnabled = false;
            }
            
            commit.IsEnabled = false;
        }
        private void tim(object sender, ElapsedEventArgs e)
        {
            m_counter++;
            tets.Dispatcher.Invoke(() =>
            {
                tets.Text = Convert.ToString(m_counter);
            });         
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tets.Text);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                if(tex1.Text == "121")
                {
                    MessageBox.Show("Руководитель отдела по работе с клиентами");
                }
                else if(tex1.Text == "212")
                {
                    MessageBox.Show("Менеджер по работе с клиентами");
                }
                else if (tex1.Text == "313")
                {
                    MessageBox.Show("Руководитель отдела технической поддержки");
                }
                else if (tex1.Text == "414")
                {
                    MessageBox.Show("Специалист технической поддержки");
                }
                else if (tex1.Text == "515")
                {
                    MessageBox.Show("Бухгалтер");
                }
                else if (tex1.Text == "616")
                {
                    MessageBox.Show("Директор по развитию");
                }
                else if (tex1.Text == "717")
                {
                    MessageBox.Show("Сотрудник технического департамента");
                }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            /*tex1.Text = "";
            tex2.Text = "";
            tex3.Text = "";*/
            MessageBox.Show(tex1.Text,tex2.Text);
        }

        private void tex1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (m_counter == 10)
            {
                refresh.IsEnabled = true;
            }

            if (tex2.Text.Length != 0)
            {
                commit.IsEnabled = true;
            }
            if (tex1.Text == "")
            {
                MessageBox.Show("EMPTY");
            }
            string num = tex1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=PC310-15\SQLEXPRESS;Initial Catalog=iof;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tof where номер="+num+"",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("READY");
            }           
            else
            {
                MessageBox.Show("Такого номера сотрудника не существует");
            }
        }
        private void tex2_KeyUp(object sender, KeyEventArgs e)
        {
            string num = tex1.Text;
           /* Regex code = new Regex(@"^[a-zA-Z0-9]{1,8}$");
            Regex passs = new Regex(@"^[0-9]{1,4}$");
            MatchCollection matches = passs.Matches(tex2.Text);*/
            if (e.Key == Key.Enter & tex2.Text.Length != 0 /*& tex2.Text == matches.ToString()*/)
            {
                PassWindow passwordWindow = new PassWindow();

                if (passwordWindow.ShowDialog() == true)
                {
                    if (passwordWindow.Password == "c8DzJeTC9t" || passwordWindow.Password == "rvbrYASYyh" || passwordWindow.Password == "SUTniBMrme"
                        || passwordWindow.Password == "uTZgVwuoHs" || passwordWindow.Password == "v7eerXyUru" || passwordWindow.Password == "YGDS3ds" ||
                        passwordWindow.Password == "Hfd221da")
                    {
                        MessageBox.Show("Авторизация пройдена");
                        tex3.Text = info.io;
                    }                 
                    else
                        MessageBox.Show("Неверный пароль");
                }
                else
                {
                    MessageBox.Show("Авторизация не пройдена");
                }
            }
        }

        private void tex2_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*string num = tex2.Text;
            SqlConnection con = new SqlConnection(@"Data Source=PC310-15\SQLEXPRESS;Initial Catalog=iof;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tof where пароль=" + num + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][1].ToString() == "2")
            {
                MessageBox.Show("READY");
            }
            else
            {
                MessageBox.Show("Такого номера сотрудника не существует");
            }*/
        }
    }
}
