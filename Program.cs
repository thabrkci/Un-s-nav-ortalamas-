using System;

namespace UniversityExamAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the PersonInfo class
            PersonInfo personInfo = new PersonInfo();
            // Get personal information from the user
            personInfo.GetInfo();

            // Display a welcome message with the user's name and surname
            Console.WriteLine($"Welcome:||| {personInfo.Name} {personInfo.Surname}");

            int universityScore;
            Console.WriteLine("Please enter your University Exam score.");

            // Validate and get the University Exam score from the user
            while (!int.TryParse(Console.ReadLine(), out universityScore) || universityScore <= 0)
            {
                Console.WriteLine("Please enter a valid number.");
                Console.Write("Please enter a valid score: ");
            }

            // Display the entered score
            Console.WriteLine($"Your entered score: {universityScore}");

            // Evaluate the score and provide recommendations
            if (universityScore >= 400 && universityScore <= 500)
            {
                Console.WriteLine($"{personInfo.Name} Congratulations! You can consider Trabzon Law or Rize Law.");
            }
            else if (universityScore >= 300 && universityScore < 400)
            {
                Console.WriteLine($"{personInfo.Name} Congratulations! Good score, you can try Erzurum Law or these Ankara Law, Gaziantep Law.");
            }
            else
            {
                Console.WriteLine($"{personInfo.Name} It looks like you might need to study again. What do you think?");
            }
        }
    }

    // Class for storing personal information
    public class PersonInfo
    {
        // Properties for Name and Surname
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public long Tcno { get; set ;}

        // Method to get personal information from the user
        public void GetInfo()
        {
            Console.WriteLine("Welcome, Please Enter Your Information.");

            // Get user input for Name and Surname
            Name = GetUserInput("Name");
            Surname = GetUserInput("Surname");
            Tcno = Convert.ToInt32(GetUserInput("Tcno:"));
        }

        // Helper method to get user input for a specific field
        static string GetUserInput(string fieldName)
        {
            Console.Write($"{fieldName}: ");
            return Console.ReadLine();
        }
    }
}
