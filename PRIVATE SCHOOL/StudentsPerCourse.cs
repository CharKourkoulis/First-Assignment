using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Private_School
{
    class StudentsPerCourse
    {

        public Course Course { get; set; }
        public List<Student> Students;

        public StudentsPerCourse()
        {

        }
        public StudentsPerCourse(Course course, List<Student> students)
        {
            Course = course;
            Students = new List<Student>(students);
        }


        public void ShowStudents()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Course  {Course.Title}  Has {Students.Count}  students:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------+----------------------+----------------------+-----------------+-");
            Console.WriteLine("{0,-16}| {1,-20 } | {2,-20} | {3,-15} |", "First Name", "Last Name", "Date of Birth", "Tuition Fees");
            Console.WriteLine("----------------+----------------------+----------------------+-----------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Students)
            {
                item.OutputStudent();
            }
            Console.WriteLine("----------------+----------------------+----------------------+-----------------+-");
        }

    }
}
