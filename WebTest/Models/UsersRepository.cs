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

        public IQueryable<UsersModel> GetArticles()
        {
            return context.Users.OrderBy(x => x.Fu);
        }

        public UsersModel GetArticleById(Guid id)
        {
            return context.Users.Single(x => x.Id == id);
        }

        public Guid SaveArticle(UsersModel entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.Id;
        }

        public void DeleteArticle(UsersModel entity)
        {
            context.Users.Remove(entity);
            context.SaveChanges();
        }
    }
}
