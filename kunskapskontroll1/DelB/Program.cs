// För att testa listan utifrån tidigare övningar så lägger vi till
// elerver och kurs.

//Elev
Student anna = new("Anna Andersson");
Student bertil = new("Bertil Bengtsson");

//Kurser
Course matte = new("Matte B", 5);
Course svenska = new("Svenska", 10);

// Testa Join
anna.Join(matte);

// Testar Enroll metoden
svenska.Enroll(bertil);

// Skriv ut för att kontrollera att BÅDA listorna har uppdaterats
Console.WriteLine($"Studentens kurser: {anna.Courses[0]}");
Console.WriteLine($"Kursens studenter: {matte.Students[0]}");

Console.WriteLine($"Bertils kurslista: {bertil.Courses[0]}");
Console.WriteLine($"Svenska-kursens studentlista: {svenska.Students[0]}");