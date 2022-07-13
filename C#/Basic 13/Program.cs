// int[] array = { 1, 2, 3, 4, 5 };

// static void ShiftValues(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length - 1; i++)
//     {
//         numbers[i] = numbers[i + 1];
//     }

//     numbers[numbers.Length - 1] = 0;
// }
// ShiftValues(array);
// ShiftValues(shiftingExample);
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// //print 1-255

// static void PrintNumbers()
// {
//     int i = 1;
//     while (i < 256)
//     {
//         Console.WriteLine(i);
//         i++;
//     }
// }

// ///2. Print odd numbers between 1-255
// static void PrintOdds(){
//     for ( int a = 1; a <= 255; a++){

//         if ( a % 2 !=0 ){
//              Console.WriteLine(a);
//         }
     
//     }
// }

// PrintOdds();

// //////

// // //3. Print Sum
// //     Print all of the numbers from 0 to 255, 
// //     but this time, also print the sum as you go. 
// //     For example, your output should be something like this:
    
// //     New number: 0 Sum: 0
// //     New number: 1 Sum: 1
// //     New number: 2 Sum: 3


// static void PrintSum(){
//     var sum = 0;

//     for (int i = 0; i <= 255; i ++){
//         sum = sum + i;
//         Console.WriteLine($"new number: {i} sum: {sum}" );

//     }
// }
//     PrintSum();
  

// //4. Iterating through an Array
//   //Write a function that would iterate through each item of the given integer array and 
//     //print each value to the console. 

// static void LoopArray(int[] numbers)
// {
//   foreach ( int number in numbers){
//     Console.WriteLine(number);
//   }
// }
// int[] myarray = {0,2,3,4,5};
// LoopArray(myarray);

//gjej shumen e nje array

static void gjejshumen(int [] numbers){
    int sum = 0;
    for (int i = 0; i < numbers.Length; i ++){
        sum = sum + numbers[i];
    Console.WriteLine(sum);
    }
   
}
//  int [] arrai = { 2, 4, 6};
//  gjejshumen(arrai);

 // gjej maximumin e nje array

 static void gjejmaximumin(int[] numrat){
    int max = numrat[0];
    for (int a = 0; a < numrat.Length; a ++){
     if (numrat[a] > max){
        max = numrat[a];
    }
    }
    Console.WriteLine(max);
 }
 int[] arr ={2,3};
 gjejmaximumin(arr);

///////////////////////////
 // gjej maximumin e nje array

 static void gjejminumin(int[] numrat){
    int min = numrat[0];
    for (int a = 0; a < numrat.Length; a ++){
     if (numrat[a] < min){
        min = numrat[a];
    }
    }
    Console.WriteLine(min);
 }
 int[] arer ={2,3};
 gjejminumin(arer);




// //5. Find Max
// // Write a function that takes an integer array and prints and returns the maximum value in the array. 
// //Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
// //or even a mix of positive numbers, negative numbers and zero.

// static int FindMax(int[] numbers)
// {
//     int maximum = numbers [0];
//    for (int i = 0; i < numbers.Length; i++){
//     if (numbers[i] > maximum){
//         maximum= numbers[i];
//     }

//    }
//    Console.WriteLine(maximum);
//    return maximum;
// }
// FindMax(myarray);

// ////
// //6. Get Average
// //Write a function that takes an integer array and prints the AVERAGE of the values in the array.
// //For example, with an array [2, 10, 3], your program should write 5 to the console.
// int[] array= {2, 4, 6};
// static void GetAverage(int[] numbers)
// {
//     int sum = 0;
//     int Average;


//     for (int c = 0; c < numbers.Length; c ++){
//      sum = sum + numbers[c];

//     }
//    Average = sum / numbers.Length;
//    Console.WriteLine(Average);
// }
// GetAverage(array); // -> ky eshte funksioni qe therret pasi ti ke bere pritntimin pra duhet patjeter ta mbyllesh me emrin e funksionit ne momnetin qe i ke dhene pritn(console.writeline)

// ////////////////////////////

// // List<int> evenNumbers = new List <int>();
// //     for ( int a = 1; a <= 10; a++){

// //         if ( a % 2 == 0 ){
// //              Console.WriteLine(evenNumbers[a]) ;
// //         }
     
// //     }

// // #6 Get Average
// static void GetAverage(int[] numbers)
// {
//     int sum = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     int avg = sum / numbers.Length;
//     Console.WriteLine(avg);
// }
// GetAverage(samples);

//6. Get Average
int[] arr = {2, 4, 6, 8};
static void GetAverage(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum = sum + numbers[i];
    }
    int Average =  sum / numbers.Length;
    Console.WriteLine(Average);
   } 
GetAverage(arr);

    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.

// // #7 Array with Odd Numbers
// static int[] OddArray()
// {
//     int[] allOdds = new int[256 / 2];
//     for (int i = 1; i <= 255; i += 2)
//     {
//         allOdds[i / 2] = i;
//     }

//     return (allOdds);
// }
// OddArray();

static int[] OddArray(){
    int[] arrei = new int[256];
    for(int i = 0; i <= 255; i++){
        if(i % 2 != 0){
            arrei[i] = i;
             Console.WriteLine( arrei[i]);
    }
}
    return arrei;
}OddArray();


// // #8 Greater than Y
// static int GreaterThanY(int[] numbers, int y)
// {
//     int idxTally = 0;
//     foreach (int num in numbers)
//     {
//         if (num > y)
//             idxTally++;
//     }
//     return idxTally;
// }
// GreaterThanY(samples, 3);







// // #9 Square the Values
// static void SquareArrayValues(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = numbers[i] * numbers[i];
//     }
// }
// SquareArrayValues(samples);
// SquareArrayValues(sampleAllNegative);

// // #10 Eliminate Negative Numbers
// static void EliminateNegatives(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//             numbers[i] = 0;
//         else
//             numbers[i] = numbers[i];
//     }
// }
// EliminateNegatives(sampleAllNegative);

// // #11 Min, Max, and Average
// static void MinMaxAverage(int[] numbers)
// {
//     int max = numbers[0];
//     int min = numbers[0];

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > max)
//             max = numbers[i];

//         if (numbers[i] < min)
//             min = numbers[i];
//     }

//     int avg = (min + max) / 2;
// }
// MinMaxAverage(samples);
// MinMaxAverage(sampleAllNegative);

// #12 Shifting the values in an array
int[] array = { 1, 2, 3, 4, 5 };

static void ShiftValues(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        numbers[i] = numbers[i + 1];
    }

    numbers[numbers.Length - 1] = 0;
}
ShiftValues(array);
// ShiftValues(shiftingExample);


 

// // #13 Number to String
// static object[] NumToString(int[] numbers)
// {
//     object[] objects = new object[numbers.Length];
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//             objects[i] = "Dojo";
//         else
//             objects[i] = numbers[i];
//     }
//     return objects;
// }
// NumToString(sampleAllNegative);
