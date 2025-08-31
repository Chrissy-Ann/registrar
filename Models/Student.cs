using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registrar;

[Table(name: "Student")]

public class Student
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "A first name is required.")]
    [StringLength(50)] 
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "A last name is required.")]
    [StringLength(100)]
    public string LastName { get; set; } = "";

    [Required(ErrorMessage = "A student type is required.")]
    [StringLength(10)]
    public string Type { get; set; } = "";
    
    [NotMapped]
    public List<Course> Courses { get; set; } = new();
    
    // Navigation Property
    public ICollection<Registration> Registrations { get; set; }
}