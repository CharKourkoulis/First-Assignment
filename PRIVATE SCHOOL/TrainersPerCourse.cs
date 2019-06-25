using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Private_School
{
    class TrainersPerCourse
    {
        public Course Course { get; set; }
        public List<Trainer> Trainers;


        public TrainersPerCourse()
        {

        }
        public TrainersPerCourse(Course course, List<Trainer> trainers)
        {
            Course = course;
            Trainers = new List<Trainer>(trainers);
        }


        public void ShowTrainers()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Course  {Course.Title}  Has {Trainers.Count}  Trainers:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------+----------------------+--------------------------------+-");
            Console.WriteLine("{0,-16}| {1,-20 } | {2,-30} |", "First Name", "Last Name", "Subject");
            Console.WriteLine("----------------+----------------------+--------------------------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Trainers)
            {
                item.OutputTrainer();
            }

            Console.WriteLine("----------------+----------------------+--------------------------------+-");
        }



    }
}
