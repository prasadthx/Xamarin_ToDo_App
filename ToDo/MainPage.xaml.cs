using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void TextChangeHandler(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }

        private void EntryCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Enter pressed");
            Label newTodo = new Label();
            newTodo.Text = InputField.Text;
            Console.WriteLine(InputField.Text);
            ToDoList.Children.Add(newTodo);
            InputField.Text = "";
        }
    }
}
