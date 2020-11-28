using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraning.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string Tytle { get; set; }

        public bool IsDone { get; set; }
    }
}
