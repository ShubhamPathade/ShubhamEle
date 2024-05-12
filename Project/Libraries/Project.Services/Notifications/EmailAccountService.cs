using Microsoft.EntityFrameworkCore;
using Project.Core.Data;
//using Project.Core.Domain.Notifications;
using System.Threading.Tasks;

namespace Project.Services.Notifications
{
    public class EmailAccountService : IEmailAccountService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Properties

        //public IRepository<EmailAccount> EmailAccountRepository
        //{
        //    get => _unitOfWork.GetRepository<EmailAccount>();
        //}

        #endregion

        #region Constructor

        public EmailAccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        //public async Task<EmailAccount> GetDefaultEmailAccountAsync()
        //{
        //    var emailAccount = await EmailAccountRepository.Table.FirstOrDefaultAsync(account => account.IsDefault);
        //    return emailAccount;
        //}

        #endregion
    }
}
