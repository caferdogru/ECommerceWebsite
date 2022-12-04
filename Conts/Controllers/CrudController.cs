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

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }


        [HttpGet]
        [Route("Get")]

        public T Get([FromQuery] int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        [Route("Create")]
        public T Create([FromBody] T model)
        {
            return _repository.Create(model);
        }

        [HttpPost]
        [Route("Update")]
        public T Update([FromBody] T model)
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
