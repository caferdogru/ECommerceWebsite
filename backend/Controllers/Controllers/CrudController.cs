using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController<T, TRepository> : ControllerBase where T : class where TRepository : ICrudRepository<T>
    {



        private readonly ILogger<CrudController<T, TRepository>> _logger;

        private readonly TRepository _repository;

        public CrudController(
            ILogger<CrudController<T, TRepository>> logger,
            TRepository crudRepository
            )
        {
            _logger = logger;
            _repository = crudRepository;
        }

        [HttpGet]
        [Route("GetAll")]

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.GetAll();
        }


        [HttpGet]
        [Route("Get")]

        public Task<T> Get([FromQuery] int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        [Route("Create")]
        public Task<T> Create([FromBody] T model)
        {
            return _repository.Create(model);
        }

        [HttpPost]
        [Route("Update")]
        public Task<T> Update([FromBody] T model)
        {
            return _repository.Update(model);
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete([FromQuery] int id)
        {
            _repository.Delete(id);
        }
    }
}
