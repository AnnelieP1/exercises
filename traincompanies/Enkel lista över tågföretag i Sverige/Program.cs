var traincompanies = new List<string> { "<train>", "SJ", "MTRX", "Flixtrain" };

foreach (var train in traincompanies)


{
    Console.WriteLine(train);
}

Console.WriteLine();

traincompanies.Add("Mälartågen");
foreach (var train in traincompanies)
    Console.WriteLine(train);

Console.WriteLine($"Jag har lagt till {traincompanies[4]} till listan.");

