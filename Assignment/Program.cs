using System.Diagnostics;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region 1.can be divided by 3 and 4 
            //Console.WriteLine("Please Enter Number can be divided by 3 and 4");
            //int.TryParse(Console.ReadLine(), out int number);

            //if ((number%3) == 0 && (number%4) == 0)
            //Console.WriteLine("Yes");
            //else
            //Console.WriteLine("No");
            #endregion

            #region 2.Insert an Integer Or Negative
            //Console.WriteLine("Please Enter Number");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number > 0)
            //    Console.WriteLine("Positive");
            //else if (number < 0)
            //    Console.WriteLine("Nigative");
            //else
            //    Console.WriteLine("Is = 0 Or Athor");
            #endregion

            #region 3.Max && Min Number

            ///Console.WriteLine("Please Enter Number 1");
            ///int.TryParse(Console.ReadLine(), out int num01);
            ///
            ///Console.WriteLine("Please Enter Number 2");
            ///int.TryParse(Console.ReadLine(), out int num02);
            ///
            ///Console.WriteLine("Please Enter Number 3");
            ///int.TryParse(Console.ReadLine(), out int num03);
            ///
            ///int maxNumber = num01;
            ///int minNumber = num01;
            ///
            ///// Check For Max Number
            ///if (maxNumber < num02)
            ///{
            ///    maxNumber = num02;
            ///    if (maxNumber < num03)
            ///    {
            ///        maxNumber = num03;
            ///    }
            ///}
            ///else if (maxNumber < num03)
            ///{
            ///    maxNumber = num03;
            ///} 
            ///
            ///
            ///// Check For Max Number
            ///if (minNumber > num02)
            ///{
            ///    minNumber = num02;
            ///    if (minNumber > num03)
            ///    {
            ///        minNumber = num03;
            ///    }
            ///}
            ///else if (minNumber > num03)
            ///{
            ///    minNumber = num03;
            ///}
            ///Console.WriteLine($"Max Element = {maxNumber}");
            ///Console.WriteLine($"Min Element = {minNumber}");

            #endregion

            #region 4.Even | Odd

            //Console.WriteLine("Please Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num % 2 == 0)
            //    Console.WriteLine("Your Number Is Even");
            //else
            //    Console.WriteLine("Your Number Is Odd");

            #endregion

            #region 5.Vowel | Consonant

            ///char[] vowelCharacters = { 'a', 'e', 'i', 'o', 'u' };
            ///char character;
            ///bool isParsed = false;
            ///bool isVowelChar = false;
            /////Get Character
            ///do
            ///{
            ///    Console.WriteLine("Enter One Character: ");
            ///    isParsed = char.TryParse(Console.ReadLine(), out character);
            ///    if (!isParsed)
            ///        Console.WriteLine("Your Char Not Valid Please Try Again");
            ///}   //Check is Vaild Or Not
            ///while (!isParsed || char.IsDigit(character));
            ///
            /////Check is Vowel
            ///for (int i = 0; i < vowelCharacters.Length; i++)
            ///{
            ///    if (vowelCharacters[i] == character) isVowelChar = true;
            ///}
            ///
            /////Output
            ///switch (isVowelChar)
            ///{
            ///    case true:
            ///        Console.WriteLine("Vowel");
            ///        break;
            ///    case false:
            ///        Console.WriteLine("Consonant");
            ///        break;
            ///}

            #endregion

            #region 6.Print From 1 to X

            ///Console.WriteLine("Enter Number");
            ///int.TryParse(Console.ReadLine(),out int number);
            ///
            ///for (int i = 0; i < number; i++)
            ///{
            ///    Console.WriteLine(i + 1);
            ///}

            #endregion

            #region 7.Multiplication Tabel Up To 12

            //StringBuilder result = new StringBuilder(string.Empty);

            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(),out int number);

            //for (int i = 1; i <= 12; i++)
            //{
            //    result.Append($"{number * i} ");
            //}

            //Console.WriteLine(result.ToString());

            #endregion

            #region 8.Even Numbers Between 1 To X

            //StringBuilder result = new StringBuilder(string.Empty);

            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 2; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //        result.Append($"{i} ");
            //}

            //Console.WriteLine(result.ToString());

            #endregion

            #region 9.Print The Power

            //Console.WriteLine("Enter 2 Number With Space like This '4 3'");

            //string[] arrayOfString = (Console.ReadLine() ?? "").Split(" ");
            //int[] numbers = [0, 0];
            //int result = 1;
            //for (int i = 0; i < 2; i++)
            //{
            //    int.TryParse(arrayOfString[i], out numbers[i]);
            //}

            //for (int i = 0; i < numbers[1]; i++)
            //{
            //    result = result * numbers[0];
            //}

            //Console.WriteLine(result);

            #endregion

            #region 10.Get (Total,Avg,Percentage) Of Mark

            //int countOfSubjects = 5;
            //Console.Write($"- Enter Marks of {countOfSubjects} Subjects: ");
            //string[] arrayOfString = (Console.ReadLine() ?? "").Split(" ");
            //int[] numbers = new int[countOfSubjects];
            //int totalMark = 0;
            //float avg;
            //float percentage;
            //for (int i = 0; i < countOfSubjects; i++)
            //{
            //    int.TryParse(arrayOfString[i], out numbers[i]);
            //}

            //foreach (int num in numbers)
            //{
            //    totalMark = totalMark + num;
            //}
            //avg = totalMark / countOfSubjects;
            //percentage = ((float)totalMark / (countOfSubjects * 100)) * 100;

            //Console.WriteLine($"Total Marks = {totalMark}");
            //Console.WriteLine($"Averages Marks = {avg}");
            //Console.WriteLine($"Percentage = {percentage}");

            #endregion

            #region 11.Month Number 

            //bool isParsed = false;
            //bool inRang = false;
            //int[] monthNumbers = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
            //int num;
            //do
            //{
            //    Console.Write($"Enter Month Number: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out num);
            //    inRang = (num < 13 && num > 0);
            //    if (!inRang)
            //        Console.WriteLine("Your Input is Not Vaild Try Agian");
            //}
            //while (!isParsed || !inRang);

            //Console.WriteLine($"Days in Month: {monthNumbers[num - 1]}");

            #endregion

            #region 12.Simple Calculater

            //Console.Write("Enter Number 1: ");
            //double.TryParse(Console.ReadLine(), out double num1);

            //Console.Write("Enter Number 2: ");
            //double.TryParse(Console.ReadLine(), out double num2);

            //Console.Write("Enter the Operater + - * /: ");
            //char.TryParse(Console.ReadLine(), out char operater);

            //switch (operater) {
            //    case '+':
            //        Console.WriteLine($"Resulet Of {num1} {operater} {num2} is: {num1 + num2}");
            //        break;                      
            //    case '-':                       
            //        Console.WriteLine($"Resulet Of {num1} {operater} {num2} is: {num1 - num2}");
            //        break;                       
            //    case '*':                        
            //        Console.WriteLine($"Resulet Of {num1} {operater} {num2} is: {num1 * num2}");
            //        break;                     
            //    case '/':                      
            //        Console.WriteLine($"Resulet Of {num1} {operater} {num2} is: {num1 / num2}");
            //        break;
            //}

            #endregion

            #region 13.REVERESE String

            //Console.WriteLine("Enter The String You Want To Reverse");
            //char[] charArray = (Console.ReadLine() ?? "").ToCharArray();

            //Array.Reverse(charArray);
            //string stringReversed = new string(charArray);

            //Console.WriteLine(stringReversed);

            #endregion

            #region 14.REVERESE Integer

            //Console.WriteLine("Enter The Integer You Want To Reverse");
            //char[] charArray = (Console.ReadLine() ?? "").ToCharArray();

            //Array.Reverse(charArray);
            //string integerReveresed = new string(charArray);

            //Console.WriteLine(integerReveresed);

            #endregion

            //Problem here--------------------------------\/
            #region 15.find prime numbers within a range of numbers
            // i dont't know :(

            //Console.WriteLine("Test Data : ");
            //Console.WriteLine("Input Starting Number Of Range : ");
            //int.TryParse(Console.ReadLine(), out int startRange);
            //Console.WriteLine("Input Ending Number Of Range : ");
            //int.TryParse(Console.ReadLine(), out int endRange);

            //StringBuilder sb = new StringBuilder(string.Empty);

            //for (int i = (startRange >= 3 ? startRange : 3); i < endRange; i += 2)
            //{

            //}

            //if (endRange > 2)
            //{
            //    Console.WriteLine("false");
            //}
            //else if (endRange == 2)
            //{
            //    Console.WriteLine("True");
            //}
            //else if (endRange % 2 == 0)
            //{
            //    Console.WriteLine("False");
            //}
            //else
            //{

            //}

            #endregion
            //Problem here--------------------------------/\

            #region 16.Convert Decimal to Binary

            #endregion

            #region 17.Determine whether these points lie on a single straight line

            //int[] point01 = [0, 0];
            //int[] point02 = [0, 0];
            //int[] point03 = [0, 0];

            //Console.WriteLine("Please Enter Points of (X1,y1)");

            //string[] arrOfStr = (Console.ReadLine() ?? "").Split(",");
            //for (int i = 0; i < 2; i++)
            //{
            //    int.TryParse(arrOfStr[i], out point01[i]);
            //}

            //Console.WriteLine("Please Enter Points of (X2,y2)");
            //arrOfStr = (Console.ReadLine() ?? "").Split(",");
            //for (int i = 0; i < 2; i++)
            //{
            //    int.TryParse(arrOfStr[i], out point02[i]);
            //}

            //Console.WriteLine("Please Enter Points of (X3,y3)");
            //arrOfStr = (Console.ReadLine() ?? "").Split(",");
            //for (int i = 0; i < 2; i++)
            //{
            //    int.TryParse(arrOfStr[i], out point03[i]);
            //}
            ////slope = (y2 - y1) / (x2 - x1)
            ////(point02[1]-point01[1]) / (point02[0]-point01[0])
            //float slopeOfP1P2 = (point02[1] - point01[1]) / (point02[0] - point01[0]);
            //float slopeOfP2P3 = (point03[1] - point02[1]) / (point03[0] - point02[0]);

            //Console.WriteLine($"\n\nThe Slope Of Point 1 and 2 is {slopeOfP1P2}");
            //Console.WriteLine($"The Slope Of Point 2 and 3 is {slopeOfP2P3}");

            //if (slopeOfP1P2 == slopeOfP2P3) Console.WriteLine("\nSo it in a Single Straight Line");
            //else Console.WriteLine("\nSo it is in Not on Single Straight Line");

            #endregion

        }
    }
}
