using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Private_School
{
    class AssignmentPerCourse
    {
        public Course Course { get; set; }

        public List<Assignment> Assignments;


        public AssignmentPerCourse()
        {

        }
        public AssignmentPerCourse(Course course, List<Assignment> assignments)
        {
            Course = course;
            Assignments = new List<Assignment>(assignments);
        }


        public void ShowAssignments()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" Course  {Course.Title}  Has {Assignments.Count}  Assignments :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
            Console.WriteLine("{0,-21}| {1,-30 } | {2,-20} | {3,-9}  | {4,-12} |", "Title", "Description", "Submission Date", "Oral Mark", "Total Mark");
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Assignments)
            {
                item.OutputAssignment();
            }
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
        }


    }
}
