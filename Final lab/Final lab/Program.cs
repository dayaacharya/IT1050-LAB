using System;


namespace Final_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            while (!done)
            {
                Course course = new Course();

                Console.WriteLine("Tell me course name");
                course.coursename = Console.ReadLine();
                Console.WriteLine("Whats the number of courese");
                course.courseid = Question.AskForInteger("Whats the Id");

             
                    Course.student = new student[new student];

                    for(int i = 0; i<course.student.Length;i++)
            
             {
                    Course.Student[i] = new student();
              }
                    foreach (Student student in Course.student)
              {
                    Question.AskForString("Whats the student name");
                    Question.AskForInteger("Whats student id");
            }

                 Console.WriteLine("is everything correct?");
                done = Console.ReadLine().StartsWith("Y");
                Console.WriteLine("Enter any key to continue");
                Console.ReadLine();


            }
        }
    }
}