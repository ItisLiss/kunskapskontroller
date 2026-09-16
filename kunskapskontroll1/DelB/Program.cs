// För att testa listan utifrån tidigare övningar så lägger vi till
// elerver och kurs.

Student anna = new("Anna Andersson");
Student bertil = new("Bertil Bengtsson");

Course matte = new("Matte B", 5);
Course svenska = new("Svenska", 10);

// anmäl studenter
anna.Join(matte);
svenska.Enroll(bertil);

// kontrollera kurser
Console.WriteLine($"Annas kurs: {anna.Courses[0]}");
Console.WriteLine($"Mattes student: {matte.Students[0]}");

Console.WriteLine($"Bertils kurs: {bertil.Courses[0]}");
Console.WriteLine($"Svenskas student: {svenska.Students[0]}");

// Testa anmälan
Console.WriteLine("\nTestar avanmälan");

// Anna får lämna
anna.Leave(matte);

Console.WriteLine($"Antal kurser för Anna: {anna.Courses.Count}");
Console.WriteLine($"Antal studenter i matte kursen: {matte.Students.Count}");

// Anna fick lämna 2 ggr
anna.Leave(matte);