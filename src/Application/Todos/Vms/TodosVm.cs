using System.Collections.Generic;
using CleanArchitecture.Application.Todos.Dtos;

namespace CleanArchitecture.Application.Todos.Vms
{
    public class TodosVm
    {
        public IList<PriorityLevelDto> PriorityLevels { get; set; }

        public IList<TodoListDto> Lists { get; set; }
    }
}