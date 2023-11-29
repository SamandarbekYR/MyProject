using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess.AppDbContext;
using MyProject.DataAccess.Interfaces;
using MyProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private DbSet<TEntity> _repos;

        public Repository(AppDb appDb) 
        { 
            this._repos = appDb.Set<TEntity>();
        }
        public void Add(TEntity tentiy)
            => this._repos.Add(tentiy);

        public TEntity GetById(Guid id)
            => _repos.First(x => x.Id == id);
    }
}
