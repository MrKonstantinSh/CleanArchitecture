using System.Collections.Generic;
using CleanArchitecture.Domain.ValueObjects;

namespace CleanArchitecture.Domain.Entities.Todo
{
    public class TodoList : BaseEntity
    {
        public TodoList()
        {
            Colour = Colour.White;
            Items = new List<TodoItem>();
        }
        
        public string Title { get; set; }

        public Colour Colour { get; set; }

        public IList<TodoItem> Items { get; set; }
    }
}