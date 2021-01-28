using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities.Todo;

namespace CleanArchitecture.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}