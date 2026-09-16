


//  Fält: Name, en kapacitet MaxSeats (max antal platser), och en lista Students.


public class Course(string name, int maxSeats)
{
    public string Name = name;
    public int MaxSeats = maxSeats;
    public List<Student> Students = [];

    //Metod Enroll(student) — anmäler en studerande till kursen, om det finns plats.
        public void Enroll(Student student)
    {
        if (Students.Contains(student))
         {
          return; // Vi lägger in en return ifall studenten redan är anmäld
         }

         if (Students.Count >= MaxSeats) // flyttar ner MaxSeats till egen if
         {
        Console.WriteLine($"Kunde inte anmäla: {student.Name}: För kursen: {Name} är full!");
        return; // om kursen är full så skrivs meddelandet ut och avbryter
        }
        /* Gamla if
        if (Students.Count < MaxSeats && !Students.Contains(student))
        */
        Students.Add(student);
        student.Join(this); 
    }

     // Metod Remove(student) — tar bort en studerande ur kursen.
     public void Remove(Student student)
     {
        if (Students.Contains(student))
     {
      Students.Remove(student);
      student.Leave(this);  
    }
            
    }
    // Metod RollCall() — skriver ut alla studerande i kursen.
    public void RollCall()
    {
        Console.WriteLine($"Deltagare: {Name}:");
        foreach (Student student in Students)
        {
            Console.WriteLine($" - {student.Name}");
        }
    }

    // En ToString() som t.ex. ger "Matematik (2/5 platser)".
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}