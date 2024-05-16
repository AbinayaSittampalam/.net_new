using System.ComponentModel.DataAnnotations;

namespace WebApplication1.model
{
    public class student
    {
        [Key]
       public int Id { get; set; }
       
       public required string Name { get; set; }
       public string? Address { get; set; }
    }
}
