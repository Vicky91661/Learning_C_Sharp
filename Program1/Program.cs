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


int a = 18;
int b=6;
int c = a+b ;

Console.WriteLine(c);