using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Interfaces
{
	public interface IRepository<T> where T : class
	{
        Task Add(T obj, bool commit = true);
        Task<T?> Get(int id, string includeProperties = "");
        Task<T?> Get(Expression<Func<T, bool>> filter, string includeProperties = "");
        Task<List<T>> Get(string? includeProperties = "");
        Task Delete(T obj, bool commit = true);
        Task Update(T obj, bool commit = true);
        Task Commit();
        IEnumerable<T> Find(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "");
        IQueryable<T> Query(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "");
        Task TruncateTable(string tableName);
    }
}
