/* 
 * Author:Jovani Benavides 
 * Course:COMP-003A
 * Purpose:Self check health app "BenaFit" 
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
            // **TODO: by convention, variable names should be in camelCase except for constant or private variables
            string FirstName; string lastName; string yearBorn; string gender; //string TrueGender; 
            char gLetter; // **TODO: by convention, variable names should be in camelCase except for constant or private variables
            int BirthYear; int age; // TODO: by convention, variable names should be in camelCase except for constant or private variables

            // Variables for Questions,
            string physicallyActive; string dailyWalk; string loseWeight; string wDays; // **TODO: by convention, variable names should be in camelCase except for constant or private variables

            // convert to int
            string wHeight; string wWeight; string wCalorieIntake; string wFastFood; string wMiles; string wScale; // **TODO: by convention, variable names should be in camelCase except for constant or private variables

             int scale;  // **TODO: by convention, variable names should be in camelCase except for constant or private variables

            //Ask the user for their name in only letters.
            FirstName = WInputAnswer("Please enter your first name: ");
            lastName = WInputAnswer("Please enter your last name: ");

            // As long as the first and last name do not equal the codes will continue. 
            if (FirstName != lastName)
            {
                do
                {
                    // verifies that a nummber values was entered and if the value was from 1900-2023
                    yearBorn = NInputAnswer("Enter your the year you were born: ");
                    BirthYear = Convert.ToInt16(yearBorn);

                } while (!checkBirthYear(BirthYear));

                // will calculte how old you are in the year 2023
                age = 2023 - BirthYear;

                do
                {
                    // asks for your gender and will only take m,f, or n
                    gender = WInputAnswer("What is your gender? Please enter (M,F, or O):");
                    if (InputCheck(gender))
                    {
                        gender = gender.ToLower();
                        if (gender == "m" || gender == "f" || gender == "o")
                        {
                            break;
                        }
                        else
                        {
                            // allows the user to retry and enter a correct answer.
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("In order to go to the next question we need to know your gender. enter M,F, or O)\nif you do not wish to disclose this inforamtion please select O.\n");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                    }
                } while (true);

                // stores letter entered as the correct gender
                gLetter = Convert.ToChar(gender);

                if (gLetter == 'm')
                {
                    gender = "Male";
                }
                else if (gLetter == 'f')
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }

                // Question secction
                SectionMessageSeparator("There will now be 10 questions you need to answer in order for use to complete our plan for you.");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                // TODO: use the questions (Questions) you have in the arrays section. remember, the variable & its value(s) should be declared before you get to use them.
                // Question array
                /*Q1*/
                wHeight = NInputAnswer("Please enter your height in Inches:"); // TODO (optional): should this input allow 0 as an entry?
                /*Q2*/
                wWeight = NInputAnswer("\nPlease enter your weight in pounds:"); // TODO (optional): should this input allow 0 as an entry?
                /*Q3*/
                physicallyActive = YesOrNo("\nWould you say you are physically active? Answer:"); // TODO (optional): limit the responses to yes or no
                /*Q4*/
                dailyWalk = YesOrNo("\nDo you walk daily? Answer:"); // TODO (optional): limit the responses to yes or no
                /*Q5*/
                wMiles = NInputAnswer("\nOn average how many miles do you walk in a day? Answer:");
                /*Q6*/
                wFastFood = NInputAnswer("\nHow often do you eat fastfood out of the week? Answer:");
                /*Q7*/
                wCalorieIntake = NInputAnswer("\nHow many calories do you eat in a day:"); // TODO (optional): should this input allow 0 as an entry?
                /*Q8*/
                loseWeight = YesOrNo("\nIs your goal to lose weight? Answer:"); // TODO (optional): limit the responses to yes or no
                /*Q9*/
                wDays = NInputAnswer("\nHow many days out of the week are you available to work out? Answer:");
                  // TODO (optional): should this input allow > 7 as an entry?

                // Arrays for questions and answers.
                string[] responses = new string[] { wHeight, wWeight, physicallyActive, dailyWalk, wMiles, wFastFood, wCalorieIntake, loseWeight, wDays }; // TODO: name this variable more appropriately (e.g., responses)
                                                                                                                                                           //string[] Questions = new string[] { "Please enter your height in Inches:", "Please enter your weight in pounds:","Would you say you are physically active?",
                                                                                                                                                           //   "Do you walk daily?","On average how many miles do you walk in a day?","How often do you eat fastfood out of the week?","How many calories do you eat in a day:",
                                                                                                                                                           //   "Is your goal to lose weight?","How many days out of the week are you available to work out?"}; // TODO: you should be using this data structure in the above section. otherwise, it is simply redundant
              // Header to let the user now this is their profile report
                SectionIntroSeparator($"Profile Report");

                Console.ForegroundColor = ConsoleColor.White;

                // Returns the personal info that the user inputs at the beginning as well as the questions and answers.  
                Console.WriteLine($"User:{FirstName} {lastName}\nAge:{age}\nGender:{gender}");

                // Prints the array for questions and the answers. 
                
                printArray(responses);

                // Header to let the user know the profile is built and there is one more question. 
                SectionMessageSeparator("\t\tThis will be the last question and the evaluation will  be complete.");


                // initiates a switch statement that will return advice based on what your current health self evaluation is.
                /*Q10*/
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("On a scale from 1-10 (1 being poor and 10 being super healthy) how healthy do you think you are? Answer:");
                wScale = Console.ReadLine();
                scale = Convert.ToInt16(wScale); // TODO: since you are not validating this input, consider using a try-catch to handle the exception when getting a string input here

                // the start of the switch statement 1-10 
                Console.ForegroundColor = ConsoleColor.Cyan;           // Switch statement will generate fitness plan based on what you feel your current health is at. 
                switch (scale)
                {
                    case 1:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to make some serious health changes." +
                        $"Lets try excercising {wDays} times a week.\n Right now you are at {wWeight} lets try cutting 40lbs.\nAlso, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories you are consuming it will make it\neasier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 2:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to start taking things more serious." +
                        $"Lets try excercising {wDays} times a week.\nAs of now you are at {wWeight} lets try cutting 35lbs.\nAlso, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories\n you are consuming will make it easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 3:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like you are aware of your current health state and just need a push.\n" +
                        $"So lets try excercising {wDays} times a week. Right now you are at {wWeight} lets try cutting 30lbs.\nAlso, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories you are consuming will make it\n easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 4:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to make some serious health changes." +
                        $"Lets try excercising {wDays} times a week. Right now you are at {wWeight} lets try cutting 25lbs. Also, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories\n you are consuming will make it easier to lose weight.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 5:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we are right in the middle and we want to be at around 7.\n" +
                        $"Lets try excercising {wDays} times a week. Right now you are at {wWeight} lets try cutting 20lbs.\nIf we cut down on fast food" +
                        $"and consume healthy calories it will make it easier to lose weight. Also, it is important to stay consisent.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 3 months. Stay healthy!");
                        break;
                    case 6:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nAlright! Good job you are above average but that doesnt mean we cant improve.\n" +
                        $"How about we train hard {wDays} times a week. Right now you are at {wWeight} lets try cutting 10lbs.\nIts easy to go and eat fast food but lets try meal prepping." +
                        $"Being in control of what you eat and how much eat will\naccelerate reults and get you looking good.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 7:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nYou are awesome! Great job on keeping yourself healthy, this is right where we want to be.\n" +
                        $"For you {wDays} times a week is best and since we are at {wWeight} lets try cutting 5lbs.\nThe easiest way to maintain this level is" +
                        $"cutting out unhealthy food options and increasing our healthy calories.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 8:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nAmazing! You are very healthy.\n" +
                        $"Since you are healthy lets stay with working out {wDays} times a week.\nThen if you arent already watching your food intake " +
                        $"we suggest that you start, since its the easiet way to maintain your health.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 9:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nWOW! It is amazing to see people this healhty.\n" +
                        $"Well it looks like you know what you are doing. All we can say is keep up the good work and always try to improve yourself." +
                        $"Here's a tip, try creating routine and following this routine.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 10:
                        Console.WriteLine($"\n{FirstName} here is was the team at BenaFit thinks is best for you.\nWe are speechless! You are a superhuman." +
                        $"The BenaFit team applaud your hard work and we will support you at all times. Theres isnt much for us to reoport back," +
                        $"but its great to see you are still trying to find ways to improve.\nThank you {FirstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                }
            }
        }
        /// <summary>
        /// Section Header for short text or long text
        /// </summary>
        /// <param name="section"></param>
        static void SectionIntroSeparator(string section)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("".PadRight(120, '~') + $"\n\t\t\t\t\t\t{section}\n" + "".PadRight(120, '~'));
        }
        static void SectionMessageSeparator(string section)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("".PadRight(120, '~') + $"\n\t{section} \n" + "".PadRight(120, '~'));
        }
        /// <summary>
        /// Checks to see if only words are being enterd. 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        static bool InputCheck(string Name)
        {
            Name = Name.ToLower();

            string pattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(Name, pattern))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks to see if only numbers are  being entered.
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
        /// Checks if the Birthyear is valid and outputs error in red
        /// </summary>
        /// <param name="BirthYear"></param>
        /// <returns></returns>
        static bool checkBirthYear(int BirthYear) // TODO: by convention, methods should be in PascalCase
        {
            if (BirthYear >= 1900 && BirthYear <= 2023) // TODO: update the max value to to DateTime.Now.Year so the year dynamic
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
        /// Will out put an Error notice if numbers or special characters were entered and outputs error in red
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
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }
        /// <summary>
        /// Will out put an Error notice if letters or special characters were entered and outputs error in red
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

        // TODO: add xml comments here
        // Method that will print each questions and answer.
        /// <summary>
        /// This method will print the array of questioins with answers. 
        /// </summary>
        /// <param name="answers"></param>
        static void printArray(string[] answers) // TODO: by convention, methods should be in PascalCase
        {
            // TODO: include the question and response number (e.g., Question 1... Response 1... etc...)
            for (int i = 0; i < answers.Length; i++)
            {

                Console.Write("Question {0}: ", i + 1);
                Console.WriteLine("\nRepsonse {0}: {1}", i + 1, answers[i]);
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        
         static YesOrNo (string question)
        {
            string answer;
            while (true)
            {
                Console.Write(question);
                answer = Console.ReadLine();
                if (InputCheck(answer))
                    {
                        answer = answer.ToLower();
                        if (answer == "yes" || answer == "no")
                        {
                            break;
                        }
                        else
                        {
                            // allows the user to retry and enter a correct answer.
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please only answer yes or no.n");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                    }
        

        }

    
}

