
    using Controller.Controllers;
    using DataAccess.Abstract;
    using DataAccess.Concrete;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    namespace Conts.Controllers
    {
    [ApiController]
    [Route("[controller]")]
    public class UserBasketController : CrudController<UserBasket, IUserBasketRepository>
    {

        private readonly ILogger<CrudController<UserBasket, IUserBasketRepository>> _logger;

        private readonly IUserBasketRepository _userBasketRepository ;



        public UserBasketController(
            ILogger<CrudController<UserBasket, IUserBasketRepository>> logger,
            IUserBasketRepository userBasketRepository
            ) : base(logger, userBasketRepository)
        {  
            _logger = logger;
            _userBasketRepository = userBasketRepository;
        }

    }
    }

    