using System.Threading.Tasks;
using CleanArchitecture.Application.Todos.TodoLists.Commands.CreateTodoList;
using CleanArchitecture.Application.Todos.TodoLists.Commands.UpdateTodoList;
using CleanArchitecture.Application.Todos.TodoLists.Queries.GetTodoLists;
using CleanArchitecture.Application.Todos.Vms;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUi.Controllers
{
    public class TodoListsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<TodosVm>> Get()
        {
            return await Mediator.Send(new GetTodoListsQuery());
        }
        
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTodoListCommand command)
        {
            return await Mediator.Send(command);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateTodoListCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }
    }
}