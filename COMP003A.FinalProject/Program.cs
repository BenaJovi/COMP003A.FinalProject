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
            // *TODO: by convention, variable names should be in camelCase except for constant or private variables
            string firstName; string lastName; string yearBorn; string gender;
            char genderLetter; // *TODO: by convention, variable names should be in camelCase except for constant or private variables
            int birthYear; int age; // TODO: by convention, variable names should be in camelCase except for constant or private variables

            // Variables for Questions,
            string physicallyActive; string dailyWalk; string loseWeight; string wDays; // TODO: by convention, variable names should be in camelCase except for constant or private variables

            // convert to int
            string wHeight; string wWeight; string wCalorieintake; string wFastfood; string wMiles; string wScale; // TODO: by convention, variable names should be in camelCase except for constant or private variables

            int fastFood; int Height; int weight; int scale; int days; int calorieIntake; int miles; // TODO: by convention, variable names should be in camelCase except for constant or private variables

            //Ask the user for their name in only letters.
            firstName = WInputAnswer("Please enter your first name: ");
            lastName = WInputAnswer("Please enter your last name: ");

            // As long as the first and last name do not equal the codes will continue. 
            if (firstName != lastName)
            {
                do
                {
                    // verifies that a nummber values was entered and if the value was from 1900-2023
                    yearBorn = NInputAnswer("Enter your the year you were born: ");
                    birthYear = Convert.ToInt16(yearBorn);

                } while (!CheckBirthYear(birthYear));

                // will calculte how old you are in the year 2023
                age = 2023 - birthYear;

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
                genderLetter = Convert.ToChar(gender);

                if (genderLetter == 'm')
                {
                    gender = "Male";
                }
                else if (genderLetter == 'f')
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

                // TODO: *use the questions (Questions) you have in the arrays section. remember, the variable & its value(s) should be declared before you get to use them.
                // Question array
                string[] Questions = new string[10];
                Questions[1] = wHeight = NInputAnswer("Please enter your height in Inches:"); Height = Convert.ToInt16(wHeight);
                Questions[2] = wWeight = NInputAnswer("Please enter your weight in pounds:"); weight = Convert.ToInt16(wHeight);
                Questions[3] = physicallyActive = WInputAnswer("Would you say you are physically active?");
                Questions[4] = dailyWalk = WInputAnswer("Do you walk daily?");
                Questions[5] = wMiles = NInputAnswer("On average how many miles do you walk in a day?"); miles = Convert.ToInt16(wMiles);
                Questions[6] = wFastfood = NInputAnswer("How often do you eat fastfood out of the week?"); fastFood = Convert.ToInt16(wFastfood);
                Questions[7] = wCalorieintake = NInputAnswer("How many calories do you eat in a day:"); calorieIntake = Convert.ToInt16(wCalorieintake);
                Questions[8] = loseWeight = WInputAnswer("Is your goal to lose weight?");
                Questions[9] = wDays = NInputAnswer("How many days out of the week are you available to work out?"); days = Convert.ToInt16(wDays);

                List<string> Answer = new List<string> { };List<string> Question = new List<string> { };
                Question.Add("Please enter your height in Inches:");
                Answer.Add

                Question.Add("Please enter your weight in pounds:");
                Answer.Add

                Question.Add("Would you say you are physically active?");
                Answer.Add

                Question.Add("Do you walk daily?");
                Answer.Add

                Question.Add("On average how many miles do you walk in a day?");
                Answer.Add

                Question.Add("How often do you eat fastfood out of the week?");
                Answer.Add

                Question.Add("How many calories do you eat in a day:");
                Answer.Add

                Question.Add("Is your goal to lose weight?");
                Answer.Add

                Question.Add("How many days out of the week are you available to work out?");
                Answer.Add

                /*{ "Please enter your height in Inches:", "Please enter your weight in pounds:","Would you say you are physically active?",
                    "Do you walk daily?","On average how many miles do you walk in a day?","How often do you eat fastfood out of the week?","How many calories do you eat in a day:",
                    "Is your goal to lose weight?","How many days out of the week are you available to work out?"};*/

                     

                SectionIntroSeparator($"Profile Report");

                Console.ForegroundColor = ConsoleColor.White;

                // Returns the personal info that the user inputs at the beginning as well as the questions and answers.  
                Console.WriteLine($"User:{firstName} {lastName}\nAge:{age}\nGender:{gender}");

                // Prints the array for questions and the answers. 
               // PrintArray(Answer, Questions);

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
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to make some serious health changes." +
                        $"Lets try excercising {wDays} times a week.\n Right now you are at {wWeight} lets try cutting 40lbs.\nAlso, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories you are consuming it will make it\neasier to lose weight.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 2:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to start taking things more serious." +
                        $"Lets try excercising {wDays} times a week.\nAs of now you are at {wWeight} lets try cutting 35lbs.\nAlso, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories\n you are consuming will make it easier to lose weight.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 3:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nIt looks like you are aware of your current health state and just need a push.\n" +
                        $"So lets try excercising {wDays} times a week. Right now you are at {wWeight} lets try cutting 30lbs.\nAlso, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories you are consuming will make it\n easier to lose weight.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 4:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we need to make some serious health changes." +
                        $"Lets try excercising {wDays} times a week. Right now you are at {wWeight} lets try cutting 25lbs. Also, by increasing your daily miles," +
                        $"then cutting the amount of fast food and calories\n you are consuming will make it easier to lose weight.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 5:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nIt looks like we are right in the middle and we want to be at around 7.\n" +
                        $"Lets try excercising {wDays} times a week. Right now you are at {wWeight} lets try cutting 20lbs.\nIf we cut down on fast food" +
                        $"and consume healthy calories it will make it easier to lose weight. Also, it is important to stay consisent.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 3 months. Stay healthy!");
                        break;
                    case 6:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nAlright! Good job you are above average but that doesnt mean we cant improve.\n" +
                        $"How about we train hard {wDays} times a week. Right now you are at {wWeight} lets try cutting 10lbs.\nIts easy to go and eat fast food but lets try meal prepping." +
                        $"Being in control of what you eat and how much eat will\naccelerate reults and get you looking good.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 7:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nYou are awesome! Great job on keeping yourself healthy, this is right where we want to be.\n" +
                        $"For you {wDays} times a week is best and since we are at {wWeight} lets try cutting 5lbs.\nThe easiest way to maintain this level is" +
                        $"cutting out unhealthy food options and increasing our healthy calories.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 8:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nAmazing! You are very healthy.\n" +
                        $"Since you are healthy lets stay with working out {wDays} times a week.\nThen if you arent already watching your food intake " +
                        $"we suggest that you start, since its the easiet way to maintain your health.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 9:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nWOW! It is amazing to see people this healhty.\n" +
                        $"Well it looks like you know what you are doing. All we can say is keep up the good work and always try to improve yourself." +
                        $"Here's a tip, try creating routine and following this routine.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
                        break;
                    case 10:
                        Console.WriteLine($"\n{firstName} here is was the team at BenaFit thinks is best for you.\nWe are speechless! You are a superhuman." +
                        $"The BenaFit team applaud your hard work and we will support you at all times. Theres isnt much for us to reoport back," +
                        $"but its great to see you are still trying to find ways to improve.\nThank you {firstName} {lastName} for using BenaFit! Please report back in 6 months. Stay healthy!");
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
        static bool CheckBirthYear(int BirthYear) // TODO: by convention, methods should be in PascalCase
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
        static void PrintArray(string[] Questions, string[] answers) // TODO: by convention, methods should be in PascalCase
        {
            // TODO: include the question and response number (e.g., Question 1... Response 1... etc...)
            for (int i = 1; i < Questions.Length; i++)
            {
                Console.Write($"Questions {i}:{Questions[i]}");
                Console.WriteLine($"\nAnswer:{answers[i]}");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }

}


