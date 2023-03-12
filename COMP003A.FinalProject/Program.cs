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
            SectionIntroSeparator("Welcome to BenaFit");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Variables for first section
            string FirstName; string lastName; string YearBorn; string Gender;
            char Gletter;
            int BirthYear; int age;
            // Variables for Questions,
            string PhysicallyActive; string DailyWalk; string LoseWeight; string Wdays;
            // convert to int
            string Wheight; string Wweight; string Wcalorieintake; string Wfastfood; string Wmiles; string Wscale;

            int FastFood; int Height; int weight; int scale; int days; int CalorieIntake; int miles;

            FirstName = WInputAnswer("Please enter your first name: ");
            lastName = WInputAnswer("Please enter your last name: ");

            if(FirstName != lastName ) 
            {
                do
                {
                    YearBorn = NInputAnswer("Enter your the year you were born: ");
                    BirthYear = Convert.ToInt16(YearBorn);
                } while (!checkBirthYear(BirthYear));
                age = 2023 - BirthYear;
                do
                {
                    Gender = WInputAnswer("What is your gender? Please enter (M,F, or N):");
                    if (InputCheck(Gender))
                    {
                        Gender = Gender.ToLower();
                        if (Gender == "m" || Gender == "f" || Gender == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.DarkRed;
                            Console.WriteLine("In order to go to the next question we need to know your gender\nif you do not wish to disclose this inforamtion please select N.\n");
                            Console.ForegroundColor= ConsoleColor.DarkMagenta;
                        }
                    }
                } while (true);
                Gletter = Convert.ToChar(Gender);
            }
             
            
             
            SectionMessageSeparator("There will now be 10 questions you need to answer in order for use to complete our plan for you.");
            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            // Question array
 /*Q1*/    Wheight = NInputAnswer("Please enter your height in Inches:");
            Height= Convert.ToInt16(Wheight);
 /*Q2*/    Wweight = NInputAnswer("\nPlease enter your weight in pounds:");
            weight = Convert.ToInt16(Wweight);
 /*Q3*/    PhysicallyActive = WInputAnswer("\nWould you say you are physically active? Answer:");
 /*Q4*/    DailyWalk = WInputAnswer("\nDo you walk daily? Answer:");
 /*Q5*/    Wmiles = NInputAnswer("\nOn average how many miles do you walk in a day? Answer:");
            miles = Convert.ToInt16(Wmiles);
 /*Q6*/    Wfastfood = NInputAnswer("\nHow often do you eat fastfood out of the week? Answer:");
            FastFood = Convert.ToInt16(Wfastfood);
 /*Q7*/    Wcalorieintake = NInputAnswer("\nHow many calories do you eat in a day:");
            CalorieIntake = Convert.ToInt16(Wcalorieintake);
 /*Q8*/    LoseWeight = WInputAnswer("\nIs your goal to lose weight? Answer:");
 /*Q9*/    Wdays = NInputAnswer("\nHow many days out of the week are you avaible to work out? Answer:");
            days= Convert.ToInt16(Wdays);  

            string[] QuestArray = new string[] { Wheight, Wweight, PhysicallyActive, DailyWalk, Wmiles, Wfastfood, Wcalorieintake, LoseWeight, Wdays };
            printArray(QuestArray);
            /*string[] strAnswers = new string[8];
            strAnswers[0] = Wheight;
            strAnswers[1] = Wweight;
            strAnswers[2] = PhysicallyActive;
            strAnswers[3] = DailyWalk;
            strAnswers[4] = Wmiles;
            strAnswers[5] = Wfastfood;
            strAnswers[6] = Wcalorieintake;
            strAnswers[7] = LoseWeight;
            strAnswers[8] = Wdays;
            */



/*Q10*/     Console.Write("\nOn a scale from 1-10 (1 being poor and 10 being super healthy) how healthy do you think you are? Answer:");
            Wscale= Console.ReadLine();
            scale=Convert.ToInt16(Wscale);

            switch(scale)
            {
                case 1:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to make some serious health changes.");
                    Console.WriteLine($"Lets try excercising {Wdays} times a week. Right now you are at {Wweight} lets try cutting 40lbs.\n Also, by increasing your daily miles,");
                    Console.WriteLine($"then cutting the amount of fast food and calories you are consuming will make it easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 2:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to start taking things more serious.");
                    Console.WriteLine($"Lets try excercising {Wdays} times a week. Right now you are at {Wweight} lets try cutting 35lbs. Also, by increasing your daily miles,");
                    Console.WriteLine($"then cutting the amount of fast food and calories you are consuming will make it easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 3:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like you are aware of your current health state and just need a push.");
                    Console.WriteLine($"So lets try excercising {Wdays} times a week. Right now you are at {Wweight} lets try cutting 30lbs. Also, by increasing your daily miles,");
                    Console.WriteLine($"then cutting the amount of fast food and calories you are consuming will make it easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 4:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to make some serious health changes.");
                    Console.WriteLine($"Lets try excercising {Wdays} times a week. Right now you are at {Wweight} lets try cutting 25lbs. Also, by increasing your daily miles,");
                    Console.WriteLine($"then cutting the amount of fast food and calories you are consuming will make it easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 5:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we are right in the middle and we want to be at around 7.");
                    Console.WriteLine($"Lets try excercising {Wdays} times a week. Right now you are at {Wweight} lets try cutting 20lbs. If we cut down on fast food");
                    Console.WriteLine($"and consume healthy calories it will make it easier to lose weight. Also, it is important to stay consisent.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 3 months. Stay healthy!");
                    break;
                case 6:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nAlright! Good job you are above average but that doesnt mean we cant improve.");
                    Console.WriteLine($"How about we train hard {Wdays} times a week. Right now you are at {Wweight} lets try cutting 10lbs.Its easy to go and eat fast food but lets try meal prepping.");
                    Console.WriteLine($"Being in control of what you eat and how much eat will accelerate reults and get you looking good.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 7:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nYou are awesome! Great job on keeping yourself healthy, this is right where we want to be.");
                    Console.WriteLine($"For you {Wdays} times a week is best and since we are at {weight} lets try cutting 5lbs. The easiest way to maintain this level is");
                    Console.WriteLine($"cutting out unhealthy food options and increasing our healthy calories.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 8:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nAmazing! You are very healthy.");
                    Console.WriteLine($"Since you are healthy lets stay with working out {Wdays} a week. Then if you arent already watching your food intake");
                    Console.WriteLine($"we suggest that you start, since its the easiet way to maintain your health.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 9:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nWOW! It is amazing to see people this healhty.");
                    Console.WriteLine($"Well it looks like you know what you are doing. All we can say is keep up the good work and always try to improve yourself.");
                    Console.WriteLine($"Here's a tip, try creating routine and following this routine.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
                case 10:
                    Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nWe are speechless! You are a superhuman.");
                    Console.WriteLine($"The BenaFit team applaud your hard work and we will support you at all times. Theres isnt much for us to reoport back,");
                    Console.WriteLine($"but its great to see you are still trying to find ways to improve.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                    break;
            }
     
        }
        /// <summary>
        /// Section Header 
        /// </summary>
        /// <param name="section"></param>
        static void SectionIntroSeparator(string section)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("".PadRight(120, '~') + $"\n\t\t\t\t\t\t{section}\n" + "".PadRight(120, '~'));
        }
        static void SectionMessageSeparator(string section)
        {
            Console.ForegroundColor =ConsoleColor.Blue;
            Console.WriteLine("".PadRight(120, '~') + $"\n\t{section} \n" + "".PadRight(120, '~'));
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry that date is invalid. Pleae enter a date from 1900-2023. Try again.");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                return false;
            }
        }

        /// <summary>
        /// Answers
        /// </summary>
        /// <param name="question"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        static string WInputAnswer(string question)
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
                   Console.ForegroundColor = ConsoleColor.DarkRed;
                   Console.WriteLine("ERROR: Please only use letters.");
                   Console.ForegroundColor=ConsoleColor.DarkMagenta;
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please only use numbers.");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }
        static void printArray(string[] arr)
        {
            SectionIntroSeparator("Profile Report");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Answers:{arr[i]}");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }
}

