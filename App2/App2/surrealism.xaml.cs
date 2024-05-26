using MySql.Data.MySqlClient;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App2
{
    public partial class surrealism : ContentPage
    {
        string connStr = "Server=localhost;Database=mydatabase;Uid=username;Pwd=password;"; // MySQL 연결 문자열
        MySqlConnection conn;
        MySqlCommand cmd;

        ObservableCollection<User> Users { get; set; }

        public surrealism()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>();
            listView.ItemsSource = Users;

            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            RefreshListView();
        }

        private void RefreshListView()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM users"; // MySQL 쿼리: users 테이블에서 모든 열 선택
                MySqlDataReader reader = cmd.ExecuteReader();

                Users.Clear();
                while (reader.Read())
                {
                    var user = new User
                    {
                        Id = reader.GetString("id"),
                        Name = reader.GetString("name"),
                        Email = reader.GetString("email"),
                        BirthYear = reader.GetInt32("birthYear").ToString()
                    };
                    Users.Add(user);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                DisplayAlert("오류", "데이터를 가져오는 동안 오류가 발생했습니다: " + ex.Message, "확인");
            }
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string BirthYear { get; set; }

        public string Detail => $"{Email}, {BirthYear}";
    }
}
