using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Registrar;

[Table(name: "Registration")]
[PrimaryKey (nameof(StudentId), nameof(CourseId))]

public class Registration
{
    [ForeignKey(name: "Student")] public int StudentId { get; set; }
    
    [ForeignKey(name: "Course")] public int CourseId { get; set; }
    
    // Navigation Properties
    public Student Student { get; set; }
    public Course Course { get; set; }
}