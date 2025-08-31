namespace Registrar;

public class Helper
{
  public static List<Course> GetCourses ()
  {
    List<Course> courses = [];

    Course course = new Course
    {
      Code = "CST8282",
      Title = "Introduction to Database Systems",
      WeeklyHours = 4
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8253",
      Title = "Web Programming II",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8256",
      Title = "Web Programming Language I",  
      WeeklyHours = 5
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8255",
      Title = "Web Imaging and Animations",  
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8254",
      Title = "Network Operating System",  
      WeeklyHours = 1
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2200",
      Title = "Data Warehouse Design",  
      WeeklyHours = 3
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2240",
      Title = "Advance Database topics",  
      WeeklyHours = 1
    };
    courses.Add(course);   

    return courses;
  }

  public static List<string> GetStudentTypes () {
    return ["Full Time", "Part Time", "Coop"];
  }

  public static List<Student> GetStudents()
  {
    List<Student> students = [];

    Student student = new Student
    {
      Id = 52000,
      FirstName = "John",
      LastName = "Doe",
      Type = "Full Time",
    };
    students.Add(student);

    student = new Student
    {
      Id = 40199,
      FirstName = "Jane",
      LastName = "Doe",
      Type = "Part Time",
    };
    students.Add(student);

    student = new Student
    {
      Id = 56780,
      FirstName = "Joan",
      LastName = "Smith",
      Type = "Coop",
    };
    students.Add(student);
    
    return students;
  }
}
