using Blog.Interfaces;
using YourNamespace.Models;

namespace Blog.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Post>> GetAllPostsAsync() => _repository.GetAllAsync();
        public Task<Post?> GetPostAsync(int id) => _repository.GetByIdAsync(id);
        public Task CreatePostAsync(Post post) => _repository.AddAsync(post);
        public Task UpdatePostAsync(int id, Post post) => _repository.UpdateAsync(id, post);
        public Task DeletePostAsync(int id) => _repository.DeleteAsync(id);
    }
}
