using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;


namespace Private_School
{
    class Program
    {

        static void Main(string[] args)
        {
            /////////////////////////LISTES //////////////////////////////////////////
            #region //--------- DATABASE AREA. LISTS OF ALL ITEMS -----------------//
            List<Course> AllCoursesList = new List<Course>();
            List<Trainer> AllTrainersList = new List<Trainer>();
            List<Student> AllStudentsList = new List<Student>();
            List<Assignment> AllAssignmentsList = new List<Assignment>();


            List<AssignmentPerCourse> courseAssignmentsList = new List<AssignmentPerCourse>();
            List<StudentsPerCourse> courseStudentsList = new List<StudentsPerCourse>();
            List<TrainersPerCourse> courseTrainersList = new List<TrainersPerCourse>();
            List<StudentsPerAssignment> studentsPerAssignmentsList = new List<StudentsPerAssignment>();
            List<StudentInfo> studentsInfoList = new List<StudentInfo>();
           
            ///////////////////////////////////////////////////////////////////////////
            #endregion



            /////////////////////////<MAIN PROGRAM>///////////////////////////////////
            bool valid = true;
            int number;
            UserInputOrRandom(valid, out number);

            switch (number)
            {
             //////////////////////<USER INPUT CASE>/////////////////////////////////
                case 1:
                    MultipleCourseInput(AllCoursesList);
                    int counter1 = 0;
                    foreach (var course in AllCoursesList)
                    {
                        List<Assignment> assignments = new List<Assignment>();
                        MultipleAssignmentInput(AllAssignmentsList, assignments);
                        AssignmentPerCourse courseAssignments = new AssignmentPerCourse(course, assignments);                        
                        courseAssignmentsList.Add(courseAssignments);
                                      
                        List<Trainer> trainers = new List<Trainer>();
                        MultipleTrainerInput(AllTrainersList, trainers);
                        TrainersPerCourse courseTrainers = new TrainersPerCourse(course, trainers);                       
                        courseTrainersList.Add(courseTrainers);
                                  
                        List<Student> students = new List<Student>();
                        MultipleStudentInput(AllStudentsList, students);
                        StudentsPerCourse courseStudents = new StudentsPerCourse(course, students);                       
                        courseStudentsList.Add(courseStudents);

                        foreach (var student in students)
                        {
                         List<Course> studentCourses = new List<Course>();
                         studentCourses.Add(course);                        
                         List<AssignmentPerCourse> studentAssignments = new List<AssignmentPerCourse>();
                         studentAssignments.Add(courseAssignments);
                         StudentInfo studentInfo = new StudentInfo(student, studentCourses, studentAssignments);
                         studentsInfoList.Add(studentInfo);
                        }
                        
                        foreach (var assignment in assignments)
                        {
                            StudentsPerAssignment studentsPerAssignment = new StudentsPerAssignment(assignment, students);
                            studentsPerAssignmentsList.Add(studentsPerAssignment);
                        }

                        counter1++;
                        if (counter1 < AllCoursesList.Count)
                        {
                            NextCourseMessage(AllCoursesList);
                        }
                        
                    }         
                    

                    break;
                ////////////////////////////////<SYNTHETIC CASE>/////////////////////////////
                #region // SYNTHETIC DATA
                case 2:
                    Course course1 = new Course("CB8 A", Stream.FullTime, Type.Java, new DateTime(2019, 06, 20), new DateTime(2019, 09, 20));
                    Course course2 = new Course("CB8 B", Stream.PartTime, Type.Java, new DateTime(2019, 06, 20), new DateTime(2019, 12, 20));
                    Course course3 = new Course("CB9 C", Stream.FullTime, Type.CSharp, new DateTime(2019, 06, 20), new DateTime(2019, 09, 20));
                    Course course4 = new Course("CB9 D", Stream.PartTime, Type.CSharp, new DateTime(2019, 06, 20), new DateTime(2019, 12, 20));

                    AllCoursesList.Add(course1);
                    AllCoursesList.Add(course2);
                    AllCoursesList.Add(course3);
                    AllCoursesList.Add(course4);

                    Assignment assignment1 = new Assignment("First Project", "first assignment classes", new DateTime(2019, 07, 22), 30,60);
                    Assignment assignment2 = new Assignment("Second Project", "sql assignment", new DateTime(2019, 08, 12), 60, 62);
                    Assignment assignment3 = new Assignment("Third Project", "javascript assignment", new DateTime(2019, 08, 16), 34, 23);
                    Assignment assignment4 = new Assignment("Fourth Project", "frontEnd assignment", new DateTime(2019, 09, 11), 40, 43);
                    Assignment assignment5 = new Assignment("Fifth Project", "MVC assignment", new DateTime(2019, 09, 23), 20, 45);
                    Assignment assignment6 = new Assignment("Sixth Project", "Team assignment", new DateTime(2019, 08, 12), 10, 56);
                    Assignment assignment7 = new Assignment("Seventh Project", "backend assignment", new DateTime(2019, 08, 15), 10, 56);
                    Assignment assignment8 = new Assignment("Eight Project", "Rough assignment", new DateTime(2019, 07, 25), 10, 56);


                    AllAssignmentsList.Add(assignment1);
                    AllAssignmentsList.Add(assignment2);
                    AllAssignmentsList.Add(assignment3);
                    AllAssignmentsList.Add(assignment4);
                    AllAssignmentsList.Add(assignment5);
                    AllAssignmentsList.Add(assignment6);
                    AllAssignmentsList.Add(assignment7);
                    AllAssignmentsList.Add(assignment8);

                    List<Assignment> assignments1 = new List<Assignment>();
                    List<Assignment> assignments2 = new List<Assignment>();
                    List<Assignment> assignments3 = new List<Assignment>();
                    List<Assignment> assignments4 = new List<Assignment>();

                    assignments1.Add(assignment1);
                    assignments1.Add(assignment2);
                    assignments2.Add(assignment3);
                    assignments2.Add(assignment4);
                    assignments3.Add(assignment5);
                    assignments3.Add(assignment6);
                    assignments4.Add(assignment7);
                    assignments4.Add(assignment8);

                    AssignmentPerCourse course1Assignments = new AssignmentPerCourse(course1, assignments1);
                    AssignmentPerCourse course2Assignments = new AssignmentPerCourse(course2, assignments2);
                    AssignmentPerCourse course3Assignments = new AssignmentPerCourse(course3, assignments3);
                    AssignmentPerCourse course4Assignments = new AssignmentPerCourse(course4, assignments4);

                    courseAssignmentsList.Add(course1Assignments);
                    courseAssignmentsList.Add(course2Assignments);
                    courseAssignmentsList.Add(course3Assignments);
                    courseAssignmentsList.Add(course4Assignments);

                    Trainer trainer1 = new Trainer("Ektoras", "Gkatsos", "Csharp Lesson");
                    Trainer trainer2 = new Trainer("George", "Pasparakis", "Java Lesson");
                    Trainer trainer3 = new Trainer("Argiris", "Pagidas", "Sql Lesson");
                    Trainer trainer4 = new Trainer("Giannis", "Raftopoulos", "Python Lesson");
                    Trainer trainer5 = new Trainer("Dionysios", "Solwmos", "frontEnd Lesson");
                    Trainer trainer6 = new Trainer("Gewrgios", "Seferis", "BackEnd Lesson");
                    Trainer trainer7 = new Trainer("Kwstas", "Karywtakis", "Javascript Lesson");
                    Trainer trainer8 = new Trainer("Nikolaos", "Politis", "GIT Lesson");

                    AllTrainersList.Add(trainer1);
                    AllTrainersList.Add(trainer2);
                    AllTrainersList.Add(trainer3);
                    AllTrainersList.Add(trainer4);
                    AllTrainersList.Add(trainer5);
                    AllTrainersList.Add(trainer6);
                    AllTrainersList.Add(trainer7);
                    AllTrainersList.Add(trainer8);

                    List<Trainer> trainers1 = new List<Trainer>();
                    List<Trainer> trainers2 = new List<Trainer>();
                    List<Trainer> trainers3 = new List<Trainer>();
                    List<Trainer> trainers4 = new List<Trainer>();

                    trainers1.Add(trainer1);
                    trainers1.Add(trainer2);
                    trainers2.Add(trainer3);
                    trainers2.Add(trainer4);
                    trainers3.Add(trainer5);
                    trainers3.Add(trainer6);
                    trainers4.Add(trainer7);
                    trainers4.Add(trainer8);

                    TrainersPerCourse course1Trainers = new TrainersPerCourse(course1, trainers1);
                    TrainersPerCourse course2Trainers = new TrainersPerCourse(course2, trainers2);
                    TrainersPerCourse course3Trainers = new TrainersPerCourse(course3, trainers3);
                    TrainersPerCourse course4Trainers = new TrainersPerCourse(course4, trainers4);

                    courseTrainersList.Add(course1Trainers);
                    courseTrainersList.Add(course2Trainers);
                    courseTrainersList.Add(course3Trainers);
                    courseTrainersList.Add(course4Trainers);

                    Student student1 = new Student("Babis", "Kourkoulis", new DateTime(1987, 02, 16), 2500);
                    Student student2 = new Student("Kostas", "Ioannou", new DateTime(1988, 07, 23), 2500);
                    Student student3 = new Student("Mixalis", "Rigas", new DateTime(1989, 08, 21), 2500);
                    Student student4 = new Student("Xristos", "Tsavalas", new DateTime(1992, 03, 18), 2500);
                    Student student5 = new Student("Alexandros", "Perivolakis", new DateTime(1993, 05, 16), 2500);
                    Student student6 = new Student("Xristos", "Tsavalas", new DateTime(1992, 12, 19), 2500);
                    Student student7 = new Student("Stelios", "Euaggelidis", new DateTime(1993, 02, 04), 2500);
                    Student student8 = new Student("Stathis", "Psaltis", new DateTime(1984, 08, 07), 2500);
                    Student student9 = new Student("Sotiris", "Euaggelou", new DateTime(1981, 09, 22), 2500);
                    Student student10 = new Student("Xrysa", "Perri", new DateTime(1992, 11, 17), 2500);

                    AllStudentsList.Add(student1);
                    AllStudentsList.Add(student2);
                    AllStudentsList.Add(student3);
                    AllStudentsList.Add(student4);
                    AllStudentsList.Add(student5);
                    AllStudentsList.Add(student6);
                    AllStudentsList.Add(student7);
                    AllStudentsList.Add(student8);
                    AllStudentsList.Add(student9);
                    AllStudentsList.Add(student10);

                    List<Student> students1 = new List<Student>();
                    List<Student> students2 = new List<Student>();
                    List<Student> students3 = new List<Student>();
                    List<Student> students4 = new List<Student>();

                    students1.Add(student1);
                    students1.Add(student2);
                    students1.Add(student3);
                    students2.Add(student4);
                    students2.Add(student5);
                    students3.Add(student5);
                    students3.Add(student6);
                    students3.Add(student7);
                    students3.Add(student8);
                    students4.Add(student9);
                    students4.Add(student10);
                    students4.Add(student1);

                    StudentsPerCourse course1Students = new StudentsPerCourse(course1, students1);
                    StudentsPerCourse course2Students = new StudentsPerCourse(course2, students2);
                    StudentsPerCourse course3Students = new StudentsPerCourse(course3, students3);
                    StudentsPerCourse course4Students = new StudentsPerCourse(course4, students4);

                    courseStudentsList.Add(course1Students);
                    courseStudentsList.Add(course2Students);
                    courseStudentsList.Add(course3Students);
                    courseStudentsList.Add(course4Students);


                    List<Course> student1Courses = new List<Course>();
                    student1Courses.Add(course1);
                    student1Courses.Add(course4);
                    List<Course> student2Courses = new List<Course>();
                    student2Courses.Add(course1);
                    List<Course> student3Courses = new List<Course>();
                    student3Courses.Add(course1);
                    List<Course> student4Courses = new List<Course>();
                    student4Courses.Add(course2);
                    List<Course> student5Courses = new List<Course>();
                    student5Courses.Add(course2);
                    student5Courses.Add(course3);
                    List<Course> student6Courses = new List<Course>();
                    student6Courses.Add(course3);
                    List<Course> student7Courses = new List<Course>();
                    student7Courses.Add(course3);
                    List<Course> student8Courses = new List<Course>();
                    student8Courses.Add(course3);
                    List<Course> student9Courses = new List<Course>();
                    student9Courses.Add(course4);
                    List<Course> student10Courses = new List<Course>();
                    student10Courses.Add(course4);


                    List<AssignmentPerCourse> student1Assignments = new List<AssignmentPerCourse>();
                    student1Assignments.Add(course1Assignments);
                    student1Assignments.Add(course4Assignments);
                    List<AssignmentPerCourse> student2Assignments = new List<AssignmentPerCourse>();
                    student2Assignments.Add(course1Assignments);
                    List<AssignmentPerCourse> student3Assignments = new List<AssignmentPerCourse>();
                    student3Assignments.Add(course1Assignments);
                    List<AssignmentPerCourse> student4Assignments = new List<AssignmentPerCourse>();
                    student4Assignments.Add(course2Assignments);
                    List<AssignmentPerCourse> student5Assignments = new List<AssignmentPerCourse>();
                    student5Assignments.Add(course2Assignments);
                    student5Assignments.Add(course3Assignments);
                    List<AssignmentPerCourse> student6Assignments = new List<AssignmentPerCourse>();
                    student6Assignments.Add(course3Assignments);
                    List<AssignmentPerCourse> student7Assignments = new List<AssignmentPerCourse>();
                    student7Assignments.Add(course3Assignments);
                    List<AssignmentPerCourse> student8Assignments = new List<AssignmentPerCourse>();
                    student8Assignments.Add(course3Assignments);
                    List<AssignmentPerCourse> student9Assignments = new List<AssignmentPerCourse>();
                    student9Assignments.Add(course4Assignments);
                    List<AssignmentPerCourse> student10Assignments = new List<AssignmentPerCourse>();
                    student10Assignments.Add(course4Assignments);


                    StudentInfo student1Info = new StudentInfo(student1, student1Courses, student1Assignments);
                    StudentInfo student2Info = new StudentInfo(student2, student2Courses, student2Assignments);
                    StudentInfo student3Info = new StudentInfo(student3, student3Courses, student3Assignments);
                    StudentInfo student4Info = new StudentInfo(student4, student4Courses, student4Assignments);
                    StudentInfo student5Info = new StudentInfo(student5, student5Courses, student5Assignments);
                    StudentInfo student6Info = new StudentInfo(student6, student6Courses, student6Assignments);
                    StudentInfo student7Info = new StudentInfo(student7, student7Courses, student7Assignments);
                    StudentInfo student8Info = new StudentInfo(student8, student8Courses, student8Assignments);
                    StudentInfo student9Info = new StudentInfo(student9, student9Courses, student9Assignments);
                    StudentInfo student10Info = new StudentInfo(student10, student10Courses, student10Assignments);


                    studentsInfoList.Add(student1Info);
                    studentsInfoList.Add(student2Info);
                    studentsInfoList.Add(student3Info);
                    studentsInfoList.Add(student4Info);
                    studentsInfoList.Add(student5Info);
                    studentsInfoList.Add(student6Info);
                    studentsInfoList.Add(student7Info);
                    studentsInfoList.Add(student8Info);
                    studentsInfoList.Add(student9Info);
                    studentsInfoList.Add(student10Info);

                    StudentsPerAssignment studentsPerAssignment1 = new StudentsPerAssignment(assignment1, students1);
                    StudentsPerAssignment studentsPerAssignment2 = new StudentsPerAssignment(assignment2, students1);
                    StudentsPerAssignment studentsPerAssignment3 = new StudentsPerAssignment(assignment3, students2);
                    StudentsPerAssignment studentsPerAssignment4 = new StudentsPerAssignment(assignment4, students2);
                    StudentsPerAssignment studentsPerAssignment5 = new StudentsPerAssignment(assignment5, students3);
                    StudentsPerAssignment studentsPerAssignment6 = new StudentsPerAssignment(assignment6, students3);
                    StudentsPerAssignment studentsPerAssignment7 = new StudentsPerAssignment(assignment7, students4);
                    StudentsPerAssignment studentsPerAssignment8 = new StudentsPerAssignment(assignment8, students4);

                    studentsPerAssignmentsList.Add(studentsPerAssignment1);
                    studentsPerAssignmentsList.Add(studentsPerAssignment2);
                    studentsPerAssignmentsList.Add(studentsPerAssignment3);
                    studentsPerAssignmentsList.Add(studentsPerAssignment4);
                    studentsPerAssignmentsList.Add(studentsPerAssignment5);
                    studentsPerAssignmentsList.Add(studentsPerAssignment6);
                    studentsPerAssignmentsList.Add(studentsPerAssignment7);
                    studentsPerAssignmentsList.Add(studentsPerAssignment8);



                    break;


                default:
                    break;
            }

            #endregion

            ////////////////////<PRINTING METHODS AREA>///////////////////////////////////////////////
            //////// COMMENT - UNCOMMENT WHAT ITEM PER CATEGORY YOU WANT TO BE PRINTED////////////////


            ShowAllCourses(AllCoursesList);
            ShowAllAssignments(AllAssignmentsList);
            ShowAllTrainers(AllTrainersList);
            ShowAllStudents(AllStudentsList);

            ShowStudentsPerCourse(courseStudentsList);
            ShowTrainersPerCourse(courseTrainersList);
            ShowAssignmentsPerCourse(courseAssignmentsList);            
            ShowAssignmentsPerStudent(studentsInfoList);
            ShowStudentsPerAssignment(studentsPerAssignmentsList);

            StudentsWithMoreCourses(studentsInfoList);
            WeeklySubmissions(studentsPerAssignmentsList);


        }







        ////////////////////////////////////////////////////////////////
        /// METHODOI POU TYPWNOUN OLA TA ITEMS ANA EIDOS
        /// ///////////////////////////////////////////

        #region *Synartisi pou typwnei ola ta Courses
        public static void ShowAllCourses(List<Course> AllCoursesList)
        {
           
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("List of All Courses                                              ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------+------------+------------+------------+------------+-");
                Console.WriteLine("{0,-6}| {1,-10 } | {2,-10} | {3,9}  | {4,-9} |", "Title", "Type", "Stream", "Start Date", "End Date");
                Console.WriteLine("------+------------+------------+------------+------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in AllCoursesList)
                {
                    item.OutputCourse();
                }

                Console.WriteLine("------+------------+------------+------------+------------+-");
            
        }
        #endregion

        #region *Synartisi pou typwnei olous tous Trainers
        public static void ShowAllTrainers(List<Trainer> AllTrainersList)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("List of All Trainers                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------+----------------------+--------------------------------+-");
            Console.WriteLine("{0,-16}| {1,-20 } | {2,-30} |", "First Name", "Last Name", "Subject");
            Console.WriteLine("----------------+----------------------+--------------------------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in AllTrainersList)
            {
                item.OutputTrainer();
            }

            Console.WriteLine("----------------+----------------------+--------------------------------+-");


        }
        #endregion

        #region *Synartisi pou typwnei olous tous Students
        public static void ShowAllStudents(List<Student> AllStudentsList)
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("List of All Students");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------+----------------------+----------------------+-----------------+-");
            Console.WriteLine("{0,-16}| {1,-20 } | {2,-20} | {3,-15} |", "First Name", "Last Name", "Date of Birth", "Tuition Fees");
            Console.WriteLine("----------------+----------------------+----------------------+-----------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in AllStudentsList)
            {
                item.OutputStudent();
            }

            Console.WriteLine("----------------+----------------------+----------------------+-----------------+-");

        }
        #endregion

        #region *Synartisi pou typwnei ola ta Assignments
        public static void ShowAllAssignments(List<Assignment> AllAssignmentsList)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("List of All Assignments                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
            Console.WriteLine("{0,-21}| {1,-30 } | {2,-20} | {3,-9}  | {4,-12} |", "Title", "Description", "Submission Date", "Oral Mark", "Total Mark");
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in AllAssignmentsList)
            {
                item.OutputAssignment();
            }

            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-");

        }
        #endregion

        ///////////////////////////////////////////////////////////////////
               

        #region// SYNARTHSEIS POU TYPWNOUN ANA EIDOS KAI ANA KATHGORIA
        public static void ShowStudentsPerCourse(List<StudentsPerCourse> courseStudentsList)
        {
            foreach (var item in courseStudentsList)
            {
                item.ShowStudents();               
            }

        }

        public static void ShowTrainersPerCourse(List<TrainersPerCourse> courseTrainersList)
        {
            foreach (var item in courseTrainersList)
            {
                item.ShowTrainers();
            }
        }

        public static void ShowAssignmentsPerCourse(List<AssignmentPerCourse> courseAssignmentsList)
        {
            foreach (var item in courseAssignmentsList)
            {
                item.ShowAssignments();
            }
        }

        public static void ShowStudentsPerAssignment(List<StudentsPerAssignment> studentsPerAssignmentsList)
        {
            foreach (var item in studentsPerAssignmentsList)
            {
                item.ShowStudents();
            }
        }

        public static void ShowAssignmentsPerStudent(List<StudentInfo> studentsInfoList)
        {
            foreach (var student in studentsInfoList)
            {
                student.ShowAllStudentAssignments();
               
            }
        }
        #endregion

        
        /////////////////////////////////////////////////////////////////    
        /// MULTIPLE INPUT METHODS /////////////////////////////////////


        #region/////////// MULTIPLE INPUT METHODS   /////////////////////
        public static void MultipleCourseInput(List<Course> allcourseslist)
            
        {

            bool valid = true;
            do
            {
                
                Course course = new Course();
                course.Input();
                allcourseslist.Add(course);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("COURSE HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another course?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Course");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();
                
                

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);

        }

        public static void MultipleAssignmentInput(List<Assignment> allAssignmentsList,List<Assignment> courseassignments)
        {

            bool valid = true;
            do
            {
                Assignment assignment = new Assignment();
                assignment.Input();
                allAssignmentsList.Add(assignment);              
                courseassignments.Add(assignment);
               
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("ASSIGNMENT HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another assignment?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Assignment");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();
                

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);

        }

        public static void MultipleTrainerInput(List<Trainer> allTrainersList, List<Trainer> coursetrainers)
        {

            bool valid = true;
            do
            {
                Trainer trainer = new Trainer();
                trainer.Input();
                allTrainersList.Add(trainer);       
                coursetrainers.Add(trainer);


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TRAINER HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another Trainer?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Trainer");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();
                

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);

        }

        public static void MultipleStudentInput(List<Student> allStudentsList, List<Student> coursestudents)
        {

            bool valid = true;
            do
            {
                Student student = new Student();
                student.Input();
                allStudentsList.Add(student);
                coursestudents.Add(student);


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("STUDENT HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another Student?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Student");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();
                

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);

        }
        #endregion



        ////////// RANDOM INPUT METHODOI //////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        #region// RANDOM METHODOI
        public static void RandomInputCourse(List<Course> AllCoursesList)
        {
            List<string> randomNames = new List<string>() { "CB8", "CB7", "EB6", "EB4", "CB7", "CB3", "EB9" };
            List<string> randomStream = new List<string>() { "Java", "CSharp" };
            List<string> randomType = new List<string>() { "FullTime", "PartTime" };
            Random rand = new Random();
            Random random = new Random();

            DateTime RandomDay()
            {
                DateTime start = new DateTime(2019, 6, 6);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(random.Next(range));
            }

            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine("INPUT A CORRECT NUMBER OF RANDOM COURSES: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < number; i++)
                    {


                        int index1 = rand.Next(1, randomNames.Count);
                        string title = randomNames[index1];

                        int index2 = random.Next(1, randomStream.Count + 1);
                        Stream stream = (Stream)index2;

                        int index3 = rand.Next(1, randomType.Count + 1);
                        Type type = (Type)index3;

                        DateTime startDate = RandomDay();

                        DateTime endDate;
                        if (stream == Stream.FullTime)
                        {
                            endDate = startDate.AddMonths(6);
                        }
                        else
                        {
                            endDate = startDate.AddMonths(3);
                        }

                        Course course = new Course(title, stream, type, startDate, endDate);
                        AllCoursesList.Add(course);
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

        public static void RandomInputTrainer(List<Trainer> allTrainersList, List<Trainer> coursetrainers)
        {
            List<string> randomNames = new List<string>() { "Ektoras", "Argiris", "Kostas", "Vasilis", "Nikos", "Giannis", "Thanasis" };
            List<string> randomLastnames = new List<string>() { "Gkatsos", "Pagidas", "Papadopoulos", "Papathanasiou", "Pasparakis", "Adamopoulos", "Nikolopoulos" };
            List<string> randomSubject = new List<string>() { "Java Lesson", "CSharp Lesson", "SQL Lesson", "Javascript Lesson", "MVC Lesson", "Front-End Lesson" };
            Random rand2 = new Random();
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine("INPUT NUMBER OF RANDOM TRAINERS: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < number; i++)
                    {               
                        int index1 = rand2.Next(0, randomNames.Count);
                        string firstName = randomNames[index1];

                        int index2 = rand2.Next(0, randomLastnames.Count);
                        string lastName = randomLastnames[index2];

                        int index3 = rand2.Next(0, randomSubject.Count);
                        string subject = randomSubject[index3];

                        Trainer trainer = new Trainer(firstName, lastName,subject);
                        allTrainersList.Add(trainer);
                        coursetrainers.Add(trainer);
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

        public static void RandomInputStudent(List<Student> allStudentsList, List<Student> coursestudents)
        {
            List<string> randomNames = new List<string>() { "Giannis", "Mpampis", "Stelios", "Marios", "Iosif", "Mairi", "Giorgos" };
            List<string> randomLastnames = new List<string>() { "Kourkoulis", "Kagkas", "Artemakis", "Vagenas", "Karampelas", "Patiniotis", "Avramidis" };

            Random rand3 = new Random();
            DateTime RandomDay()
            {
                DateTime start = new DateTime(1995, 1, 6);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(rand3.Next(range));
            }
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine("INPUT NUMBER OF RANDOM STUDENTS: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < number; i++)
                    {

                        int index1 = rand3.Next(0, randomNames.Count);
                        string firstName = randomNames[index1];
                        int index2 = rand3.Next(0, randomLastnames.Count);
                        string lastName = randomLastnames[index2];
                        int tuitionFees = rand3.Next(1000, 2501);
                        DateTime dateOfBirth = RandomDay();

                        Student student = new Student(firstName, lastName, dateOfBirth, tuitionFees);
                        allStudentsList.Add(student);
                        coursestudents.Add(student);
                        valid = false;
                    }

                }
                catch (Exception)
                {
                 Console.WriteLine("Wrong Value.");
                }
                finally { }

            }while (valid);

        }

        public static void RandomInputAssignment(List<Assignment> allAssignmentsList, List<Assignment> courseassignments)
        {
           
            List<string> randomDescription = new List<string>() { "First Assignment csharp", "Individual Assignment java", "Personal Assignment csharp", "CSharp", "Second Individual Assignment", "Team Assignment", "sql Assignment", "Javascript Assignment" };
            Random rand = new Random();
          
            DateTime RandomDay()
            {
                DateTime start2 = new DateTime(2019, 1, 6);
                int range = (DateTime.Today - start2).Days;
                return start2.AddDays(rand.Next(range));
            }

            bool valid = true;
            do
            {
                try
                {

                    Console.WriteLine("INPUT NUMBER OF RANDOM ASSIGNMENTS: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < number; i++)
                    {             
                        int index1 = rand.Next(1, 7);
                        string title = "Assignment no " + $"{index1}";
                        int index2 = rand.Next(1, randomDescription.Count);
                        string description = randomDescription[index2];
                        int oralMark = rand.Next(40, 101);
                        int totalMark = rand.Next(40, 101);
                        DateTime subDateTime = RandomDay();

                        Assignment assignment = new Assignment(title,description,subDateTime,oralMark,totalMark);
                        allAssignmentsList.Add(assignment);
                        courseassignments.Add(assignment);
                        valid = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Value.");
                }
                finally { }

            }while (valid);

        }
        #endregion



        #region /////////<MISCELLANEOUS  METHODS>///////////////////////////////////////////////
        public static void UserInputOrRandom(bool valid, out  int number)
        {

            number = 0;
            do
            {
                try
                {                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("************************************************************");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hello, PRESS '1' FOR USER INPUT or '2' FOR SYNTHETIC DATA");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("************************************************************");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    if (number == 1 || number == 2)
                        valid = false;
                    else
                        Console.WriteLine("Wrong Answer!");
                }
                catch (Exception)
                { 
                    Console.WriteLine("Wrong Answer!");
                }
                finally
                {

                }

            } while (valid);



        }
       
        public static void NextCourseMessage(List<Course> courses)
        {
            if (courses.Count > 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NOW INSERT INFO FOR THE NEXT COURSE.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

   
        public static void StudentsWithMoreCourses(List<StudentInfo> studentsInfoList)
        {
            int counter = 0;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Students enlisted in more than one Courses: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************************");
            Thread.Sleep(300);
            foreach (var student in studentsInfoList)
            {
                if (student.Courses.Count>1)
                {                                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{student.Student.FirstName}  {student.Student.LastName}");
                    counter++;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (counter==0)
            {
                Console.WriteLine("There aren't any Students Enlisted in more than one Courses.");
                Console.WriteLine();
            }

        }


        public static void WeeklySubmissions(List<StudentsPerAssignment> studentsPerAssignmentsList)
        {
            int count = 0;
            bool valid = true;
            do
            {
                     Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Type Date to check weekly Submissions  e.g (12/8/2019) or (16/8/2019): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime Hmera))
                    {
                        var monday = Hmera.AddDays(-(int)Hmera.DayOfWeek + (int)DayOfWeek.Monday);
                        var friday = monday.AddDays(4);

                        for (var i = monday; i <= friday; i = i.AddDays(1))
                        {
                            foreach (var item in studentsPerAssignmentsList)
                            {
                                if (item.Assignment.SubDateTime == i)
                                {
                                    count++;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"These submissions should be completed in this week( {monday.ToString("dd/MM/yyyy")} - {friday.ToString("dd/MM/yyyy")} ): ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("***************************************************");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine();
                                    Console.Write($"Assignment: {item.Assignment.Title} ");
                                    Console.WriteLine($" | Description: {item.Assignment.Description} ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Has to be submitted from the following Students:");
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    foreach (var student in item.Students)
                                    {
                                        Console.WriteLine($"{student.FirstName}  {student.LastName}");
                                    }

                                }
                            }

                        }
                       
                    }
                    else
                        Console.WriteLine("Invalid Date");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Do you want to check another Date?  Press 'NO' or 'no' to exit.");              
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();
                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);

            
        }

        #endregion



    }


}
