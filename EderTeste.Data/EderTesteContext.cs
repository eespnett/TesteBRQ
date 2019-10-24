using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EderTeste.Entity;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace EderTeste.Data
{
  public  class EderTesteContext:DbContext
    {

        public EderTesteContext()
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<ContatoCorrente> ContaCorrente { get; set; }

        public DbSet<Contato> Contato { get; set; }

        public DbSet<ContatoCliente> ContatoCliente { get; set; }

        public DbSet<Lancamento> Lancamento { get; set; }

        public DbSet<Log> Log { get; set; }

        public DbSet<Operacao> Operacao { get; set; }

        public DbSet<TipoLancamento> TipoLancameto { get; set; }

        public override DatabaseFacade Database => base.Database;

        public override ChangeTracker ChangeTracker => base.ChangeTracker;

        public override IModel Model => base.Model;

        public override EntityEntry<TEntity> Add<TEntity>([NotNullAttribute] TEntity entity)
        {
            return base.Add(entity);
        }

        public override EntityEntry Add([NotNullAttribute] object entity)
        {
            return base.Add(entity);
        }

        public override Task<EntityEntry<TEntity>> AddAsync<TEntity>([NotNullAttribute] TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.AddAsync(entity, cancellationToken);
        }

        public override Task<EntityEntry> AddAsync([NotNullAttribute] object entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.AddAsync(entity, cancellationToken);
        }

        public override void AddRange([NotNullAttribute] params object[] entities)
        {
            base.AddRange(entities);
        }

        public override void AddRange([NotNullAttribute] IEnumerable<object> entities)
        {
            base.AddRange(entities);
        }

        public override Task AddRangeAsync([NotNullAttribute] params object[] entities)
        {
            return base.AddRangeAsync(entities);
        }

        public override Task AddRangeAsync([NotNullAttribute] IEnumerable<object> entities, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.AddRangeAsync(entities, cancellationToken);
        }

        public override EntityEntry<TEntity> Attach<TEntity>([NotNullAttribute] TEntity entity)
        {
            return base.Attach(entity);
        }

        public override EntityEntry Attach([NotNullAttribute] object entity)
        {
            return base.Attach(entity);
        }

        public override void AttachRange([NotNullAttribute] params object[] entities)
        {
            base.AttachRange(entities);
        }

        public override void AttachRange([NotNullAttribute] IEnumerable<object> entities)
        {
            base.AttachRange(entities);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override EntityEntry<TEntity> Entry<TEntity>([NotNullAttribute] TEntity entity)
        {
            return base.Entry(entity);
        }

        public override EntityEntry Entry([NotNullAttribute] object entity)
        {
            return base.Entry(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override object Find([NotNullAttribute] Type entityType, [CanBeNullAttribute] params object[] keyValues)
        {
            return base.Find(entityType, keyValues);
        }

        public override TEntity Find<TEntity>([CanBeNullAttribute] params object[] keyValues)
        {
            return base.Find<TEntity>(keyValues);
        }

        public override Task<object> FindAsync([NotNullAttribute] Type entityType, [CanBeNullAttribute] params object[] keyValues)
        {
            return base.FindAsync(entityType, keyValues);
        }

        public override Task<object> FindAsync([NotNullAttribute] Type entityType, [CanBeNullAttribute] object[] keyValues, CancellationToken cancellationToken)
        {
            return base.FindAsync(entityType, keyValues, cancellationToken);
        }

        public override Task<TEntity> FindAsync<TEntity>([CanBeNullAttribute] params object[] keyValues)
        {
            return base.FindAsync<TEntity>(keyValues);
        }

        public override Task<TEntity> FindAsync<TEntity>([CanBeNullAttribute] object[] keyValues, CancellationToken cancellationToken)
        {
            return base.FindAsync<TEntity>(keyValues, cancellationToken);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override DbQuery<TQuery> Query<TQuery>()
        {
            return base.Query<TQuery>();
        }

        public override EntityEntry<TEntity> Remove<TEntity>([NotNullAttribute] TEntity entity)
        {
            return base.Remove(entity);
        }

        public override EntityEntry Remove([NotNullAttribute] object entity)
        {
            return base.Remove(entity);
        }

        public override void RemoveRange([NotNullAttribute] params object[] entities)
        {
            base.RemoveRange(entities);
        }

        public override void RemoveRange([NotNullAttribute] IEnumerable<object> entities)
        {
            base.RemoveRange(entities);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override EntityEntry<TEntity> Update<TEntity>([NotNullAttribute] TEntity entity)
        {
            return base.Update(entity);
        }

        public override EntityEntry Update([NotNullAttribute] object entity)
        {
            return base.Update(entity);
        }

        public override void UpdateRange([NotNullAttribute] params object[] entities)
        {
            base.UpdateRange(entities);
        }

        public override void UpdateRange([NotNullAttribute] IEnumerable<object> entities)
        {
            base.UpdateRange(entities);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
