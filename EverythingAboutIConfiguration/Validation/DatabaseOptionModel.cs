using System.ComponentModel.DataAnnotations;

namespace Validation;
internal class DatabaseOptionModel
{
    public string Name { get; set; }

    [Required]
    [MinLength(10)]
    public string UserName { get; set; }
}
