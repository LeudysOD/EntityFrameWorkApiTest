using EntityFrameworkApi.Context;
using EntityFrameworkApi.Entities;
using EntityFrameworkApi.Models;

namespace EntityFrameworkApi.Repository
{
    public class DevelopersRepository:IDevelopersRepository
    {
        private readonly EntityFrameworkContext _context;
        public DevelopersRepository(EntityFrameworkContext context) => _context = context;

        s
        public Developers GetAll()
        {
            var entity = _context.Developers.FirstOrDefault();
            return entity;
        }
        

    }
}
