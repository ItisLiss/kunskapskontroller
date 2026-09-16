/* Fält: Name och en lista Courses.
● Metod Join(course) — går med i en kurs.
● Metod Leave(course) — lämnar en kurs.
● Metod Schedule() — skriver ut vilka kurser den studerande går.
● En ToString() med den studerandes namn.
● Reglerna som gör uppgiften — det är här logiken sitter:
*/

public class Student(string name)
{
    // Första är namn för studerande och sen en lista över kurser
    public string Name = name;

    //En tom lista för vi har ännu inte lagt in några studerande
    public List<Course> Courses = [];

}