using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Private_School
{
    public enum Stream { FullTime = 1, PartTime }
    public enum Type { Java = 1, CSharp }



    public class Course
    {
        public string Title { get; set; }
        public Stream Stream { get; set; }
        public Type Type { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }


       

      

        public Course()
        {

        }

        public Course(string title, Stream stream, Type type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            Start_Date = startDate;
            End_Date = endDate;
        }





        #region //METHODOI OUTPUT////////////////
        public void Output()
        {
            OutputTitle();
            OutputType();
            OutputStream();
            OutputStartDate();
            OutputEndDate();
        }

        public void OutputTitle()
        {
            Console.WriteLine($"{Title}");
        }

        public void OutputStream()
        {
            Console.WriteLine($"{Stream}");
        }

        public void OutputType()
        {
            Console.WriteLine($"{Type}");
        }

        public void OutputStartDate()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Start Date:  {Start_Date.ToString("dd/MM/yyyy")}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputEndDate()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"End Date:  {End_Date.ToString("dd/MM/yyyy"),-12} |");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        public void OutputCourse()
        {
            Console.WriteLine($"{Title,-5 } | {Type,-10} | {Stream,-10} | {Start_Date.ToString("dd/MM/yyyy"),-10} | {End_Date.ToString("dd/MM/yyyy"),-9} |");
        }



        #region //METHODOI INPUT PROPERTIES////////////////
        public void InputTitle()
        {
            Console.WriteLine("Type the Course Title:  ");
            Title = Console.ReadLine();        
        }

        public void InputStream()
        {
            bool valid = true;
            do
            {

                try
                {
                    Console.WriteLine("Type (a correct value) '1' for FullTime or '2' for PartTime  :");
                    int stream = Convert.ToInt32(Console.ReadLine());
                    if (Enum.IsDefined(typeof(Stream), stream))
                    {
                        Stream = (Stream)stream;
                        valid = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Value.");
                }
                finally { } 

            } while (valid);
         
        }

        public void InputType()
        {
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine("Type (a correct value) '1' for Java or '2' for C#  :");
                    int type = Convert.ToInt32(Console.ReadLine());
                    if (Enum.IsDefined(typeof(Type), type))
                    {
                        Type = (Type)type;
                        valid = false;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong Value.");
                }
                finally { }



            } while (valid);

        }

        public void InputStartDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type when the Course will start e.g (14/5/2019):");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
                {
                    if (startDate>= DateTime.Now)
                    {
                        Start_Date = startDate;
                        valid = false;
                    }
                }
                else
                    Console.WriteLine("Invalid Date, Please Try Again  ");

            } while (valid);

        }

        public void InputEndDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type when the Course will End e.g (14/5/2019)");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
                {
                   
                    
                    if (Start_Date< endDate)
                    {
                        End_Date = endDate;
                        valid = false;

                    }
                   
                }
                else
                    Console.WriteLine("Invalid Date, Please Try Again  ");

            } while (valid);

        }

        public void Input()
        {
            InputTitle();           
            InputType();
            InputStream();
            InputStartDate();
            InputEndDate();
        }
        #endregion

      






    }
}
