// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Boxing/Unboxing
//Create a console application and follow the instructions below to safely unbox an array of type Object.  
//Create an empty List of type object
List<string> empty = new List<string>();
//Add the following values to the list: 7, 28, -1, true, "chair"
empty.Add("7");
empty.Add("28");
empty.Add("-1");
empty.Add("true");
empty.Add("chair");

int sum = 0;

foreach (string item in empty)
{
    Console.WriteLine(item);
    int numericValue;
    bool isNumber = int.TryParse(item, out numericValue);
    if(isNumber==true){
        sum += numericValue;
    }
}
Console.WriteLine(sum);
