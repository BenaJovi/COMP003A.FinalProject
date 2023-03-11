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
            //Variables for first section
            string FirstName; string lastName; string YearBorn; string Gender;
            char Gletter;
            int BirthYear; int age;
            // Variables for Questions,
            string PhysicallyActive; string DailyWalk; string LoseWeight; string random;
            // convert to int
            string Wheight; string Wweight;
            
            int FastFood; int Height; int weight; int scale; int days;

            FirstName = WInputAnswer("Please enter your first name: ", "ERROR:Invalid Name.Please only use letters.");
            lastName = WInputAnswer("Please enter your last name: ", "ERROR:Invalid Name.Please only use letters.");

            if(FirstName != lastName ) 
            {
                Console.WriteLine($"Welcome {FirstName}{lastName} to BenaFit!\nWe need some more info to build your profile.");
            }
             
            do
            {
                YearBorn = NInputAnswer("Enter your the year you were born: ");
                BirthYear = Convert.ToInt16(YearBorn);
            } while (!checkBirthYear(BirthYear));
            age = 2023 - BirthYear;
            Console.WriteLine($"Looks like you are {age} this year.");
              
            do
            {
                Gender = WInputAnswer(" What is your gender? Please enter (M,F, or N): ", "Please only use letters.");
                if (InputCheck(Gender))
                {
                    Gender = Gender.ToLower();
                    if (Gender == "m" || Gender == "f" || Gender == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("In order to go to the next question we need to know your gender\n if you do not wish to disclose this inforamtion please select N.");
                    }
                }
            } 
            while (true);
            Gletter=Convert.ToChar(Gender);

            // Question array
            Wheight = NInputAnswer("Please enter your height in Inches: ");
           // Height= Convert.ToInt16(Wheight);
            Wweight = NInputAnswer("Please enter your weight in pounds: ");
            // weight = Convert.ToInt16(Wweight);
            PhysicallyActive = WInputAnswer("Would you say you are physically active?", "Please only use letters.");
            DailyWalk = WInputAnswer("Do you walk daily?", "Please only use letters.");
            random = NInputAnswer("On average how many miles do you walk in a day?");
            LoseWeight = WInputAnswer("Are you willing to put the effort and lose weight?", "Please only use letters.");
            






            string[] strArray = new string[] { Wweight, Wweight, PhysicallyActive, DailyWalk, random, LoseWeight };
           
            



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

