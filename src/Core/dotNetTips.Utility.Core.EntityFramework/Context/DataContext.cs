// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-21-2017
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2018
// ***********************************************************************
// <copyright file="DataContext.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Utility.Core.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace dotNetTips.Utility.Core.EntityFramework.Context
{
    /// <summary>
    /// DataContext base class.
    /// </summary>
    /// <remarks>
    /// Records are marked as deleted, never actually deleted
    /// from the database. Dates contain timezone information.
    /// Created and updated dates are saved as UTC.
    /// </remarks>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Updates the entities.
        /// </summary>
        private void UpdateEntities()
        {
            if (this.ChangeTracker.HasChanges() == false)
            {
                return;
            }

            foreach (var entry in this.ChangeTracker.Entries<IDataEntity>().Where(p => p.State != EntityState.Unchanged))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;

                    if (entry.Entity.PublicKey == null || entry.Entity.PublicKey == Guid.Empty)
                    {
                        entry.Entity.PublicKey = Guid.NewGuid();
                    }
                }
                else
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.</remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Setup properties
            modelBuilder.Entity<DataEntity>().Property(p => p.CreatedAt).ValueGeneratedOnAdd().IsRequired();
            modelBuilder.Entity<DataEntity>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<DataEntity>().Property(p => p.PublicKey).ValueGeneratedOnAdd().IsRequired();
            modelBuilder.Entity<DataEntity>().Property(p => p.UpdatedAt).ValueGeneratedOnAddOrUpdate().IsRequired();
            modelBuilder.Entity<DataEntity>().Property(p => p.Version).ValueGeneratedOnAddOrUpdate();

            //Setup Indexes
            modelBuilder.Entity<DataEntity>().HasIndex(p => p.PublicKey).IsUnique();

            //Setup keys
            modelBuilder.Entity<DataEntity>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>The number of state entries written to the underlying database. This can include
        /// state entries for entities and/or relationships. Relationship state entries are created for
        /// many-to-many relationships and relationships where there is no foreign key property
        /// included in the entity class (often referred to as independent associations).</returns>
        /// <remarks>This method will automatically call <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.DetectChanges" /> to discover any
        /// changes to entity instances before saving to the underlying database. This can be disabled via
        /// <see cref="P:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AutoDetectChangesEnabled" />.</remarks>
        public override int SaveChanges()
        {
            UpdateEntities();

            return base.SaveChanges();
        }

        /// <summary>
        /// Asynchronously saves all changes made in this context to the underlying database.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous save operation.
        /// The task result contains the number of state entries written to the underlying database. This can include
        /// state entries for entities and/or relationships. Relationship state entries are created for
        /// many-to-many relationships and relationships where there is no foreign key property
        /// included in the entity class (often referred to as independent associations).</returns>
        /// <remarks><para>
        /// This method will automatically call <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.DetectChanges" /> to discover any
        /// changes to entity instances before saving to the underlying database. This can be disabled via
        /// <see cref="P:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AutoDetectChangesEnabled" />.
        /// </para>
        /// <para>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </para></remarks>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            UpdateEntities();

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
