using Domain.Models;
namespace Infrastructure.Services;

public class PostService
{
        List<Post> posts = new List<Post>();

     public List<Post> GetPost()
     {
        return posts;
     } 
     public void AddPost(Post post)
     {
       posts.Add(post);
     }
     public void UpdatePost(Post post)
     {
        foreach (var _post in posts)
        {
            if( _post.Id == post.Id )
            {
            _post.Id = post.Id;
            _post.Title = post.Title;
            _post.Description = post.Description;
            _post.VoteAmount = post.VoteAmount;
            _post.CreatedAt = post.CreatedAt;
            }
        }
     }
     public void DeletePost(int Id)
     {
        foreach (var _post in posts)
        {
            if (_post.Id == Id)
            {
                posts.Remove(_post);
            }
        }
     }
}

