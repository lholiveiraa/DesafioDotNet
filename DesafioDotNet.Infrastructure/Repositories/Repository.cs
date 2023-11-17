using DesafioDotNet.Domain.Base;
using DesafioDotNet.Domain.Interfaces;
using DesafioDotNet.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DesafioDotNetDbContext _context;

        public Repository(DesafioDotNetDbContext context) 
        {
            _context = context;
        }

        public virtual async Task<bool> Delete(int id)
        {
            try
            {
                var query = _context.Set<TEntity>().Where(x => x.Id == id);
                if (query.Any()) {
                    var result = query.FirstOrDefault();
                    _context.Remove(result);
                }
                _context.SaveChangesAsync();
                return true;
            }
            catch(Exception) 
            { 
                return false;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var query = _context.Set<TEntity>();

            if(query.Any())
                return query.ToList();

            return new List<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            //throw new NotImplementedException();
            return _context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public virtual void Save(TEntity entity)
        {
            //throw new NotImplementedException();
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            // Adiciona a entidade ao contexto
            _context.Set<TEntity>().Add(entity);

            // Persiste as alterações no banco de dados
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
