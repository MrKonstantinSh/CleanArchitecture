using FluentValidation;

namespace CleanArchitecture.Application.Todos.TodoItems.Commands.CreateTodoItem
{
    public class CreateTodoItemCommandValidator : AbstractValidator<CreateTodoItemCommand>
    {
        public CreateTodoItemCommandValidator()
        {
            RuleFor(t => t.Title)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}