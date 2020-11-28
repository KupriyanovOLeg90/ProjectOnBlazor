using BlazorTraning.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorTraning.Data.Repository
{
    public class SQLRepository : IRepository
    {
        private readonly DB _context;

        public SQLRepository(DB context)
        {
            _context = context;
        }

        public void AddToDo(string ToDoName)
        {
            _context.ToDoItems.Add(new ToDoItem() { Tytle = ToDoName, IsDone = false });
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var tdeletedItem = _context.ToDoItems.Find(id);

            if (tdeletedItem != null)
            {
                _context.ToDoItems.Remove(tdeletedItem);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ToDoItem> GetAllItems()
        {
            return _context.ToDoItems;
        }

        public void ValueChangedItem(ToDoItem changedItem)
        {
            var item = _context.ToDoItems.Attach(changedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
