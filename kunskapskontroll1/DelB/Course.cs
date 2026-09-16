/*
● Metod Remove(student) — tar bort en studerande ur kursen.
● Metod RollCall() — skriver ut alla studerande i kursen.
● 
*/

//  Fält: Name, en kapacitet MaxSeats (max antal platser), och en lista Students.
public class Course(string name, int maxSeats)
{
    public string Name = name;
    public int MaxSeats = maxSeats;
    public List<Student> Students = [];

    //Metod Enroll(student) — anmäler en studerande till kursen, om det finns plats.
    public void Enroll(Student student)
    {
        Students.Add(student);
        student.Courses.Add(this);
    }

    // En ToString() som t.ex. ger "Matematik (2/5 platser)".
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}