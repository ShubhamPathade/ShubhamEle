using Microsoft.EntityFrameworkCore;
using Project.Core.Data;
//using Project.Core.Domain.Notifications;
using System;
using System.Threading.Tasks;

namespace Project.Services.Notifications
{
    public class MessageTemplateService : IMessageTemplateService
    {
        //#region Fields

        //private readonly IUnitOfWork _unitOfWork;

        //#endregion

        //#region Constructor

        //public MessageTemplateService(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        //#endregion

        //#region Properties

        //public IRepository<MessageTemplate> MessageTemplateRepository
        //{
        //    get => _unitOfWork.GetRepository<MessageTemplate>();
        //}

        //#endregion

        //#region Methods

        //public async Task<MessageTemplate> GetMessageTemplateAsync(string templateName)
        //{
        //    if (string.IsNullOrWhiteSpace(templateName))
        //        throw new ArgumentNullException();

        //    var query = MessageTemplateRepository.Table;
        //    var template = await query.FirstOrDefaultAsync(template => template.Name.Equals(templateName));
        //    return template;
        //}

        //#endregion
    }
}
