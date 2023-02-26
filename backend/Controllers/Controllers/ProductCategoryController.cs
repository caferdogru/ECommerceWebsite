using Controller.Controllers;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Conts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductCategoryController : CrudController<ProductCategory, IProductCategoryRepository>
    {

        private readonly ILogger<CrudController<ProductCategory, IProductCategoryRepository>> _logger;

        private readonly IProductCategoryRepository _productCategoryRepository;

      

        public ProductCategoryController(
            ILogger<CrudController<ProductCategory, IProductCategoryRepository>> logger,
            IProductCategoryRepository productCategoryRepository
            ) : base(logger, productCategoryRepository)
        {  
            _logger = logger;
            _productCategoryRepository = productCategoryRepository;
        }

    }
}