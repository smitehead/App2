using App2;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    [DesignTimeVisible(false)]
    public partial class portraitpainting : ContentPage
    {
        SQLiteAsyncConnection conn;
        ObservableCollection<TodoItem> todos;

        public portraitpainting()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();

            // todos 컬렉션을 초기화합니다.
            todos = new ObservableCollection<TodoItem>();
        }

        protected override async void OnAppearing()
        {
            Debug.WriteLine("Debug --------> OnAppearing");
            await conn.CreateTableAsync<TodoItem>();

            var tds = await conn.Table<TodoItem>().ToListAsync();
            todos = new ObservableCollection<TodoItem>(tds);
            lv_todo.ItemsSource = todos;

            base.OnAppearing();
        }

        public ObservableCollection<TodoItem> Todos
        {
            get { return todos; }
            set { todos = value; }
        }

        private async void btn_todo_new_Clicked(object sender, EventArgs e)
        {
            var todo = new TodoItem
            {
                TimeTodo = DateTime.Now,
                Title = et_todo_new.Text
            };

            await conn.InsertAsync(todo);
            OnAppearing();

            et_todo_new.Text = "";
        }

        private async void btn_todo_modify_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TodoItem todoItem = (TodoItem)(btn.BindingContext);
            todoItem.TimeTodo = DateTime.Now;
            int result = await conn.UpdateAsync(todoItem);

            if (result == 1)
            {
                await DisplayAlert("Modify", "Data has changed.", "confirm");
                OnAppearing();
            }
        }

        private async void btn_todo_delete_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TodoItem todoItem = (TodoItem)(btn.BindingContext);
            Task<bool> result = this.DisplayAlert("Delete", "Do you want to delete?", "Yes", "No");

            if (await result)
            {
                await conn.DeleteAsync(todoItem);
                OnAppearing();
            }
        }
    }
}
