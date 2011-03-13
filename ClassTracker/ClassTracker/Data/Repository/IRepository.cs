using System;
using System.Linq;
using System.Linq.Expressions;

namespace ClassTracker.Data
{
	public interface IRepository
	{
	
   		T Load<T>(object primaryKey);
   		T Get<T>(object primaryKey);
		T Get<T>(Expression<Func<T, bool>> predicate);
		IQueryable<T> Find<T>();
		IQueryable<T> Find<T>(Expression<Func<T, bool>> predicate);
		T Add<T>(T entity);
		T Remove<T>(T entity);
	}
}

