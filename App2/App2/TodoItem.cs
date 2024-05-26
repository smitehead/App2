using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    [Table("TodoItems")]
    public class TodoItem
    {

        [PrimaryKey, AutoIncrement, Column("TodoItemId")]
        public int Id
        {
            get; set;
        }

        public DateTime TimeTodo
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }
    }
}