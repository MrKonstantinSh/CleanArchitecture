using System.Collections.Generic;
using CleanArchitecture.Domain.ValueObjects;

namespace CleanArchitecture.Domain.Entities.Todo
{
    public class TodoList : BaseEntity
    {
        public string Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public IList<TodoItem> Items { get; set; }
    }
}