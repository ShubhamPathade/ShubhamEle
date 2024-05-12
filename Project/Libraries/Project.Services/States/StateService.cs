using Microsoft.EntityFrameworkCore;
using Project.Core.Data;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.States
{
    public class StateService : IStateService
    {
        #region Properties
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public StateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Fileds
        protected IRepository<State> StateRepository
        {
            get => _unitOfWork.GetRepository<State>();
        }
        #endregion
        public async Task<IEnumerable<State>> GetAllSTates()
        {
            return await StateRepository.Table.ToListAsync();
        }

        public async Task InsertState(State state)
        {
            if (state == null)
                throw new ArgumentNullException(nameof(state));

            StateRepository.Insert(state);
            await _unitOfWork.SaveAsync();
        }
    }
}
