/* 
 * Author:
 * Course:
 * Purpose: 
 */

using System.Text.RegularExpressions;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName; string lastName; string YearBorn; string Gender;
            int BirthYear; int age;
            FirstName = WInputAnswer("Please enter your first name: ", "ERROR:Invalid Name.Please only use letters.");
            lastName = WInputAnswer("Please enter your last name: ", "ERROR:Invalid Name.Please only use letters.");

            if(FirstName != lastName ) 
            {
                Console.WriteLine($" Welcome! {FirstName}{lastName} to BenaFit!\n We need some more info to build your profile.");
            }

            do
            {
                YearBorn = NInputAnswer("Enter your the year you were born: ");
                BirthYear = Convert.ToInt16(YearBorn);
            } while (!checkBirthYear(BirthYear));
            age = 2023 - BirthYear;
            Console.WriteLine($"Looks like we are {age} this year.");

            Console.Write("Enter Gender:");
            Console.ReadLine();
            do
            {
                Gender=WInputAnswer(" What is y")s
            }
        }
        

        /// <summary>
        /// Checks Words
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        static bool InputCheck(string Name)
        {
            Name =Name.ToLower();

            string pattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(Name,pattern))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks Numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool NumberCheck(string number)
        {
            string pattern = "^[0-9]+$";
            if (Regex.IsMatch(number, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Birth
        /// </summary>
        /// <param name="BirthYear"></param>
        /// <returns></returns>
        static bool checkBirthYear(int BirthYear)
        {
            if (BirthYear >= 1900 && BirthYear <= 2023)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry that date is invalid. Pleae enter a date from 1900-2023. Try again.");
                return false;
            }
        }

        /// <summary>
        /// Answers
        /// </summary>
        /// <param name="question"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        static string WInputAnswer(string question, string error)
        {
            string answer;
            while (true)
            {
                Console.Write(question);
                answer = Console.ReadLine();
                if (InputCheck(answer))
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine(error);
                }
            }
        }
        /// <summary>
        /// Verifies Question answer
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static string NInputAnswer(string question)
        {
            string number;
            while (true)
            {
                Console.Write(question);
                number = Console.ReadLine();
                if (NumberCheck(number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please only use numbers.");
                }
            }
        }

    }
}

