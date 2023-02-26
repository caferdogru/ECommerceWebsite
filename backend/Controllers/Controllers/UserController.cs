using Controller.Controllers;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Conts.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : CrudController<User, IUserRepository>
    {

        private readonly ILogger<CrudController<User, IUserRepository>> _logger;

        private readonly IUserRepository _userRepository;



        public UserController(
            ILogger<CrudController<User, IUserRepository>> logger,
            IUserRepository userRepository
            ) : base(logger, userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("Login")]

        public bool login(string email, string password)
        {
            bool isTrue = _userRepository.login(email, password);
            return isTrue;
        }



    }
}