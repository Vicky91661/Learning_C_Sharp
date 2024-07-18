Console.WriteLine("Hello Vicky!");
string firstFriend = "Raja";
string secondFriend = "Supon";

Console.WriteLine($"My friends are {firstFriend} and {firstFriend.Length}");
Console.WriteLine($"My friends are {secondFriend} and {secondFriend.Length}");//$ => String Interpolation 


string Firstname  = "   Vicky     s";
Console.WriteLine($"Before triming my First name is {Firstname}");
string LastName = "      sah     ";
Console.WriteLine($"my First name is {Firstname.TrimStart()}");

string friends = $"My friends are {firstFriend} and {secondFriend}";

Console.WriteLine(friends);
Console.WriteLine(friends.Replace("Supon","Nidhi"));
Console.WriteLine(friends);
Console.WriteLine(friends.Contains("Supon"));
Console.WriteLine(friends.ToUpper());


int a = 2146999999; // max range of int = 2100000000
int b=2146999999;
// long c = checked(a+b) ; //it will check overflow never happens. Error : Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
 long c = a+b;
Console.WriteLine(c);

int d = 2146999999; // max range of int = 2100000000
int e=2146999999;
long f = (long)d+(long)e;
Console.WriteLine(f);
 

 float x = 3.5F;
 float y = 4.3F;
 float result = x+y;
 Console.WriteLine(result);


 decimal num1 = 42.1M;
decimal num2 = 38.3M;
decimal sum = num1+num2;
Console.WriteLine(sum);