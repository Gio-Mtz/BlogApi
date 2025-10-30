using YourNamespace.Models;

namespace Blog.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post?> GetByIdAsync(int id);
        Task AddAsync(Post post);
        Task UpdateAsync(int id, Post post);
        Task DeleteAsync(int id);
    }
}
