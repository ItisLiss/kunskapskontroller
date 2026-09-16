// För att testa listan utifrån tidigare övningar så lägger vi till
// elerver och kurs.

Student anna = new("Anna Andersson");
Student bertil = new("Bertil Bengtsson");

Course matte = new("Matte B", 1);
Course svenska = new("Svenska", 5);

// anmäl studenter
anna.Join(matte);
anna.Join(svenska);
matte.Enroll(bertil);
svenska.Enroll(bertil);

// dubletter?? Nahhh
svenska.Enroll(bertil);

/*
// kontrollera kurser
Console.WriteLine($"Annas kurs: {anna.Courses[0]}");
Console.WriteLine($"Mattes student: {matte.Students[0]}");

Console.WriteLine($"Bertils kurs: {bertil.Courses[0]}");
Console.WriteLine($"Svenskas student: {svenska.Students[0]}");
*/

// Testa RollCall och Schedule
Console.WriteLine("Test RollCall");
matte.RollCall();
svenska.RollCall();

Console.WriteLine("\nTest Schedule");
anna.Schedule();
bertil.Schedule();


/* Testa lämna
anna.Leave(matte);
*/


Console.WriteLine($"Antal kurser för Anna: {anna.Courses.Count}");
Console.WriteLine($"Antal studenter i matte kursen: {matte.Students.Count}");

matte.RollCall();

 // Anna fick lämna test 2
anna.Leave(matte);


