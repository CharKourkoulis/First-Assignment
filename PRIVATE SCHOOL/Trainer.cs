using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }




        public Trainer()
        {

        }
        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

      




        #region //METHODOI OUTPUT////////////////
        public void Output()
        {
            OutputFirstName();
            OutputLastName();
            OutputSubject();
        }


        public void OutputFirstName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{FirstName}  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputLastName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{LastName}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputSubject()
        {
            Console.WriteLine($"{Subject}");
        }
        #endregion

        public void OutputTrainer()
        {
            Console.WriteLine($"{FirstName,-15 } | {LastName,-20} | {Subject,-30} |");
        }


        #region //METHODOI Input PROPERTIES////////////////
        public void InputFirstName()
        {
            Console.WriteLine("Type Trainer's First Name:  ");
            FirstName = Console.ReadLine();            
        }

        public void InputLastName()
        {
            Console.WriteLine("Type Trainer's Last Name:  ");
            LastName = Console.ReadLine();
           
        }

        public void InputSubject()
        {
            Console.WriteLine("Type Teaching Subject:  ");
            Subject = Console.ReadLine();
        }


        public void Input()
        {
            InputFirstName();
            InputLastName();
            InputSubject();
        }


        #endregion
    }
}
