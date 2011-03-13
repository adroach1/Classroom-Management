using System;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Linq;


namespace ClassTracker.Data
{
	public class NHibernateRepository : IRepository
	{

		public NHibernateRepository()
		{
			_session = this.NHSsession;
		}

		private readonly ISession _session;

		public ISession NHSsession 
		{
			get 
			{ 
				return _session; 
			}
		}

		public T Load<T>(object primaryKey)
		{
			return _session.Load<T>(primaryKey);
		}

		public T Get<T>(object primaryKey)
		{
			return _session.Get<T>(primaryKey);
		}

		public T Get<T>(Expression<Func<T, bool>> predicate)
		{
			return Find<T>().SingleOrDefault (predicate);
		}

		public IQueryable<T> Find<T>()
		{
            return _session.Query<T>();
		}

		public IQueryable<T> Find<T> (Expression<Func<T, bool>> predicate)
		{
			return Find<T>().Where (predicate);
		}

		public T Add<T>(T entity)
		{
			_session.Save(entity);
			return entity;
		}

		public T Remove<T>(T entity)
		{
			_session.Delete(entity);
			return entity;
		}
	}
}

