using AFUkol10.Models;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace AFUkol10.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly TodoAPI API = new TodoAPI();
        [Reactive]
        public ObservableCollection<Todo> Todos { get; set; }
        [Reactive]
        public Todo SelectedTodo { get; set; }

        public void GetTodos()
        {
            if(Todos != null){
                Todos.Clear();
            }
            Todos = API.FetchTodos();
            SelectedTodo = Todos.First();
        }
    }
}
