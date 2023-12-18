using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Name: Pranav More
// Class: HNC Computing Group B
// Project Description: LO1 Assessment
// Date: 11/12/2023

namespace FuctionsSysAssessment
{
    class Program
    {

            //Forename is a global variable 
            static string Forename;
        static void Main(string[] args)
        {

            Console.WriteLine("What is your forename?");
            Forename = Console.ReadLine();

            //welcome the user to the program
            Console.WriteLine($"Welcome to the functions program, {Forename}");


            int choice = 0;

            //main menu loop

            do
            {
                display_menu();
                get_choice(ref choice);

                act_on_choice(choice);

            } while (choice != 3);

            
        }



        //                MENU                  //




        static void display_menu()
        {
            //called by main() when run, shows the required headings for user

            Console.WriteLine("MENU\n");
            Console.WriteLine("Option 1: String Function");
            Console.WriteLine("Option 2: Number Function");
            Console.WriteLine("Option 3: EXIT \n");


        }

        static void get_choice(ref int choice)
        //Get user's choice, whatever the user picks, the next function will show
        {
            //get choice
            Console.WriteLine("Enter your choice: ");
            int tempChoice;

            //check choice is integer
            if (!int.TryParse(Console.ReadLine(), out tempChoice) || tempChoice < 1 || tempChoice > 3)
            {
                Console.WriteLine("This is NOT a legal integer. Please enter a valid integer (1 -3).");
            }
            else
            {
                Console.WriteLine("This is a legal integer");
                choice = tempChoice;
            }



        }
        static void act_on_choice(int choice)
        {

            string user_name = ""; 

            // when user presses number this loop calls the needed function to run

            //process case options
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have chosen option 1");
                    string_function(user_name);
                    break;
                case 2:
                    Console.WriteLine("You have chosen option 2");
                    number_function();
                    break;
                case 3:
                    Console.WriteLine("You have chosen option 3 to EXIT");
                    break;
                default:

                    //end switch
                    Console.WriteLine("Incorrect, please enter an option between 1 and 3 ");
                    break;

            }
        }

        static void string_function(string user_name)
        {
            // Print message and user_name
            Console.WriteLine($"This is Option 1, {Forename}");

            // get fullname
            Console.WriteLine("Enter your Fullname: ");
            string surname = Console.ReadLine();

            // call create_name()
            if (!string.IsNullOrEmpty(surname))// check if surname field is not empty 
            {
                create_name(surname);
            }
            else
            {
                Console.WriteLine("Invalid surname. Please enter a valid surname.");
            }
        }

        static void number_function()
        {
            //initialise variables

            int times_table = 0;
            int random_number = 0;
            int answer = 0;
            int user_answer = 0;
            //get times_tables
            Console.WriteLine("Enter the vaules of the times tables to test: ");
            times_table = Convert.ToInt32(Console.ReadLine());
            //process test questions
            if (times_table > 0)
            {
                Random rnd = new Random();
                random_number = rnd.Next(10) + 1;

                answer = times_table * random_number;

                //process test question
                Console.WriteLine($"What is {times_table} * {random_number}? ");
                user_answer = Convert.ToInt32(Console.ReadLine());

                
                if (user_answer != answer)
                {
                    Console.WriteLine($"Incorrect! Displaying times table for {times_table}");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{times_table} * {i} = {times_table * i}");

                    }

                }
                else
                {
                    Console.WriteLine("Well Done! You got it right!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive whole number greated than 0");
            }

        }

        static void create_name(string Forename) {

     
            //assign first character
            char initial = Forename[0];

            //process username
            int spaceIndex = Forename.IndexOf(' ');

            //print username
            if (spaceIndex != -1 && spaceIndex + 1 < Forename.Length)
            {
                
                string surname = Forename.Substring(spaceIndex + 1);

                
                string user_name = initial.ToString() + surname;

                
                Console.WriteLine("Your new username is: " + user_name);
            }
            
        

        }

    }
}
