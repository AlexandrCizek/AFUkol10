using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFUkol10.Models
{
    public class Todo
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public Todo(int userId, int id, string title, bool completed)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Completed = completed;
        }
    }
}
