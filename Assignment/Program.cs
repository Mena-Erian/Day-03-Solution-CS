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

            StringBuilder result = new StringBuilder(string.Empty);

            Console.WriteLine("Enter Number");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 2; i < number; i++)
            {
                if (i % 2 == 0)
                    result.Append($"{i} ");
            }

            Console.WriteLine(result.ToString());

            #endregion

        }
    }
}
