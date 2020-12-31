using System.Collections.Generic;

namespace CleanArchitecture.Domain.Entities.Todo
{
    public class TodoList : BaseEntity
    {
        public string Title { get; set; }

        public IList<TodoItem> Items { get; set; }
    }
}