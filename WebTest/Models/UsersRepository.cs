using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class UsersRepository
    {
        private readonly ApplicationContext context;

        public UsersRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IQueryable<Users> GetUsers()
        {
            return context.users.OrderBy(x => x.LastName);
        }

        public Users GetUserById(Guid id)
        {
            return context.users.Single(x => x.Id == id);
        }

        public Guid SaveUser(Users entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.Id;
        }

        public void DeleteUser(Users entity)
        {
            context.users.Remove(entity);
            context.SaveChanges();
        }
    }
}
