using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CruelWolfWeb.Model;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Display(Name = "Display Order")]
    [Range(1, 100, ErrorMessage = "DisplayOrder must be in range of 1 to 100!!!")]
    public int DisplayOrder { get; set; }
}