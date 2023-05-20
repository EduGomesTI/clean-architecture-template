using Domain.Bases.Entities;
using Domain.Bases.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Bases.Repositories
{
    public abstract class BaseRepository<TEntity, TId, TContext> : IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TContext : DbContext
    {

        #region Properties

        private readonly TContext _context;
        private readonly ILogger<BaseRepository<TEntity, TId, TContext>> _logger;

        #endregion

        #region Constructors

        private BaseRepository(TContext context, ILogger<BaseRepository<TEntity, TId, TContext>> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Methods



        #endregion
    }
}
