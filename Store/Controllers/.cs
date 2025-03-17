using Application.DomainService.ProductBrands.Commands;
using Application.DomainService.ProductBrands.Query.GetAll;
using Application.DomainService.Products.Query.Get;
using Application.DomainService.Products.Query.GetAll;
using Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class ProductBrandController : BaseController
    {
        public ProductBrandController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await Mediator.Send(new GetAllProductBrandQuery());
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetBiyId(int id)
        {
            var result = await Mediator.Send(new GetProductQuery(id));
            return Ok(result);
        }
        [HttpPost("createbrand")]
        public async Task<ActionResult> CreateBrand([FromBody]ProductBrandDto brand)
        {
            var command = new CreateProductBrandCommand
            {
                Title = brand.Title
            };
            var result = await Mediator.Send(command);
            return Ok(result);
        }

    }
}
