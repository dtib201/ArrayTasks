/*
 *   ARRAY TASKS 
 *   Daniel Tibbotts
 *   23/02/2021
 *   
 */

using System;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            /* ******* *
             * Task 1  *
             * ******* */

            Console.WriteLine("Task 1");
            Console.WriteLine("******");

            // Add a new array to the class of size 5 that stores the following possible student grades: 'A', 'B', 'D', 'F'.
            char[] grades = new char[5];
            grades[0] = 'A';
            grades[1] = 'B';
            grades[2] = 'D';
            grades[3] = 'F';

            
            // You realised that you missed one of the grades out. Add a new grade to the array to be the third element: 'C'.
            char[] Grades = new char[5];
            Array.Copy(grades, Grades, 2);
            Grades[2] = 'C';
            Array.Copy(grades, 2, Grades, 3, 2);


            // Display all the elements of the array out.
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.WriteLine(Grades[i]);
            }

            Console.WriteLine();


            /* ******* *
             * Task 2  *
             * ******* */

            Console.WriteLine("Task 2");
            Console.WriteLine("******");

            // Create an array of subject names of size 3.
            // Fill it in with appropriate subject names.
            string[] subjects = new string[3] { "English", "Maths", "Science" };

            // Display only the second element of the array.
            Console.WriteLine(subjects[1]);
            Console.WriteLine();

            // You realised that starting from this year the institute will offer two more subjects. 
            // Resize an array to include 5 subjects and add two more subject names to it.
            string[] Subjects = new string[5];
            Array.Copy(subjects, Subjects, subjects.Length);
            Subjects[3] = "Music";
            Subjects[4] = "Art";

            // Display all the elements of the array out.
            for (int i = 0; i < Subjects.Length; i++)
            {
                Console.WriteLine(Subjects[i]);
            }

            Console.ReadLine();
        }
    }
}
