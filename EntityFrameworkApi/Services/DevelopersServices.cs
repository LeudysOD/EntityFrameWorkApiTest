using AutoMapper;
using EntityFrameworkApi.Dtos;
using EntityFrameworkApi.Entities;
using EntityFrameworkApi.Models;
using EntityFrameworkApi.Repository;

namespace EntityFrameworkApi.Services
{
    public class DevelopersServices: IDevelopersServices
    {
        private readonly IDevelopersRepository _repository;
        private readonly IMapper _mapper;

        public DevelopersServices(IDevelopersRepository repository ,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Developers GetAll()
        {
            var entity = _repository.GetAll();
            
            return entity;
        }
    }
}
