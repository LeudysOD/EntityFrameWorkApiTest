using EntityFrameworkApi.Dtos;
using EntityFrameworkApi.Entities;
using EntityFrameworkApi.Repository;
using EntityFrameworkApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevelopersController : ControllerBase
    {
       

        private readonly ILogger<DevelopersController> _logger;
        private readonly IDevelopersServices _developersServices;

        public DevelopersController(ILogger<DevelopersController> logger,IDevelopersServices developersServices)
        {
            _logger = logger;
            _developersServices = developersServices;
        }

        [HttpGet(Name = "GetDevelopers")]
        public Developers Get()
        {
            return _developersServices.GetAll(); 
        }
    }
}