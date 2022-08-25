namespace Services.Service;
using Domain.Models;
public class PostService
{
   private List<Post> posts = new List<Post>();
    public List<Post> GetPosts()
    {
        return posts;
    }
    public void Add(Post post)
    {

        posts.Add(post);
    }
    public void Update(Post post, int id)
    { 
        foreach (var item in posts)
        {
               if (item.Id == id)
              {
                  item.Description = post.Description;
                  item.Title = post.Title;
                  item.Vote = post.Vote;
                  item.Id = post.Id;
                  item.CreateAt = post.CreateAt;
              }     
        }

        
    }
    public Post GetPostById(int id)
    {
        Post post = new Post();
       
            foreach(Post item in posts)
            {
                if(item.Id == id)
                {
                    post = item;
                }
            }
           return post;
    }

    public void Delete(int id)
    {
        foreach(var item in posts)
        {
           if(item.Id == id)
            {
               posts.Remove(item);
            }
        }
    } 
}
