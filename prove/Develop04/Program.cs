using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop to keep the program running until the user chooses to exit
        while (true)
        {
            Activity activity = new Activity();
            activity.DisplayMenu();

            int choice = 0;
            bool isValidInput = false;

            // Loop until the user enters a valid integer (1-4)
            while (!isValidInput)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                // Try parsing input to an integer
                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
                {
                    isValidInput = true; // Exit input loop if valid
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                }
            }

            // Process valid choice
            Console.Clear();
            if (choice == 1)
            {
                int breathingDuration = activity.PromptDuration();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.",
                    breathingDuration);
                breathingActivity.StartActivity();
                breathingActivity.DoBreathingActivity(breathingDuration);
            }
            else if (choice == 2)
            {
                int listingDuration = activity.PromptDuration();
                ListingActivity listingActivity = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by \nhaving you list as many things as you can in a certain area.",
                    listingDuration);

                listingActivity.StartActivity();
                listingActivity.StartListingActivity(listingDuration);
            }
            else if (choice == 3)
            {
                int reflectionDuration = activity.PromptDuration();
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity",
                    "This activity will help you reflect on times in your life when \nyou have shown strength and resilience. This will help you recognize \nthe power you have and how you can use it in other aspects of your life.",
                    reflectionDuration);

                reflectionActivity.StartActivity();
                reflectionActivity.StartReflectionActivity(reflectionDuration);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                return; // Exit the program
            }
        }
    }
}
