using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School
{


    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }




        public Student()
        {

        }

        public Student(string firstName, string lastName, DateTime birth, int tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = birth;
            TuitionFees = tuitionFees;
        }




        #region //METHODOI OUTPUT////////////////
        public void Output()
        {
            OutputFirstName();
            OutputLastName();
            OutputDateOfBirth();
            OutputTuitionFees();

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

        public void OutputDateOfBirth()
        {
            Console.WriteLine($" Date of Birth: {DateOfBirth.ToString("dd/MM/yyyy")} ");
        }

        public void OutputTuitionFees()
        {
            Console.WriteLine($"Tuition Fees: {TuitionFees} euro");
        }
        #endregion

        public void OutputStudent()
        {
            Console.WriteLine($"{FirstName,-15 } | {LastName,-20} | {DateOfBirth.ToString("dd/MM/yyyy"),-20} | {TuitionFees,-15} | ");
        }


        #region //METHODOI Input PROPERTIES////////////////
        public void InputFirstName()
        {
            Console.WriteLine("Type Student First Name:  ");
            FirstName = Console.ReadLine();
        }

        public void InputLastName()
        {
            Console.WriteLine("Type Student Last Name:  ");
            LastName = Console.ReadLine();
        }


        public void InputTuitionFees()
        {
            Console.WriteLine("Type Tuition Fees:  ");
            TuitionFees = Convert.ToInt32(Console.ReadLine());
        }

        public void InputBirthDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type a valid date of birth e.g (14/5/2019)");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {


                    if (birthDate.Year>2001 || birthDate.Year > 1965)
                    {
                        DateOfBirth = birthDate;
                        valid = false;

                    }

                }
                else
                    Console.WriteLine("Invalid Date, Please Try Again  ");

            } while (valid);

        }


        public void Input()
        {
            InputFirstName();
            InputLastName();
            InputBirthDate();
            InputTuitionFees();
        }

        #endregion



    }

}
