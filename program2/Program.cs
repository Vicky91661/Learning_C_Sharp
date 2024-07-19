// int a = 5;
// int b = 6;

// if (a + b > 10)
// {
//     Console.WriteLine("greater than 10");
// }
// else
// {
//     Console.WriteLine("less than 10");
// }

// int counter = 0;
// counter++;
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);


// while (counter < 10)
// {
//     counter++;
//     Console.WriteLine(counter);
// }
// double radius = 2.50;
// double area = Math.PI * radius * radius;
// Console.WriteLine(area);




// DisplayCharacter('f');  // Output: A lowercase letter: f
// DisplayCharacter('R');  // Output: An uppercase letter: R
// DisplayCharacter('8');  // Output: A digit: 8
// DisplayCharacter(',');  // Output: Not alphanumeric character: ,

// void DisplayCharacter(char ch)
// {
//     if (char.IsUpper(ch))
//     {
//         Console.WriteLine($"An uppercase letter: {ch}");
//     }
//     else if (char.IsLower(ch))
//     {
//         Console.WriteLine($"A lowercase letter: {ch}");
//     }
//     else if (char.IsDigit(ch))
//     {
//         Console.WriteLine($"A digit: {ch}");
//     }
//     else
//     {
//         Console.WriteLine($"Not alphanumeric character: {ch}");
//     }
// }

// DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
// DisplayMeasurement(5);  // Output: Measured value is 5.
// DisplayMeasurement(30);  // Output: Measured value is 30; too high.
// DisplayMeasurement(double.NaN);  // Output: Failed measurement.

// void DisplayMeasurement(double measurement)
// {
//     switch (measurement)
//     {
//         case < 0.0:
//             Console.WriteLine($"Measured value is {measurement}; too low.");
//             break;

//         case > 15.0:
//             Console.WriteLine($"Measured value is {measurement}; too high.");
//             break;

//         case double.NaN:
//             Console.WriteLine("Failed measurement.");
//             break;

//         default:
//             Console.WriteLine($"Measured value is {measurement}.");
//             break;
//     }
// }

// string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

// Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
// Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!
using System;

// var names = new List<string>{"vicky","sahah"};

// for(int i=0;i<names.Count;i++){
//     Console.WriteLine(names[i]);
// }
// names.Add("Ritik");
// names.Add("kumar");
// foreach(var name in names){
//     Console.WriteLine(name);
// }



// Console.WriteLine("Whats your age ?");
// string age = Console.ReadLine();
// System.Console.WriteLine(age);
// int numOne = 5;
// int numtwo = 10;


// int[] numbers = new int[3];
// numbers[0]=1;


namespace geeksforgeeks {
     
class GFG {
     
    // Main Method
    public static void Main()
    {
         
        // declares a 1D Array of string.
        string[] weekDays;
 
        // allocating memory for days.
        weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", 
                                       "Thu", "Fri", "Sat"};
 
        // Displaying Elements of array
        int rank = weekDays.Rank;
        Console.WriteLine(rank);
        int[,] matrix = { { 1, 2,5 }, { 3, 4,9 } };
        int matrixRank = matrix.Rank; // rank = 2
        Console.WriteLine(matrixRank);
        foreach(string day in weekDays)
            Console.Write(day + " ");
    }
}
}