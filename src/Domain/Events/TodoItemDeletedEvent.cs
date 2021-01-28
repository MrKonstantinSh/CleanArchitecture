using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities.Todo;

namespace CleanArchitecture.Domain.Events
{
    public class TodoItemDeletedEvent : DomainEvent
    {
        public TodoItemDeletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}