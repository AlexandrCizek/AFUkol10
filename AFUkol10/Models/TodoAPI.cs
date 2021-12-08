using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AFUkol10.Models
{
    public class TodoAPI
    {
        public ObservableCollection<Todo> FetchTodos()
        {
            return new ObservableCollection<Todo>()
            {
                new Todo(1, 1, "Take out the trash", false),
                new Todo(1, 2, "Clean the dishes", true),
                new Todo(1, 3, "Buy christmas gifts", false),
                new Todo(1, 4, "Go jogging", false),
                new Todo(1, 5, "Buy flowers for wife", false)
            };
        }
    }
}
