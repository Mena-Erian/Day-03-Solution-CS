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
        }
    }
}
