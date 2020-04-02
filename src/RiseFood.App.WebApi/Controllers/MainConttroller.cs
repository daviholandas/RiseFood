using System;
using System.Linq;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RiseFood.Core.Communication.Mediator;
using RiseFood.Core.Messages.CommonMessages.Notifications;

namespace RiseFood.App.WebApi.Controllers
{
    [ApiController]
    public abstract class MainConttroller : ControllerBase
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediatorHandler;

        protected MainConttroller(INotificationHandler<DomainNotification> notifications, IMediatorHandler mediatorHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatorHandler = mediatorHandler;
        }

        protected bool ValidateOperation() => !_notifications.HaveNotification();

        protected ActionResult CustomResponse(object result = null)
        {
            if(ValidateOperation())
            {
                return Ok(new { success = true, data = result });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifications.GetNotifications().Select(n => n.Value).ToList()
            });
        }

       
    }
}
