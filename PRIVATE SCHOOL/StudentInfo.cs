using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Private_School
{
    class StudentInfo
    {
        public Student Student { get; set; }

        public List<Course> Courses;

        public List<AssignmentPerCourse> Assignments { get; set; }

        public StudentInfo()
        {

        }

        public StudentInfo(Student student, List<Course> courses, List<AssignmentPerCourse> assignments)
        {
            Student = student;
            Courses = new List < Course > (courses);
            Assignments = new List<AssignmentPerCourse>(assignments);

        }



        public void ShowAllStudentAssignments()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" Student  {Student.FirstName}  {Student.LastName}  Has to submit the following  Assignments :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
            Console.WriteLine("{0,-21}| {1,-30 } | {2,-20} | {3,-9}  | {4,-12} |", "Title", "Description", "Submission Date", "Oral Mark", "Total Mark");
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var course in Assignments)
            {
                foreach (var assign in course.Assignments)
                {
                    assign.OutputAssignment();
                }
            }
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
        }




    }
}
