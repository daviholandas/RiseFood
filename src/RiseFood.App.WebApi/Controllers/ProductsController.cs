using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RiseFood.Catalogo.Application.Commands;
using RiseFood.Core.Communication.Mediator;
using RiseFood.Core.Messages.CommonMessages.Notifications;

namespace RiseFood.App.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : MainConttroller
    {
        public ProductsController(INotificationHandler<DomainNotification> notifications, IMediatorHandler mediatorHandler)
            :base(notifications, mediatorHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatorHandler = mediatorHandler;
        }
        
        private readonly IMediatorHandler _mediatorHandler;
        private readonly DomainNotificationHandler _notifications;

        public string GetAllProducts()
        {
            return "funcioandos";
        }
        
        [HttpPost]
        public ActionResult PostProduct(CreateProductCommand command)
        {
            if (!ValidateOperation())
            {
                return CustomResponse(command);
            }
            _mediatorHandler.SendCommand(command);

            var product = new
            {
                code = command.Code,
                name = command.Name,
                price = command.Price,
                descripton = command.Description

            };
            return CustomResponse(command);
        }

        [HttpPost]
        [Route("categories")]
        public ActionResult PostCategory(CreateCategoryCommand categoryCommand)
        {
            if (!ValidateOperation())
            {
                return CustomResponse(categoryCommand);
            }

            _mediatorHandler.SendCommand(categoryCommand);

            
            return CustomResponse(new { code = categoryCommand.Code, name = categoryCommand.Name });
            
        }
    }
}