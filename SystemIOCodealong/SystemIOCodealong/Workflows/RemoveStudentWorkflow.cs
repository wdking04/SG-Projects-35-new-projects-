using System;
using System.Collections.Generic;
using System.Text;
using SystemIOCodealong.Data;
using SystemIOCodealong.Helpers;
using SystemIOCodealong.Models;

namespace SystemIOCodealong.Workflows
{
    public class RemoveStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Remove Student");

            StudentRepository repo = new StudentRepository(Settings.FilePath);
            List<Student> students = repo.List();

            ConsoleIO.PrintPickListOfStudents(students);
            Console.WriteLine();

            int index = ConsoleIO.GetStudentIndexFromUser("Which student would you like to delete?", students.Count());
            index--;

            string answer = ConsoleIO.GetYesNoAnswerFromUser($"Are you sure you want to remove {students[index].FirstName} {students[index].LastName}");

            if (answer == "Y")
            {
                repo.Delete(index);
                Console.WriteLine("Student Removed!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Remove cancelled.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
