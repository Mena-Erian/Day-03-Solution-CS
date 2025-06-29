namespace Demo
{
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

            #endregion
           
            #region Switch Case is Different in C#

            //Console.WriteLine("please Enter your age: ");
            //int.TryParse(Console.ReadLine(), out int age);

            //if (age > 20 && age < 25)
            //    Console.WriteLine("Your Age is Greater than 20");
            //else if (age < 20)
            //    Console.WriteLine("Your Age is Less than 20");
            //else
            //    Console.WriteLine("Your Age Equals 20");

            //switch (age)
            //{
            //    case > 20 and < 25:
            //        Console.WriteLine("Your Age is Greater than 20");
            //        break;
            //    case < 20:
            //        Console.WriteLine("Your Age is Less than 20");
            //        break;
            //    default:
            //        Console.WriteLine("Your Age Equals 20");
            //        break;
            //} 
            #endregion

        }
    }
}
