using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Blades;
using Domain;
using NHibernate;
using NHibernate.Linq;

namespace DataAccess
{
    public class RepositoryBase<TEntity> : ICRUDRepository<TEntity>
        where TEntity : EntityBase, new()
    {
        #region ICRUDRepository<TEntity> Members

        public TEntity Create(TEntity entity)
        {
            using (ISession session = GetSession())
            {
                session.Save(entity);
                session.Flush();
            }

            return entity;
        }

        public TEntity Retrieve(Guid entityId)
        {
            using (ISession session = GetSession())
            {
                IQueryable<TEntity> result = from ent in session.Linq<TEntity>()
                                             where ent.Id == entityId
                                             select ent;

                return result.Distinct().SingleOrDefault();
            }
        }

        public IList<TEntity> RetrieveAll()
        {
            using (ISession session = GetSession())
            {
                return session.Linq<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (ISession session = GetSession())
            {
                session.Update(entity);
                session.Flush();
            }
        }

        public void Delete(TEntity entity)
        {
            using (ISession session = GetSession())
            {
                session.Delete(entity);
                session.Flush();
            }
        }

        #endregion

        protected ISession GetSession()
        {
            return NHConfig.GetSession();
        }
    }
}