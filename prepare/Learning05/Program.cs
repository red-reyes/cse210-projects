using System;
namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment1 = new Assignment();
            assignment1.SetStudentName("Rhea June");
            assignment1.SetTopic("Inheritance");
            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine();

            MathAssignment assignment2 = new MathAssignment();
            assignment2.SetStudentName("Rupert James");
            assignment2.SetTopic("Algebra");
            assignment2.SetTextbookSection("Equations");
            assignment2.SetProblems("20a - 24e");
            Console.WriteLine(assignment2.GetSummary());
            Console.WriteLine(assignment2.GetHomeworkList());
            Console.WriteLine();

            WritingAssignment assignment3 = new WritingAssignment();
            assignment3.SetStudentName("Ruby Jane");
            assignment3.SetTopic("Essay Writing");
            assignment3.SetTitle("The Odyssey");
            assignment3.SetAuthor("Homer");
            Console.WriteLine(assignment3.GetSummary());
            Console.WriteLine(assignment3.GetWritingInformation());
        }
    }
}

