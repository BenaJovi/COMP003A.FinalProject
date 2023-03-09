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
            Console.Write("Enter your first name: ");
            string Firstname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string Lastname = Console.ReadLine();

            if (Namecheck(Firstname))
            {
      
                Console.WriteLine("Name is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Name.");
            }
            if (Namecheck(Lastname))
            {

                Console.WriteLine("Name is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Name.");
            }
        }
        static bool Namecheck(String Name)
        {
            Name =Name.ToLower();

            string pattern = "^[a-z]";
            if (Regex.IsMatch(Name,pattern))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}

