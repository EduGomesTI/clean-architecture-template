using Domain.Bases.Entities;
using Domain.Bases.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Bases.Repositories
{
    public abstract class BaseWriteRepository<TEntity, TId, TContext> : IBaseWriteRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TContext : DbContext
    {
        #region Properties

        private readonly TContext _context;
        private readonly ILogger<BaseRepository<TEntity, TId, TContext>> _logger;

        #endregion

        #region Constructors

        private BaseWriteRepository(TContext context, ILogger<BaseRepository<TEntity, TId, TContext>> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Methods

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await CreateSet().AddAsync(entity, cancellationToken);

            var result = await _context.SaveChangesAsync(cancellationToken);

            if (result == 0)
            {
                _logger.LogError("Ocorreu um erro ao inserir o objeto no banco");
                entity.AddMessage("Erro: Objeto não persistido no banco de dados");
            }

            return entity;
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            CreateSet().Remove(entity);

            var result = await _context.SaveChanges();

            if (result == 0)
                _logger.LogWarning("Ocorreu um erro ao excluir o objeto no banco");  
        }

        public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private DbSet<TEntity> CreateSet()
        {
            return _context.Set<TEntity>();
        }

        #endregion

    }
}
