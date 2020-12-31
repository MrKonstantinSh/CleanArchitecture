namespace CleanArchitecture.Domain.Entities.Todo
 {
     public class TodoItem : BaseEntity
     {
         public string Title { get; set; }
 
         public string Note { get; set; }
 
         public TodoList List { get; set; }
     }
 }