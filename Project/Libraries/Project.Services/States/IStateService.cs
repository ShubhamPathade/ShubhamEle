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
        Task<IEnumerable<State>> GetAllSTates();
    }
}
