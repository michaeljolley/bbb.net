using BBB.Web.Application;
using BBB.Web.Application.Extensions;

public class ContentStore
{
	public async Task<List<BlogPost>> GetPostsAsync()
	{
        var directory = Directory
                    .GetFiles("../content/blog/");

        var text = File.ReadAllText(directory[0]);

        var posts = directory
            .Select(File.ReadAllText)
            .Select(md => md.GetFrontMatter<BlogPost>())
            .ToList();
        
        return posts;
    }
}
