// // // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello World");


// // int number;
// // string name;
// // bool isTall;
// // double height;

// // number = 4;

// // Console.WriteLine(number);

// // //operators make changes at this data
// // //1. Arithmetic -> -, +, *, /, %

// // Console.WriteLine(5%2);
// // Console.WriteLine(4%9);

// // //2. Comprator -> >, >=, <, <=, ==,
// // //2>3 -> False

// // //3. Logical: AND, OR, XOR, NOT
// // //&&, II, !
// // Console.WriteLine(!(2>3));

// // ////////////////////////////////

// // //Conditionals

// // //if(condition){ -> condition: boolean
// //     //code
// // //}

// // //example
// // int age = 18;
// // //output: It's ok! -> if a person is equal or bigger tha 18
// // if(age >18)
// // {
// // Console.WriteLine("you can drink");
// // }else if (age == 18){
// //     Console.WriteLine("It's your day");
// // }
// // else{
// //     Console.WriteLine("you are too young");
// // }

// // /////////////////////////////////////////////////

// // //for -> know the exact number of iterations
// // for (int i = 1; i<=10; i++){
// //     Console.WriteLine("Hello World");
// // }



// //while -> when we dont know the exact number

// // string fjala = Console.ReadLine();
// // while (!fjala.Equals("quit"))
// // {
// //     Console.WriteLine(fjala);
// //     fjala = Console.ReadLine();
// // }



// // // Variable to interpolate
// // int place = 23;
// // //Interpolated string, note the $
// // string message = $"Hello {place}";
// //string emri =  "flogert";
// //string mbiemri = "ciku";
// //Console.WriteLine($"My name is {emri} {mbiemri} I am  28  years old" + $" dhe mbiemri eshte : {mbiemri}");
// // // Displaying final message
// // Console.WriteLine(message);

// //Random rand = new Random();
// // for(int val = 0; val < 10; val++)
// {
//     //Prints the next random value between 2 and 8
    
//     //double numriRandomDouble = rand.NextDouble();
//     //Console.WriteLine(numriRandomDouble);

//     //int numriRandom = rand.Next(3,22);
//     //Console.WriteLine(numriRandom);
    




// }

// ////////////////////////////////////

// for (int i = 1; i < 256; i++){
//     Console.WriteLine(i);
// }

// int a = 1;
// while(a < 256) {
// Console.WriteLine(a);
// a++;
// }

// for (int i = 1; i <= 101; i++)
// {
//     if (i % 3 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     else if (i % 5 == 0)
//         Console.WriteLine(i);
// }

// int b = 1;
// while (b <= 101)
// {
//     if (b % 3 == 0)
//     {
//         Console.WriteLine(b);
//         b++;
//     }
//     else if (b % 5 == 0)
//         Console.WriteLine(b);
//     b++;
// }



// for(int i=1; i<101; i++) {
//     if(i % 15 == 0) {
//         Console.WriteLine("FizzBuzz");
//     } else if(i % 5 == 0) {
//         Console.WriteLine("Buzz");
//     } else if(i % 3 == 0) {
//         Console.WriteLine("Fizz");
//     } else {
//         Console.WriteLine(i);
//     }
// }

// int c = 1;
// while (c < 101)
// {
//     if (c % 15 == 0) {
//     Console.WriteLine("FizzBuzz");
//     c++;
//     }
   
//  else if (c % 5 == 0){

//     Console.WriteLine("Buzz");
//     c++;
// }
// else if (c % 3 == 0)
// {
//     Console.WriteLine("Fizz");
//     c++;
// }
// else 
// {
//     Console.WriteLine(c);
//     c++;
// }
// }
/////////////////////////////////////
//Arrays
// Declaring an array of length 5, initialized by default to all zeroes
int[] numArray = new int[5];
// Declaring an array with pre-populated values
// For Arrays initialized this way, the length is determined by the size of the given data
int[] numArray2 = {1,2,3,4,6};
//
int[] array3;
array3 = new int[] {1,3,5,7,9};
Console.WriteLine(array3);
//Accessing Arrays
int[] arrayOfInts = {1, 2, 3, 4, 5};
Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.

int[] arr = {1, 2, 3, 4};
Console.WriteLine($"The first number of the arr is {arr[0]}"); 
arr[0] = 8;
Console.WriteLine($"The first number of the arr is now {arr[0]}");
// The array has now changed!


//Iterating through an array
string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
// The 'Length' property tells us how many values are in the Array (4 in our example here). 
// We can use this to determine where the loop ends: Length-1 is the index of the last value. 
for (int idx = 0; idx < myCars.Length; idx++)
{
    Console.WriteLine($"I own a {myCars[idx]}");
}

string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
foreach (string car in myCars)
{
    // We no longer need the index, because variable 'car' already represents each indexed value
    Console.WriteLine($"I own a {car}");
}

// Generic Lists
//Initializing an empty list of Motorcycle Manufacturers
List<string> bikes = new List<string>();
//Use the Add function in a similar fashion to push
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");
//Accessing a generic list value is the same as you would an array
Console.WriteLine(bikes[2]); //Prints "BMW"
Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

//Iterating through a list
//Using our array of motorcycle manufacturers from before
//we can easily loop through the list of them with a C-style for loop
//this time, however, Count is the attribute for a number of items.
Console.WriteLine("The current manufacturers we have seen are:");
for (var idx = 0; idx < bikes.Count; idx++)
{
    Console.WriteLine("-" + bikes[idx]);
}
// Insert a new item between a specific index
bikes.Insert(2, "Yamaha");
//Removal from Generic List
//Remove is a lot like Javascript array pop, but searches for a specified value
//In this case we are removing all manufacturers located in Japan
bikes.Remove("Suzuki");
bikes.Remove("Yamaha");
bikes.RemoveAt(0); //RemoveAt has no return value however
//The updated list can then be iterated through using a foreach loop
Console.WriteLine("List of Non-Japanese Manufacturers:");
foreach (string manu in bikes)
{
    Console.WriteLine("-" + manu);
}



string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
foreach (string car in myCars)
{
    // We no longer need the index, because variable 'car' already represents each indexed value
    Console.WriteLine($"I own a {car}");
}
