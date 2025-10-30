using YourNamespace.Models;

namespace Blog.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<Post?> GetPostAsync(int id);
        Task CreatePostAsync(Post post);
        Task UpdatePostAsync(int id, Post post);
        Task DeletePostAsync(int id);
    }
}
