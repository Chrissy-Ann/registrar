using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registrar;

[Table(name: "Course")]

public class Course
{
    [Key] public int Id { get; set; }
    public string Code { get; set; } = "";
    public string Title { get; set; } = "";
    public int WeeklyHours { get; set; }
    [NotMapped]
    public bool IsChecked { get; set; } = false;

    public override string ToString()
  {
      return Code + " " + Title + " " + WeeklyHours.ToString() + (WeeklyHours==1 ? "hour":" hours") + " per week";
  }
    
    // Navigation Property
    public ICollection<Registration> Registrations { get; set; }
}
