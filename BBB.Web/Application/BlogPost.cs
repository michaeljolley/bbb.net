using YamlDotNet.Serialization;

namespace BBB.Web.Application;

public class BlogPost
{
  [YamlMember(Alias = "pubDate")]
  public required string PublishDate { get; set; }

  [YamlMember(Alias = "title")]
  public required string Title { get; set; }

  [YamlMember(Alias = "image")]
  public required string ImageUrl { get; set; }

  [YamlMember(Alias = "image_alt")]
  public required string ImageAlt { get; set; }

  [YamlMember(Alias = "description")]
  public required string Description { get; set; }

  [YamlMember(Alias = "tags")]
  public required string[] Tags { get; set; }

  [YamlMember(Alias = "summary")]
  public required string Summary { get; set; }

  [YamlMember(Alias = "featured")]
  public bool Featured { get; set; } = false;

}
