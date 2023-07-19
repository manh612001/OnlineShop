using OnlineShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Repositories
{
	public class RepositoryBase<T> : IRepository<T> where T : class
	{
		public Task Add(T obj, bool commit = true)
		{
			throw new NotImplementedException();
		}

		public Task Commit()
		{
			throw new NotImplementedException();
		}

		public Task Delete(T obj, bool commit = true)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public Task<T?> Get(int id, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public Task<T?> Get(Expression<Func<T, bool>> filter, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public Task<List<T>> Get(string? includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> Query(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public Task TruncateTable(string tableName)
		{
			throw new NotImplementedException();
		}

		public Task Update(T obj, bool commit = true)
		{
			throw new NotImplementedException();
		}
	}
}
