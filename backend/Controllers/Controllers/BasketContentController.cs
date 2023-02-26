
    using Controller.Controllers;
    using DataAccess.Abstract;
    using DataAccess.Concrete;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    namespace Conts.Controllers
    {
    [ApiController]
    [Route("[controller]")]
    public class BasketContentController : CrudController<BasketContent, IBasketContentRepository>
    {

        private readonly ILogger<CrudController<BasketContent, IBasketContentRepository>> _logger;

        private readonly IBasketContentRepository _basketContentRepository ;



        public BasketContentController(
            ILogger<CrudController<BasketContent, IBasketContentRepository>> logger,
            IBasketContentRepository basketContentRepository
            ) : base(logger, basketContentRepository)
        {  
            _logger = logger;
            _basketContentRepository = basketContentRepository;
        }

    }
    }

    