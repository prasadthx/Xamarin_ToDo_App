using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ToDo
{
    public class ToDoListViewModel
    {

        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public ToDoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("First Todo", true));
        }
    }
}