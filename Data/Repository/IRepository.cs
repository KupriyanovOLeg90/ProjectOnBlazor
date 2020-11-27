using BlazorToDoListTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoListTest.Data.Repository
{
    public interface IRepository 
    {
        public IEnumerable<ToDoItem> GetAllItems();

        public void AddToDo(string ToDoName);

        public void ValueChangedItem(ToDoItem changedItem);

        public void DeleteItem(int id);
    }
}
