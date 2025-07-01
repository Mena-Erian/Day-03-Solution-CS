using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    public class Person : IEnumerable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        ///any somthing want to wark with foreach should have this interfase that have this function
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //return $"Id = {Id} , Name = {Name}";
            return base.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control Statments 1. Conditional Statments [if, switch]

            #region Example 01 [Numeric Type: Equality]
            //Console.WriteLine("Please Enter an Month Numbers Exsisted in 1st Quarter: ");

            //int.TryParse(Console.ReadLine(), out int monthNumber);


            ///if (monthNumber == 1)
            ///    Console.WriteLine("Hello january");
            ///else if (monthNumber == 2)
            ///    Console.WriteLine("Hello Febraury");
            ///else if (monthNumber == 3)
            ///    Console.WriteLine("Hello March");
            ///else 
            ///    Console.WriteLine("The Entered Month Numbers is not Existed in 1st Quarter");            

            // Jumb Table(HashTable)=>Generated in release mode, Genereted in Compile time and you can
            // see the jumbTable in Il but in (Release mode) 
            // Use Switch statment when we compare with numbaric value (EQUALITY) rather than if statment
            ////switch (monthNumber)
            ////{
            ////    case 1:
            ////         Console.WriteLine("Hello january");
            ////        break;
            ////    case 2:
            ////         Console.WriteLine("Hello Febraury");
            ////        break;
            ////    case 3:
            ////         Console.WriteLine("Hello March");
            ////        break;
            ////    default:
            ////         Console.WriteLine("The Entered Month Numbers is not Existed in 1st Quarter");
            ////        break;
            ////}

            #endregion

            #region Example 02 [Numeric Type: MoreThan, Less Than]

            ///Console.WriteLine("please Enter your age: ");
            ///int.TryParse(Console.ReadLine(), out int age);
            ///
            ///if (age > 20 && age < 25)
            ///    Console.WriteLine("Your Age is Greater than 20");
            ///else if (age < 20)
            ///    Console.WriteLine("Your Age is Less than 20");
            ///else
            ///    Console.WriteLine("Your Age Equals 20");
            ///
            ///switch (age)
            ///{
            ///    case > 20 and < 25:
            ///        Console.WriteLine("Your Age is Greater than 20");
            ///        break;
            ///    case < 20:
            ///        Console.WriteLine("Your Age is Less than 20");
            ///        break;
            ///    default:
            ///        Console.WriteLine("Your Age Equals 20");
            ///        break;
            ///} 

            #endregion

            #region Example 03 [String: Equality]
            //Console.WriteLine("Enter your Name");
            //string Name = Console.ReadLine() ?? "No Name";

            ///if (Name == "Ahmed")
            ///    Console.WriteLine("Hello Ahmed");
            ///else if (Name == "Mina")
            ///    Console.WriteLine("Hello Mina");
            ///else if (Name == "Omar")
            ///    Console.WriteLine("Hello Omer");
            ///else if (Name == "Maged")
            ///    Console.WriteLine("Hello Maged");
            ///else if (Name == "Aya")
            ///    Console.WriteLine("Hello Aya");

            //if i make switching of more than 5 strings so use => Switch ,
            //becouse it will be translate to jumb table (in release Mode) so it will be O(1)
            //but if i have less than so here the switch it like if statment in this point

            ///switch (Name)
            ///{
            ///    case "Ahmed":
            ///         Console.WriteLine("Hello Ahmed");
            ///        break;
            ///    case "Mina":
            ///         Console.WriteLine("Hello Mina");
            ///        break;
            ///    case "Aya":
            ///        Console.WriteLine("Hello Aya");
            ///        break;
            ///    case "Yassmin":
            ///        Console.WriteLine("Hello Yassmin");
            ///        break;
            ///    case "Maged":
            ///        Console.WriteLine("Hello Maged");
            ///        break;
            ///    case "test":
            ///        Console.WriteLine("Hello test");
            ///        break;
            ///} 
            #endregion

            #region Go To Statmint Best Practice
            ///Console.WriteLine("Please Enter Your Buget: ");
            ///   int Budget = int.Parse(Console.ReadLine());
            ///
            ///   switch (Budget)
            ///   {
            ///       case 3000:
            ///           Console.WriteLine("Option 03");
            ///           //Console.WriteLine("Option 02");
            ///           //Console.WriteLine("Option 01");
            ///           goto case 2000;
            ///       case 2000:
            ///           Console.WriteLine("Option 02");
            ///           //Console.WriteLine("Option 01");
            ///           goto case 1000;
            ///       case 1000:
            ///           Console.WriteLine("Option 01");
            ///           break;
            ///   } 
            #endregion

            #region Evolution of Switch Case in C# [7.0]

            //object obj = new object();
            //obj = 10; // Boxing => //like this // new boject(10)
            //
            //obj = new Person { Id = 10, Name = "Mena" };

            ///switch(obj)
            ///{
            ///    case int X: // UnBoxing => int X = 10;
            ///        Console.WriteLine("");
            ///        break;
            ///}

            //object test = new Person();
            //
            //switch (obj)
            //{
            //    //case > 10 and < 20:
            //    // this checks if localInput is of type int
            //    case int localInput when localInput > 10 && localInput < 20:
            //        Console.WriteLine("integer input");
            //        break;
            //    // this checks if localInput is of type double
            //    case double localInput:
            //        Console.WriteLine("double input");
            //        break;
            //                    // Pattern Matching
            //    case Person person when person.Id == 10 && person.Name == "Mena":
            //        Console.WriteLine(person.ToString());
            //        break;
            //    default:
            //        Console.WriteLine("UnKnown input");
            //        break;
            //}

            #endregion

            #region Evolution of Switch Case in C# [8.0]

            #region Pattern Matching Enhancements
            ///Person person1 = new Person { Id = 10, Name = "Mena" };
            ///
            ///switch (person1)
            ///{
            ///    //enhancements in pattern Matching
            ///    case { Id: > 20, Name: "Mena" }:
            ///    //case Person person when person.Id > 20 && person.Name == "Mena":
            ///        Console.WriteLine(person1);
            ///        break;
            ///                    // Pattern Matching
            ///    case Person person when person.Id == 10 && person.Name == "Mena":
            ///        Console.WriteLine(person.ToString());
            ///        break;
            ///    default:
            ///        Console.WriteLine("UnKnown input");
            ///        break;
            ///} 

            #endregion

            #region Switch Expression

            #region Example 01
            //Console.WriteLine("Enter Your Option: ");
            //int.TryParse(Console.ReadLine(),out int option);

            ///string message = string.Empty;

            ///switch (option) 
            ///{
            ///    case 1:
            ///        message = "Option 01";
            ///        break;
            ///    case 2:
            ///        message = "Option 02";
            ///        break;
            ///    case 3:
            ///        message = "Option 03";
            ///        break;
            ///    default:
            ///        message = "any";
            ///        break;
            ///}

            //Switch Expression
            ///message = option switch
            ///{
            ///    1 => "Option 01",
            ///    2 => "Option 02",
            ///    3 => "Option 03",
            ///    _ => "any"
            ///}; Console.WriteLine(message);  

            #endregion

            #region Example 02
            ///Person obj = new Person() { Id = 10, Name = "Mena" };
            ///
            ///string message = string.Empty;
            ///
            ///message = obj switch
            ///{
            ///    { Id: 10, Name: "Mena" } => "Hello any",
            ///    { Id: 20, Name: "any" } => "Hello any",
            ///    { Id: 30, Name: "any" } => "Hello any"
            ///};
            #endregion

            #endregion

            #endregion

            #region Evolution of Switch Case in C# [9.0]

            #region Pattern Matching Enhancements
            #region Example 02
            ///Person obj = new Person() { Id = 10, Name = "Mena" };
            ///
            ///string message = string.Empty;
            ///
            ///message = obj switch
            ///{
            ///    { Id: > 25 and  < 35, Name: "Mena" } => "Hello any",
            ///    { Id: 20, Name: "any" } => "Hello any",
            ///    { Id: 30, Name: "any" } => "Hello any"
            ///};
            #endregion


            #endregion

            #endregion

            #endregion

            #region Control Statments 2. Loop Statments
            // for & while => the same in IL 
            // do while more fast than for & While
            // foreach 4 time Slower than for

            #region [for, foreach]

            //int[] Numbers = [ 1, 2, 3, 4, 5];

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine("*********************");

            // To imelement with for Each Should have [IEnumerable] interface.
            // you don't have the fully control like for
            // whan work that take copy from Orginal arr then make the iteration
            // ( That internal work with three function => Current,..,.. )not sure
            //foreach (int num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}




            #endregion

            #region [while, do..while]

            //int evenNumber = int.Parse(Console.ReadLine() ?? "0");
            ///int number; 
            ///do
            ///{
            ///    Console.WriteLine("Please Enter an Event Number: ");
            ///}
            ///while (int.TryParse(Console.ReadLine(), out number)||number % 2 == 1  );

            // use while if i don't know the iteration of looping
            ///here use for it will to be more readabilte
            ///int i = 0;
            ///while (i<=10)
            ///{
            ///    Console.WriteLine(i);
            ///    i++;
            ///}
            ///
            #endregion


            #endregion


        }
    }
}
