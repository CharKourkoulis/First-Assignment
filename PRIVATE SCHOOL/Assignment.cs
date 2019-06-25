using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School
{

    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }





        public Assignment()
        {

        }

        public Assignment(string title, string description, DateTime subDate, int oralmark, int totalmark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDate;
            OralMark = oralmark;
            TotalMark = totalmark;
        }
       


        #region //METHODOI OUTPUT////////////////
        public void Output()
        {
            OutputTitle();
            OutputDescription();
            OutputSubDate();
            OutputOralMark();
            OutputTotalMark();
            Console.WriteLine();
        }

        public void OutputTitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Title,-20} ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputDescription()
        {
            Console.WriteLine($"{Description} ");
        }

        public void OutputSubDate()
        {
            Console.WriteLine($"Submission Date: {SubDateTime.ToString("dd/MM/yyyy")} ");
        }

        public void OutputOralMark()
        {
            Console.WriteLine($"Oral Mark: {OralMark}");
        }

        public void OutputTotalMark()
        {
            Console.WriteLine($"Total Mark: {TotalMark} ");
        }
        #endregion

        public void OutputAssignment()
        {
            Console.WriteLine($"{Title,-20} | {Description,-30} | {SubDateTime.ToString("dd/MM/yyyy"),-20} | {OralMark,-10} | {TotalMark,-12} |");
        }

        #region //METHODOI Input PROPERTIES////////////////

        public void InputTitle()
        {
            Console.WriteLine("Type the Assignment Title:  ");
            Title = Console.ReadLine();
        }

        public void InputDescription()
        {
            Console.WriteLine("Type the Assignment Description:  ");
            Description = Console.ReadLine();
        }

        public void InputSubDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type when the Assignment will have to be submitted e.g (14/5/2019):  ");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime subDate))
                {
                    if (subDate >= DateTime.Now)
                    {
                        SubDateTime = subDate;
                        valid = false;
                    }
                }
                else
                    Console.WriteLine("Invalid Date, Please Try Again  ");

            } while (valid);

        }

        public void InputOralMark()
        {
            Console.WriteLine("Type the Oral Mark:  ");
            OralMark = Convert.ToInt32(Console.ReadLine());
        }

        public void InputTotalMark()
        {
            Console.WriteLine("Type the Total Mark:  ");
            TotalMark = Convert.ToInt32(Console.ReadLine());
        }

        public void Input()
        {
            InputTitle();
            InputDescription();
            InputSubDate();
            InputOralMark();
            InputTotalMark();

        }

     #endregion




    }

}
