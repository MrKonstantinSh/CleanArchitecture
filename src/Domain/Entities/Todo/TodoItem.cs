using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;
using CleanArchitecture.Domain.Events;

namespace CleanArchitecture.Domain.Entities.Todo
{
    public class TodoItem : BaseEntity, IHasDomainEvent
    {
        private bool _done;

        public TodoItem()
        {
            DomainEvents = new List<DomainEvent>();
        }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public PriorityLevel Priority { get; set; }

        public DateTime? Reminder { get; set; }

        public bool Done
        {
            get => _done;
            set
            {
                if (value && _done == false)
                {
                    DomainEvents.Add(new TodoItemCompletedEvent(this));
                }

                _done = value;
            }
        }

        public TodoList List { get; set; }

        public IList<DomainEvent> DomainEvents { get; set; }
    }
}