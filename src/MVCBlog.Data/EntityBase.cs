using System.ComponentModel.DataAnnotations;
using MVCBlog.Localization;

namespace MVCBlog.Data;

public abstract class EntityBase
{
    [Display(Name = nameof(Resources.Id), ResourceType = typeof(Resources))]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Display(Name = nameof(Resources.CreatedOn), ResourceType = typeof(Resources))]
    public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;
}