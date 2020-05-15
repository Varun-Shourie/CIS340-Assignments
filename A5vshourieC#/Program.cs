using System;
using static System.Console;

namespace A5vshourie
{
    class GradeSystem
    {
        // Declares two arrays to store scores and names.
        static int[] scoreArray;
        static String[] nameArray;

        // Prompts the user to enter names and stores the names in the names array.
        private static void PopulateNameArray()
        {
            WriteLine("************************************");
            Write("Enter the names of {0} students.\n", nameArray.Length);
            WriteLine("************************************\n");

            for(int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = ReadLine();
            }
        }

        // Prompts the user for and reads five student scores.
        private static void PopulateScoreArray()
        {

            WriteLine("************************************");
            WriteLine("Enter scores. One per line.");
            WriteLine("************************************\n");

            for(int i = 0; i < scoreArray.Length; i++)
            {
                Write("Enter score for {0}: ", nameArray[i]);
                scoreArray[i] = Convert.ToInt32(ReadLine());
            }
        }

        // Finds and returns the location of a student in the names array.
        private static int FindStudentPosition(String nameOfStudent)
        {

            for(int i = 0; i < nameArray.Length; i++)
            {
                if (nameOfStudent.Equals(nameArray[i], StringComparison.OrdinalIgnoreCase))
                    return i;
            }

            // If a match is not found, then a -1 is returned to symbolize an error. 
            return -1;
        }

        // Executes the student grade system.
        public static void Main(string[] args)
        {
            // Stores the user's desired student name and position number of the student.
            string studentName = "";
            int studentPosition = 0;

            // Five elements are allocated because we only consider five students in this program.
            scoreArray = new int[5];
            nameArray = new string[5];

            WriteLine("\t\t\t\tStudent Grade System\n");
            WriteLine("This program will store student grades and look them up for you.\n");

            PopulateNameArray();

            WriteLine("\n\n\n");

            PopulateScoreArray();

            WriteLine("\n\n\n");

            Write("Enter name of student whose score you want to find: ");
            studentName = ReadLine();
            studentPosition = FindStudentPosition(studentName);

            // If there was an error in finding the student's position, the error is handled. If not,
            // the program retrieves and displays the student's name and score.
            if(studentPosition == -1)
            {
                WriteLine("\nA student by that name does not exist in the database.\n\n");

                Write("Press Enter key to exit...");
                ReadLine();

                Environment.Exit(0);
            }
            else
            {
                Write("{0}'s score is {1}\n\n", nameArray[studentPosition], scoreArray[studentPosition]);

                Write("Press Enter key to exit... ");
                ReadLine();

                Environment.Exit(0);
            }
        }
    }
}
