using Domain.Bases.Entities;
using Domain.Bases.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Bases.Repositories
{
    public abstract class BaseReadRepository<TEntity, TId, TContext> : IBaseReadRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TContext : DbContext
    {

        #region Properties

        private readonly TContext _context;
        private readonly ILogger<BaseRepository<TEntity, TId, TContext>> _logger;

        #endregion

        #region Constructors

        public BaseReadRepository(TContext context, ILogger<BaseRepository<TEntity, TId, TContext>> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await CreateSet().AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<TEntity> FindByIdAsync(TId id, CancellationToken cancellationToken)
        {
            return await CreateSet().AsNoTracking().Where(e => e.Id.Equals(id)).FirstOrDefaultAsync(cancellationToken);
        }

        private DbSet<TEntity> CreateSet()
        {
            return _context.Set<TEntity>();
        }

        #endregion
    }
}
