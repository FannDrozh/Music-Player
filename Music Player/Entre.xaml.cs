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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Music_Player
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Entre : Window
    {
        public Entre()
        {
            InitializeComponent();
        }
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");//создаём таблицу в приложении
                                                            //подключаемся к БД
            SqlConnection sqlConnection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=MusicPlayer;User=33П;PWD=12357");
            sqlConnection.Open();//открываем БД
            SqlCommand sqlCommand = sqlConnection.CreateCommand();//содаём команду
            sqlCommand.CommandText = selectSQL;//присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);//создаём обработчик
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();//возвращаем таблицу с результатом
            return dataTable;
        }
        private void Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Entree_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt_user = Select("SELECT * FROM [dbo].[Users] Where [Login] = '" + LogV.Text + "' AND [Password] = '" + PasswordV.Text + "'");
            if (dt_user != null)
            {
                MessageBox.Show("Вы есть в базе!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Зарегайся!");
            }
        }

        private void NotAc_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {            
            Registration registration = new Registration();
            registration.Show();
            this.Hide();            
        }
    }
}
