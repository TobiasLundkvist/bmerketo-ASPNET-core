using System.ComponentModel.DataAnnotations;

namespace bmerketo_ASPNET_core_MVC.Models.Entities;

public class TagEntity
{
    [Key]
    public int Id { get; set; }
    public string TagName { get; set; } = null!;

    public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();
}
