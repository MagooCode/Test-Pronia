using Pronia.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Pronia.Models;

public class Perk : BaseEntity
{
    public string Image { get; set; }
    [Required, MaxLength(100)]
    public string Title { get; set;}
    [Required, MaxLength(255)]
    public string Description { get; set; }
}
