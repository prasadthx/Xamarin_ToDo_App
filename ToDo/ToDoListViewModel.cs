using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDo
{
    public class ToDoListViewModel
    {

        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public string NewToDoInputValue { get; set; }
        public ToDoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("First Todo", true));
        }

        public ICommand AddToDoCommand => new Command(AddToDoItem);

        void AddToDoItem()
        {
            TodoItems.Add(new TodoItem(NewToDoInputValue, false));
        }

        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);

        void RemoveToDoItem(object o)
        {
            TodoItem itemToBeRemoved = o as TodoItem;
            TodoItems.Remove(itemToBeRemoved);
            Console.WriteLine("Removed");
        }

    }
}