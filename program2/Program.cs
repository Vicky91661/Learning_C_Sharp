// // int a = 5;
// // int b = 6;

// // if (a + b > 10)
// // {
// //     Console.WriteLine("greater than 10");
// // }
// // else
// // {
// //     Console.WriteLine("less than 10");
// // }

// // int counter = 0;
// // counter++;
// // Console.WriteLine(counter);
// // counter++;
// // Console.WriteLine(counter);
// // counter++;
// // Console.WriteLine(counter);
// // counter++;
// // Console.WriteLine(counter);


// // while (counter < 10)
// // {
// //     counter++;
// //     Console.WriteLine(counter);
// // }
// // double radius = 2.50;
// // double area = Math.PI * radius * radius;
// // Console.WriteLine(area);




// // DisplayCharacter('f');  // Output: A lowercase letter: f
// // DisplayCharacter('R');  // Output: An uppercase letter: R
// // DisplayCharacter('8');  // Output: A digit: 8
// // DisplayCharacter(',');  // Output: Not alphanumeric character: ,

// // void DisplayCharacter(char ch)
// // {
// //     if (char.IsUpper(ch))
// //     {
// //         Console.WriteLine($"An uppercase letter: {ch}");
// //     }
// //     else if (char.IsLower(ch))
// //     {
// //         Console.WriteLine($"A lowercase letter: {ch}");
// //     }
// //     else if (char.IsDigit(ch))
// //     {
// //         Console.WriteLine($"A digit: {ch}");
// //     }
// //     else
// //     {
// //         Console.WriteLine($"Not alphanumeric character: {ch}");
// //     }
// // }

// // DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
// // DisplayMeasurement(5);  // Output: Measured value is 5.
// // DisplayMeasurement(30);  // Output: Measured value is 30; too high.
// // DisplayMeasurement(double.NaN);  // Output: Failed measurement.

// // void DisplayMeasurement(double measurement)
// // {
// //     switch (measurement)
// //     {
// //         case < 0.0:
// //             Console.WriteLine($"Measured value is {measurement}; too low.");
// //             break;

// //         case > 15.0:
// //             Console.WriteLine($"Measured value is {measurement}; too high.");
// //             break;

// //         case double.NaN:
// //             Console.WriteLine("Failed measurement.");
// //             break;

// //         default:
// //             Console.WriteLine($"Measured value is {measurement}.");
// //             break;
// //     }
// // }

// // string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

// // Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
// // Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!
// using System;

// // var names = new List<string>{"vicky","sahah"};

// // for(int i=0;i<names.Count;i++){
// //     Console.WriteLine(names[i]);
// // }
// // names.Add("Ritik");
// // names.Add("kumar");
// // foreach(var name in names){
// //     Console.WriteLine(name);
// // }



// // Console.WriteLine("Whats your age ?");
// // string age = Console.ReadLine();
// // System.Console.WriteLine(age);
// // int numOne = 5;
// // int numtwo = 10;


// // int[] numbers = new int[3];
// // numbers[0]=1;


// namespace geeksforgeeks {

// class GFG {

//     // Main Method
//     public static void Main()
//     {

//         // declares a 1D Array of string.
//         string[] weekDays;

//         // allocating memory for days.
//         weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", 
//                                        "Thu", "Fri", "Sat"};

//         // Displaying Elements of array
//         int rank = weekDays.Rank;
//         Console.WriteLine(rank);
//         int[,] matrix = { { 1, 2,5 }, { 3, 4,9 } };
//         int matrixRank = matrix.Rank; // rank = 2
//         Console.WriteLine(matrixRank);
//         foreach(string day in weekDays)
//             Console.Write(day + " ");
//     }
// }
// }



//  OOPS
// 1.ADVANTAGES


// 1. Improved software develpoment productivity
// 2. Improved software Maintainability
// 3. Faster develpoment
// 4. Lower cost of develpoment
// 5. Higher-quality software 

// 2. DISADVANTAGES

// 1. Steep Learning Curve
// 2. Larger Program Size

// Class and Objects

// 1. Class Has Attributes and Behavior
// 2. Based on Class object has same Attributes and Behavior
// Example
// Class
// Car
//     Attributes
//         Model
//         Color
//         Price
//     Behaviors:
//         Run()
//         Accelerate()

// Object
// Ferrari
//     Attributes:
//         Model
//         Color
//         Price
//     Behaviors:
//         Run()
//         Accelerate()



// // Class Syntax

// access MOdifier   -                class         -    identifier
// (Public /Private/protected)


// What is method?
// Method is code block that perform particular task or Provide a Functionality that is why it is also called function.


// in Static method if you want to call a non-static method then you have to make object.
// SYNTEX
//  Access Modifier   Return Type       Method Name (Parameter List)
// (public/private)   (int float string void)



using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


// namespace Calculator
// {
//     public class Calculator{
//         int numOne;
//         int numtwo;
//         int result;

//         void Add(){
//             result = numOne+numtwo;
//             print();
//         }
//         void Subtract(){
//             result = numOne - numtwo;
//             print();
//         }
//          void Multiplication(){
//             result = numOne * numtwo;
//             print();
//         }
//          void Division(){
//             result = numOne / numtwo;
//             print();
//         }
//         void print(){
//             Console.WriteLine(result);
//             Console.ReadLine();
//         }

//         public static void Main(string[] args){
//             Calculator VickysCalculator1 = new Calculator() ;
//             VickysCalculator1.numOne = 30;
//             VickysCalculator1.numtwo = 40;
//             VickysCalculator1.Add();
//             VickysCalculator1.Subtract();
//             VickysCalculator1.Multiplication();
//             VickysCalculator1.Division();
//              Calculator VickysCalculator2 = new Calculator() ;
//             VickysCalculator2.numOne = 40;
//             VickysCalculator2.numtwo = 50;
//             VickysCalculator2.Add();
//             VickysCalculator2.Subtract();

//             VickysCalculator1.Add();
//             VickysCalculator1.Subtract();

//             VickysCalculator2.Add();
//             VickysCalculator2.Subtract();
//             Program findthemax = new Program();
//             Console.WriteLine(findthemax.FindMax(10,28));
//         }
//     }
    
// }

// namespace Method{
//     class Program{
//         public int FindMax(int num1,int num2){
            
//             if(num1>=num2){
//                 return num1;
//             }else{
//                 return num2;
//             }
//         }
//     }
// }





// Method with no argument and no return type
//  Method with  argument and no return type
//  Method with no argument and  return type
//  Method with argument and return type


// Access Modifier
// There are total 6 Access Modifier in C#

// 1. PubliC : The code is accessible to all classe
// 2. Private : The Code is only accessible within the same class
// 3. Protecteds : The code is accessible within the same class, or in a class that is inherited from that class.
// 4. Internal : The code is only accessible within its own assembly, but not from another assembly.
// 5. Protected Internal :
// 6. Private Protected



// Access Modifiers specify the visility / accessbility of class and its memebers.
// Access Modifier provide restriction in class and its members.
// By default methods and property are private modifier.
// By default classes are internal modifier.
// class never be private or protected. class can be either public or Internal

                            //  Assemblies
                            //     |
                        // have many Namespaces
                            //     |
                        // have many Class
                        

// namespace Access_Modifiers{
//     class Program{
//         static void Main(string[] args){
//             Car myCar = new Car();

//             myCar.model ="Ferrari";
//             myCar.color = "Black";
//             myCar.price = 483039423;
//             myCar.PrintCarInformation();
//         }
//     }
//     class Car{
//         public string model;
//         public string color;
//         public int price;
//         public void PrintCarInformation(){
//             Console.WriteLine("Model:"+model);
//             Console.WriteLine("Color: "+color);
//             Console.WriteLine("Price: "+price);
//             Console.ReadLine();
//         }
       
//     }
// }



// INHERITANCE
// IT IS A PROCES OF INHERITING THE PROPERTIES AND BEHAVIORS OF EXISTIG CLASS INTO NEW CLASS



// namespace Inheritance{
//     class Car{
//         public string model;
//         public string color;
//         public int price;
//         public void PrintCarInformation(){
//             Console.WriteLine("Model:"+model);
//             Console.WriteLine("Color: "+color);
//             Console.WriteLine("Price: "+price);
//             Console.ReadLine();
//         }
       
//     }
//     class racingCar:Car{
//         protected int speed ;
//         protected void PrintSpeed(){
//             Console.WriteLine("Speed: "+ speed); 
//         }
//     }

//     class Maruti:racingCar{
//         float mileage;
//         void PrintMileage(){
//             Console.WriteLine("Mileage"+mileage);
//         }
//         static void Main(string[] args){
//             Maruti myCar = new Maruti();
//             myCar.model ="Ferrari";
//             myCar.color = "Black";
//             myCar.price = 483039423;
//             myCar.speed = 350;
//             myCar.mileage=33.2F;
//             myCar.PrintCarInformation();
//             myCar.PrintMileage();
//             myCar.PrintSpeed();
//         }
    
//     }
// }

// There are 5 types of inheritance 
// 1. Single Inheritance
// 2. Multilevel Inheritance
// 3. Hierarchical Inheritance
// 4. Multiple Inheritance : NOt in C#
// 5. Hybrid Inheritance : Not in C#


//  Single Inheritance
// In single inheritance , There is only one Parent class and one child class


// Multilevel Inheritance
// In multilevel inheritance , a child class will be inheriting a parent class and as child class also act as the
// parent class to other class.


// Hierarchical Inheritance
// In Hierarchical Inheritance , there is one Parent class , that has more than one CHild Classes.

// Multiple Inheritance : Not Possible in C#
// In multiple Inheritance , Child class have more than one parent class.

// POLYMORPHISM
// Ploy - many
// Morphism means 'Form/Behaviors';

// For Example
// + Operator is used for addition of two Integer 10+29
// It is also used for joinig two String. Example :   "Spider" + "man" = "Spiderman"


//  There are two types of polymorphism 
// 1. Compile time polymorphism / Static polymorphism   :   Method Overloading
// 2. Run time polymorphisma / Dynamic polymorphism     :   Method OverRiding

// Compile time polymorphism achieved using Method Overloading.
// Run time polymorphism achieved using Method OverRiding.




// Method Overloading

// According to method overloading class can have multiple method havinf Same name.

// condition for Method Overloading
// 1. All the method should have Same Name.
// 2. All the Method Should be in Same Class.
// 3. But Methods should have Differrnt Parameters.


// Method Overriding
// With Method Overriding, We can Override the method of Parent class with same method of child class.


// namespace MethodOverloading{
//     class Program{
//         void Sum(int a, int b){
//             Console.WriteLine(a+b);
//         }
//         void Sum(string a , string b){
//             Console.WriteLine(a+b);
//         }
//         static void Main(string[] args){
//             Program obj = new Program();
//             obj.Sum(45,23);
//             obj.Sum("Vicky ","Shah");

//         }
//     }
// }

// Method Overriding
// With Method Overriding, We can Override the method of Parent class with same method of child class.

// condition for Method Overriding
// 1. All the methods should have same name.
// 2. All the Method Should be in Different Class.
// 3. And Methods should have Same Parameters.
// 4. There Sholud be Inheritance between Classes.

// namespace MethodOverriding{
//     class Animal{
//         public void Eat(){
//             Console.WriteLine("Animal is Eating");
//         }
//     }

//     class Dog:Animal{

//         public void Eat(){
//             Console.WriteLine("Dog is Eating");
//         }
//         public static void Main(string[] args){
//             Dog tommy = new Dog();
//             tommy.Eat();
//             Console.ReadLine();
//         }
//     }
// }
// Pannel light : not good for eyes 3w 6w 10w 12w 15w 18w
// COV Light 3w 6w 10w 12w 15w 18w 24w 30w
// linear Cov 4000 kalwin
// Track light
// Cove lighting =>  Profile lighting
// IP 65(Flooring) , IP 67(Swiming light)
// 




// Abstraction
// public abstract  class Customer{
//     public string Name{get;set;}
//     public string CustomerId{get;set;}
//     public string Address{get;set;}
//     public Decimal TotalAmount {get; set;}
//     public abstract void TOtalAmount();
//         // This method will calculate total 
    

// }


// public class SavingAccount:Customer{
//     public override void TOtalAmount(){

//     }
// }

// public class CurrentAccount:Customer{
//     public override void TOtalAmount(){
        
//     }
// }



// Constructor
// constructor is a method that has the same name as that of class name.
// Constructor do not have return type. Do not need to mention return type.
// Access modifier can be used with Constructor.
// It invoked when objects get created.
// It Allocates the appropriate memory to objects.
// Default  vs user defined contructor
// It initialize member variables of a class.
// We can declare more than one Constructor in a class.
// Constructor can be overloaded.

// Type of Constructor
// 1. Default Constructor
// 2. User Defined Constructor
// 3. Parameterized Constructor

// namespace Constructor{
//     class Program{
//         public  Program(string model,int year){// parameterized constructor
//             Console.WriteLine("Hello I am the COnstructor");
//         }
//         public  Program(int year,string model){// parameterized constructor
//             Console.WriteLine("Hello I am the COnstructor");
//         }
//         static void Main(string[] args){
//             Program obj = new Program("omini",2013);

//         }
//     }
// }



// Encapsulation
// The meaning of Encapsulation is "hiding the sesitive data".
// How to achieve Encapsulation:
// 1. Declare the variables of a class as private.(Data hiding)
// 2. Provide public sette and getter method to modify and view the variables vlaues.




// namespace Encapsulation{
//     class Account{
//         private int accountBalance = 1000;//Its a sensitive data 
//         public void SetBalance(int amount){
//             accountBalance = amount;
//         }
//         public int GetBalance(){
//             return accountBalance;
//         }
//     }
//     class Program{
            
//         // Account myAccount = new Account();
//         // myAccount.SetBalance(3000);
//         static void Main(string[] args){
//             Account myAccount2 = new Account();
//             myAccount2.SetBalance(3000);
//             Console.WriteLine( myAccount2.GetBalance());
//             Account myAccount = new Account();
//             Console.WriteLine( myAccount.GetBalance());
//             Console.WriteLine( myAccount.GetBalance());
        
        
//         }
//     }
// }

// C# Properties
// 1. A property is like a combination of a variable and a method

// Abstraction
// Abstraction is one of the principle of OOPS. It is used to display only necessary and essential features of 
// an object to outside the world. Means displaying waht is necessary and encapsulate the unnecessary things to outside the world.
// Hiding can be achieved by using "Private" access modifier.

// Abstraction is "to represent the essential feature without representing the background details"


// namespace Abstraction{
//     class Employee{
//         public int EmpId;
//         public string EmpName;
//         public double GrossPay;
//         double TaxDeduction=0.1;
//         double netSalary;

//         public Employee(int Eid,string Ename,double EGrosspay){
//             EmpId =Eid;
//             EmpName =Ename;
//             GrossPay =EGrosspay;
//             calculateSalary();
//             Console.WriteLine("Your net Salary is "+netSalary);
//         }
//         void calculateSalary(){
//             if(GrossPay>=30000){
//                 netSalary = GrossPay - (TaxDeduction*GrossPay);
//             }else{
//                 netSalary = GrossPay;
//             }

//         }

//         public static void  Main(){
//             Employee newEmployee = new Employee(1,"Vicky",340756.7);
//         }
//     }
// }

// Abstraction can be achieved using Abstract Classes, Abstract Method and Interfaces as well.

// Abstract Class in C#
// The word abstract means a concept or an idea not associated with any specific instance. In programing we apply
// the same meaning of abstraction by making clases not associated with any specific instance.

            //   Person
            //     |
            // ____|______
            // |          |
            // Student    Teacher



// namespace Abstract_class{
//     abstract class person{
//         public string names;
//         public int age;
//         public long PhoneNumer;
//         public abstract void showss();
//     }
//     class students:person{
//     //    
//         public int RollNumber;

//         public int Fees;
//         public override void showss(){
//             Console.WriteLine(" Student name is "+names + " has roll number "+RollNumber+" with age");
//         }
//     }
//     class teachers:person{

//         public string qualification;
//         public override void showss(){
//              Console.WriteLine(" Teacher name is "+names + " having Qualification  "+qualification+" with age "+age);
//         }
//         public static void Main(string[] args){
//             students myStudent = new students();
//             myStudent.names="vicky shah";
//             myStudent.age=25;
//             myStudent.PhoneNumer=91661234;
//             myStudent.RollNumber=36;
//             myStudent.showss();
//             teachers myTeacher = new teachers();
//             myTeacher.names="Harkirat Singh";
//             myTeacher.age=32;
//             myTeacher.qualification="Btech in CSE";
//             myTeacher.showss();
//         }

//     }
// }

// A class which contains the abstract keyword in its declaration is known as abstract class.
// In C#, Abstraction is achieved using Abstract classes and Interfaces.
// A class which contains the abstract keyword in its declaration is kown as absract class.
// It can only be used as aBASE class for ohter classes that extends the abstract class.
// Abstract classes may or may not contains methods i.e. method without body.
// Like any other class, an abstract classs can contains fields that describe the characteristics 
// and method that describe the actions that a class can perform.
// But,if a class has atleast one abstract method, then the class must be declared abstract.
// To use an abstract class, You have to inherit it to another class.
// If you inherit an abstract class,you have to provide implementations to all the abstract method in it.
// An abstract class can implement code with non-abstract methods.
// An abstract class can have modifiers for methods, properties etc.
// An Abstract class can have constants and fields.
// An abstract class can have constructors or destructors.

// ABSTRACT PROPERTIES IN C#
// 1. Declared by using the abstract keyword.
// 2. Contains only the declaration of the property without the body of the get and set accessors
//      (Which do not contains any statements and can be implemented in the derived class).
// 3. It is only allowed in an abstract class.



// namespace Abstract_property{
//     abstract class person{
//         public abstract int Id{get;set;}
//         public string names;
//         public int age;
//         public long PhoneNumer;
//         public abstract void showss();
//     }
//     class students:person{
//         int StudentId;
//         public override int Id{
//             get{
//                 return StudentId;
//             }
//             set{
//                 StudentId = value;
//             }
//         }
         

//         public int RollNumber;

//         public int Fees;
//         public override void showss(){
//             Console.WriteLine(StudentId+" Student name is "+names + " has roll number "+RollNumber+" with age");
//         }
//     }
//     class teachers:person{
//         int TeacherId;
//         public override int Id{
//             get{
//                 return TeacherId;
//             }
//             set{
//                 if(value<=0){
//                     Console.WriteLine("Id can not be less than or equal to zero");
//                     return;
//                 }
//                 TeacherId = value;
//             }
//         }
//         public string qualification;
//         public override void showss(){
//              Console.WriteLine(TeacherId+" Teacher name is "+names + " having Qualification  "+qualification+" with age "+age);
//         }
//         public static void Main(string[] args){
//             students myStudent = new students();
//             myStudent.Id=2;
//             myStudent.names="vicky shah";
//             myStudent.age=25;
//             myStudent.PhoneNumer=91661234;
//             myStudent.RollNumber=36;
//             myStudent.showss();
//             teachers myTeacher = new teachers();
//             myTeacher.Id=23;
//             myTeacher.names="Harkirat Singh";
//             myTeacher.age=32;
//             myTeacher.qualification="Btech in CSE";
//             myTeacher.showss();
//         }

//     }
// }


// INTERFACES IN THE C#
// 1. An interface is a contract between itself and any class that implements it.
// 2. This contract states that any class that implemnets the interface will implement the interfaces's properties
//      ,Method and events.
// 3. An interfaces contains no implementation, Only the signature of the functionality the interface provides.
// 4. Every member in the interfaces is public. It is not allowed to declare explicit access modifiers.


// Implementation of Interfaces
// 1. An Interfcae is implemented by a class in a way similar to inheriting a class.
// 2. While implementing an interface in a class, implemet all the abstract method declared in the interfcae, 
//      If all the methods are not implemented,the clas cannot be compiled.
// 

// namespace Interfaces{
//     interface IEmployee{
//         void shows();
//     }

//     class PartTimeEmployee:IEmployee{
//         public void  shows(){
//             Console.WriteLine("Hey there");
//         }
//     }

//     class Program{
//         static void Main(string[] args){
//             PartTimeEmployee partTimeEmployeeOne = new PartTimeEmployee();
//             partTimeEmployeeOne.shows();
//         }
//     }
// }

// INTERFACES INHERITANCE IN C#
// 1. Interface can inherit from other interfaces.
// 2. A class that inherits this interface must provide implementation for all interface members in the entire
//      interface inheritance chain.
// 3. Interface reference variable can have the reference of therit chilld class.


// namespace Interfaces {
//     interface i1{
//         void print();
//     }
//     interface i2{
//         void print1();
//     }
//      interface i3:i1,i2{
//         void print2();
//     }
//     class Program:i3{
//         public void print(){
//             Console.WriteLine("Hellow from print");
//         }
//          public void print1(){
//             Console.WriteLine("Helloe from print 1");
//         }
//          public void print2(){
//              Console.WriteLine("Helloe from print 2");
//         }
//         static void Main(string[] args){
//             Program myProgram = new Program();
//             myProgram.print();
//             myProgram.print1();
//             myProgram.print2();
//         }
//     }
// }



// EXPLICIT INTERFACE IN C#





// Dependency Injection (DI) in C#
// 
// namespace Interfaces {
//     interface i1{
//         void SHOW();
//     }
//     interface i2{
//         void SHOW();
//     }
     
//     class Program:i1,i2{
//          void i1.SHOW(){
//             Console.WriteLine("Hello from intreface one");
//         }
//          void i2.SHOW(){
//             Console.WriteLine("Hello from intreface two");
//         }
         
//         static void Main(string[] args){
//             Program myProgram = new Program();
//             ((i1)myProgram).SHOW();
//             ((i2)myProgram).SHOW();
            

//             i1 obj = new Program();
//             obj.SHOW();

//             i2 obj1 = new Program();
//             obj1.SHOW();
            

//         }
//     }
// }

// SIMILARITIES BETWEEN ABSTRACT CLASSES AND INTERFACE IN C#
// 1. Abstract classed and Interface both declare method without implementing them.
// 2. Both,abstract classes as well as interface , contains abstract method.
// 3. Abstract method of both are implemented by the inheriting the class.
// 4. Both abstract class and Interface can inherit multiple interfaces.


// namespace similarity_Asbtract_Interface{
//     interface myInterface{
//         void print();
//     }

//     abstract class myAbstract{
//         public abstract void print1();
//     }

//     class Exaple:myAbstract,myInterface{
//         public void print(){

//         }
//         public override void print1()
//         {
            
//         }
//     }
// }



// DIS-SIMILARITIES BETWEEN ABSTRACT CLASSES AND INTERFACE IN C#
// 1. An abstract class can inherit a class and multiple interfaces. but . An interface can inherit multiple interfaces 
// but cannot inherit a class.
// 2. An abstract class can have methhods with a body. BUT . An interface cannot have methods with a body.
// 3. An abstract class method is implemented using the override keyword. BUT > An Interfcae method is implemented without
// using the override keyword.
// 4. An abstract class is better options when you need to implement common method and declare common abstract methods.
// An Interface is a better option when you need to declare only abstract methods.
// 5. An Abstract class can declare constructor and destructors. but . AN Interface cannot decalre constructor and destructors.
// 6. If you want ot decalre an abstract member in abstract class then abstract keyword is mandatory.
//      If youwant to declare an asbstract memeber in interface then abstract keyword is not mandatory 
//      because member of interface are abstract by default.


// MUTIPLE INHERITANCE
// Multiple inheritance is a features in which a class can inherit characteristics and features from more than one parent class.

// In C# we do not have concept of mutiple inheritance using classes . but we do have concept of multiple 
// inheritance using Interface.

// A class can extends or inherits only one class but a class can implements or inherit one or more than one interface.





// Generics In c#
// 1. Generic allows you to write a class or method that can work with any data type.
// 2. Generic allows you to define a class with placeholders for the type of its fields, methods, 
//      parameters etc Generic replace these placeholders with some specific type at complie time. It helps you
//      maximize code resue, type sefety and performance.
// 3. You can create your own generic interface, classes , methos,events and delegates.
// 4. You may get information on the types used in a generic data type at run time.
// 5. A generic class or method can defined using angle brackets<> .



// namespace Generic{
//     class Example{
//         public static void ShowArray<T>(T[] arr){
//             for(int i=0;i<arr.Length;i++){
//                 Console.WriteLine(arr[i]);
//             }
//         }
//     }

//     class Program{
//         static void Main(string[] args){
//             int[] numbers = new int[3]{1,2,343};
//             string[] names = new string[3]{"vicky","priyanka","ritik"};
//             Example.ShowArray(numbers);
//             Example.ShowArray(names);
//             Example.ShowArray(['a','b','c']);
//         }
//     }     
// }

// GENERICS CN BE APPLIED TO THE FOLLOWING :
// 1. Interface
// 2. Abstract Class
// 3. Class
// 4. Method
// 5. Static Method
// 6. Property
// 7. Event
// 8. Delegates
// 9. Operator

// ADVANTAGES OF GENERIC:
// 1. Increase the reusability of the code.
// 2. Generic are type safe. You will get compile time error if you try to use a different type of data than the one 
//      specified in the definition.
// 3. Generic has a performance advantages because it removes the possibilities of boxing and unboxing.



// GENERIC METHODS
// 1. Generic method process values whose data types are known only when accessing the variables that store these values.
// 2. A generics method is declared with the generic type parameter list enclosed within <>.
// 3. Defining methods with ttype parameters allow you to call the method with a different type every time.
// 4. You can declare a generic method within generic or non-generic class declarations.

// GENERIC CLASS
// 1. Generic Class define functionalities that can be used for any type and are declared with a class declaration
//      followed bya type parameter enclosed within angular brackets.
// 2. Generic introduced in C# 2.0. Generic allows you to define a class with placeholders for the type of its fields,
//       methods, parameters,etc,. Generics replace these placeholders with some specific type at complier time.



