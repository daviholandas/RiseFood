using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiseFood.Catalogo.Application.Commands;
using RiseFood.Core.Mediator;

namespace RiseFood.App.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : MainConttroller
    {
        public ProductsController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }
        
        private readonly IMediatorHandler _mediatorHandler;

        public string GetAllProducts()
        {
            return "funcioandos";
        }
        
        [HttpPost]
        public ActionResult PostProduct(CreateProductCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.ErrorCount);
            }
            _mediatorHandler.SendCommand(command);

            return Ok(command);
        }
    }
}