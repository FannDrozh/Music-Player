using System;
using System.Collections.Generic;
using System.Data;
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

namespace Music_Player
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    
    public partial class Registration : Window
    {
        
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
        public Registration()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server=ngknn.ru;Trusted_Connection=No;DataBase=MusicPlayer;User=33П;PWD=12357");
            sqlConnection.Open();//открываем БД 
            //Добавление новых данных данных
            string script = "INSERT INTO [dbo].[Users] (Nik, Login, Password) VALUES(@nik, @login, @password)";
            SqlCommand cmd = new SqlCommand(script, sqlConnection);            
            cmd.Parameters.AddWithValue("@nik", Nik.Text);
            cmd.Parameters.AddWithValue("@login", Login.Text);
            cmd.Parameters.AddWithValue("@password", Password.Text);
            cmd.ExecuteNonQuery();
            if (Nik.Text != "" && Login.Text != "" && Password.Text != "")
            {
                MessageBox.Show("Вы зарегистрировались\n можете входить в SmashUp!\n Желаем пркрасного использования!");
                Entre entre = new Entre();
                entre.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Запоните все поля!");
            }
                       
        }

        private void Image_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            Entre entre = new Entre();
            entre.Show();
            this.Close();
        }
    }
}
