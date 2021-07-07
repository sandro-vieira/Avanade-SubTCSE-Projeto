﻿using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repository.Base
{
    public abstract class BaseRepository<TEntity, Tid> : IBaseRepository<TEntity, Tid> 
        where TEntity : BaseEntity<Tid>
    {
        private readonly IMongoCollection<TEntity> _mongoCollection;

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _mongoCollection.InsertOneAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> FindById(Tid id)
        {
            throw new System.NotImplementedException();
        }
    }
}
