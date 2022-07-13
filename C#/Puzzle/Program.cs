// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// static int[] randomArray(){
// int[] array = new int [10];
// Random rand = new Random();
//  for (int i = 0; i < array.Length; i++){
//     array[i] = rand.Next(5,25);
//      Console.WriteLine(array[i]);
//  }
//   int maximumi =  array[0];
//   int minimumi = array[0];
//   int sum = 0;
//   for (int j = 0; j < array.Length; j++){
//    if(maximumi < array[j]){
//         maximumi = array[j];
//    }
//    if (minimumi > array[j]){
//     minimumi= array[j];
//    }
//    sum = sum + array[j]; // sum += array[j]
//   }
//     Console.WriteLine("a eshte tamam?" + maximumi + " - " + minimumi + " -" + sum);
//     return array;
// }
// randomArray();
//gjej maximumin dhe min e array
// printo shumen e gjithe vlerave

//Coin Flip
//Required:
//Create a function called TossCoin() that returns a string
//Have the function print "Tossing a Coin!"
//Randomize a coin toss with a result signaling either side of the coin
static string TossCoin(){
Console.WriteLine("Tossing a Coin!");
Random rand = new Random();
string rezultat;
int result = rand.Next(1,3);
if( result == 1){
    Console.WriteLine("Koke");
    rezultat = "Koke";
}
else{
    Console.WriteLine("Pil");
    rezultat = "Pil";
}
    
    return rezultat;
}
TossCoin();

/////////////////////////////////
// Optional:
// Create another function called TossMultipleCoins(int num) that returns a Double

// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss

static double TossMultipleCoins(int num) {
    int a = 0;
    for(int i = 0; i < num; i++){
    
        if (TossCoin().Equals("Koke")){
            a++;
        }
    }

    double res = (double)a / (double)num;


    return res;
}
Console.WriteLine(TossMultipleCoins(10));


// Names
// Build a function Names that returns a list of strings.  In this function:

// Required: 
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Return a list that only includes names longer than 5 characters
// Optional:
// Shuffle the list and print the values in the new order

List<string> names = new List<string>();

names.Add("Todd");
names.Add("Tiffany");
names.Add("Charlie");
names.Add("Geneva");
names.Add("Sydney");


for(int i = 0; i < names.Count; i++)
{
   if(names[i].Length < 5){
    names.RemoveAt(i);
   }
  // Console.WriteLine(names[i]);
}
//Shuffle the list and print the values in the new order
List<string> list1 = new List<string>();
list1.Add("Tizi");
list1.Add("Manu");
list1.Add("Mia");
list1.Add("Klodi");
static void shufle(List<string> list1){
Random rnd = new Random();
for (int i = 0; i < list1.Count; i++){
int rand = rnd.Next(0, list1.Count);
string temp = list1[i];
list1[i] = list1[rand];
list1[rand] = temp;
}
}
shufle(list1);


// static int[] randomArray(){
//     Random rand = new Random();
//     int[] array = new int [10];
// for (int i = 0; i < array.Length; i++){
//     array[i] = rand.Next(5,25);
// Console.WriteLine(array[i]);
// }


//     return array;
// }
// Console.WriteLine(randomArray());

