using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Private_School
{
    class StudentsPerAssignment
    {

        public Assignment Assignment{ get; set; }

        public List<Student> Students;


        public StudentsPerAssignment(Assignment assignment , List<Student> students)
        {
            Assignment = assignment;

            Students = new List<Student> (students);


        }
        public void ShowStudents()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {Assignment.Title} needs to be submitted from  {Students.Count}  Students :");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
