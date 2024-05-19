using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Common;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.States
{
    public interface IStateService
    {
        Task InsertState(State state);
        Task<State> GetState(long stateId);
        Task<IEnumerable<State>> GetAllSTates();
        Task<IEnumerable<SelectListItem>> PrepareStateDropDown();
        
    }
}
