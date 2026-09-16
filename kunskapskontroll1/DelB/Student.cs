// Fält: Name och en lista Courses.


//● En ToString() med den studerandes namn.
//● Reglerna som gör uppgiften — det är här logiken sitter:

public class Student(string name)
{
    // Första är namn för studerande och sen en lista över kurser
    public string Name = name;

    //En tom lista för vi har ännu inte lagt in några studerande
    public List<Course> Courses = [];

 // Andra delen är att skapa Metod: Join(course) 
 // För att lägga till studerande i kursen, använder vi if
    public void Join(Course course)
    {
        // if säkerhetsställer att man inte kan registrera sig fler ggr på samma kurs.
        if (!Courses.Contains(course))
        {
        Courses.Add(course);
        course.Enroll(this);
        }
    }
    // Metod Leave(course) — lämnar en kurs.
    // Vi behöver kunna lämna kursen. Vilket vi gör på på samma vis som vi ansluter.
    public void Leave(Course course)
    {
        if (Courses.Contains(course))
        {
            Courses.Remove(course);
            course.Remove(this); 
        }
    }
    // Metod Schedule() — skriv ut vilka kurser den studerande går
    public void Schedule()
    {
        Console.WriteLine($"Schema för {Name}:");
        foreach (Course course in Courses)
        {
            Console.WriteLine($" - {course.Name}");
        }
    }

    public override string ToString()
    {
    return Name;
    }
}