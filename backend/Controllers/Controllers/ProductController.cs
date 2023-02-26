using Controller.Controllers;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Conts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : CrudController<Product, IProductRepository>
    {

        private readonly ILogger<CrudController<Product, IProductRepository>> _logger;

        private readonly IProductRepository _productRepository;



        public ProductController(
         ILogger<CrudController<Product, IProductRepository>> logger,
         IProductRepository productRepository
         ) : base(logger, productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }


        [HttpGet]
        [Route("GetProductByCategory")]

        public IEnumerable<Product> GetByCategoryId(int categoryId)
        {
            return _productRepository.GetProductByCategory(categoryId);
        }

    }
}