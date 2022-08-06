List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//Use LINQ to find the first eruption that is in Chile and print the result.
IEnumerable<Eruption> FirstEruption = eruptions.Where(c => c.Location == "Chile").OrderBy(c => c.Year).Take(1);
PrintEach(FirstEruption, "Chile eruption");

//Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
IEnumerable<Eruption> Hawaiian = eruptions.Where(c => c.Location == "Hawaiian Is").OrderBy(c => c.Year).Take(1).ToList();
if(Hawaiian.Count() < 1)
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
} else
        {
            PrintEach(Hawaiian,"/");
        }

//Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
IEnumerable<Eruption> New_Zealand = eruptions.Where(c => c.Location == "New Zealand").OrderBy(c => c.Year > 1900);
PrintEach(New_Zealand, "Taupo");

//Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> Elevation = eruptions.Where(c => c.ElevationInMeters > 2000m);
PrintEach(Elevation);

//Find all eruptions where the volcano's name starts with "Z" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> Starts_Z = eruptions.Where(c => c.Volcano.StartsWith("Z"));
PrintEach(Starts_Z);
Console.WriteLine("Count:" + Starts_Z.Count());

//Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int Max = eruptions.Max(c => c.ElevationInMeters);
Console.WriteLine(Max);
IEnumerable<Eruption> HighestElevation = eruptions.Where(c => c.ElevationInMeters == Max);
PrintEach(HighestElevation);

//Print all Volcano names alphabetically.
IEnumerable<Eruption> Volcano_Alphabetically = eruptions.OrderBy(c => c.Volcano);
PrintEach(Volcano_Alphabetically, "test1");

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> Volcano_Name = eruptions.OrderBy(c => c.Volcano).OrderBy(c => c.Year < 1000); 
PrintEach(Volcano_Name,"test2");

//BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> names = new List<string>();
foreach (var item in Volcano_Name)
{
    names.Add(item.Volcano);
}
foreach (var item in names)
{
    Console.WriteLine(item);
}


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!

static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

