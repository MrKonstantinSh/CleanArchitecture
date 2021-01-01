using System.Threading.Tasks;
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
    }
}