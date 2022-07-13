// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Collections Practice
//Create an array to hold integer values 0 through 9

int[] array = new int [10];

//Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
string [] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};


//Create an array of length 10 that alternates between true and false values, starting with true

bool []  arry  =  new bool [10];

for ( int i = 0; i < arry.Length; i++){

    if ( i%2 == 0){

        arry[i] = true;

    }
    else {
        arry[i] = false;
    }
    Console.WriteLine(arry[i]);
}

//List of Flavors 

//Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)

List <string> icearray  = new List <string>();
 icearray.Add("Pistakio");
 icearray.Add("Ananas");
 icearray.Add("Lajthi");
 icearray.Add("coko");
 icearray.Add("straciatella");
//Output the length of this list after building it
Console.WriteLine(icearray.Count);
//Output the third flavor in the list, then remove this value
Console.WriteLine(icearray[2]);
//Output the new length of the list (It should just be one fewer!)
icearray.RemoveAt(2);
Console.WriteLine(icearray.Count);

//User Info Dictionary
//Create a dictionary that will store both string keys as well as string values

// Dictionary<string,string> flavour = new Dictionary<string,string>();
//  Random rand = new Random();
//  foreach( string name in names){
//     int index = rand.Next(icearray.Count);
//     flavour.Add(name, icearray[index]);
//  } 


// foreach (KeyValuePair<string,string> entry in flavour)
// {
//     Console.WriteLine(entry.Key + " - " + entry.Value);
// }


//Add key/value pairs to this dictionary where:
//each key is a name from your names array
//each value is a randomly elected flavor from your flavors list.

//Loop through the dictionary and print out each user's name and their associated ice cream flavor
Random rend = new Random (); // krijova nje random qe te marre vlera int te cfaredoshme 
Dictionary<string,string> icecream = new Dictionary<string,string>();// kam krijuar nje dictionary bosh
foreach (string name in names)// po mbush dictionary pra secili nga emrat ne names do krijoj nje objekt ne dictionary ku key eshte secili nga names
{
    icecream.Add(name, icearray[rend.Next(0, icearray.Count)]);// ketu kemi shtuar icecream duke perdorur metoden e next te rend pra i percaktojme ne menyre te rastesishme sihjen me shijen e pare (0) dhe komplet icearray.count
    
}
foreach (var item in icecream)
{
 
    Console.WriteLine(item.Key + '-' + item.Value);
}
