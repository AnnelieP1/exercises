Console.Write("Skriv ditt f�rnamn: ");
string firstName = Console.ReadLine() ? ? "";

Console.Write("Skriv ditt efternamn: ");
string lastName = Console.ReadLine() ? ? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}.");
Console.ReadKey();