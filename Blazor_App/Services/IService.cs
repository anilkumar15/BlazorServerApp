using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_App.Services
{
    public interface IService<TEntity, in TPk>
    {
        Task<List<TEntity>> GetAsync();
        Task<TEntity> GetAsync(TPk id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TPk id, TEntity entity);
        Task<bool> DeleteAsync(TPk id);
    }
}
