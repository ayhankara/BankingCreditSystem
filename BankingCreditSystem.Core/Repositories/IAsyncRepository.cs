using BankingCreditSystem.Core.Pagination;
using System.Linq.Expressions;

namespace BankingCreditSystem.Core.Repositories
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        
        Task<Paginate<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                     PaginationParams? pagination = null,
                                     Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                     params Expression<Func<T, object>>[] includes);
        
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        
        Task<T> AddAsync(T entity);
        
        Task<ICollection<T>> AddRangeAsync(ICollection<T> entities);
        
        Task<T> UpdateAsync(T entity);
        
        Task<ICollection<T>> UpdateRangeAsync(ICollection<T> entities);
        
        Task<T> DeleteAsync(T entity);
        
        Task<ICollection<T>> DeleteRangeAsync(ICollection<T> entities);
    }
} 