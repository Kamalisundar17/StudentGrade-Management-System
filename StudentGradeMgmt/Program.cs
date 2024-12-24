using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeMgmt
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            

            
            while (true) {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Subject and Marks");
               Console.WriteLine("3.Grades Details for Each Subject");
                Console.WriteLine("4.DisplayInfo");
                Console.WriteLine("5.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddSubject();
                        break;
                    case 3:
                        Calculate();
                        break;
                    case 4:
                        DisplayInfo();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }
            }

        }

        private static void DisplayInfo()
        {
            Console.WriteLine("Enter Student Roll No:");
            int r = Convert.ToInt32(Console.ReadLine());
            Student s = students.Find(sid => sid.rollno == r);
            if (s == null)
            {
                Console.WriteLine("No Students Found!");
            }
            else
            {
                Console.WriteLine("Student Details:");
                s.displayInfo();
            }

        }

        private static void Calculate()
        {
            Console.WriteLine("Enter Student Roll No:");
            int r = Convert.ToInt32(Console.ReadLine());
            Student s = students.Find(sid => sid.rollno == r);
            if (s == null)
            {
                Console.WriteLine("No Students Found!");
            }
            else
            {
                GradeCalc g=new GradeCalc();
                Console.WriteLine("Grades Details for Each Subject");
                Console.WriteLine($"Name: {s.name}");
                Console.WriteLine($"Roll No: {s.rollno}");
                foreach (var sub in s.Subjects)
                {
                    Console.WriteLine($"Subject Name: {sub.name}");
                    Console.WriteLine($"Grade :{g.calcgrade(sub.marks)}");

                }
            }
        }

        private static void AddSubject()
        {
            Console.WriteLine("Enter Student Roll No:");
            int r=Convert.ToInt32(Console.ReadLine());
            Student s=students.Find(sid=>sid.rollno==r);
            if (s == null) {
                Console.WriteLine("No Students Found!"); 
            }
            else
            {
                Console.WriteLine("Enter No of Subjects:");
                int sublen=Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sublen; i++)
                {
                    Console.WriteLine("Enter Subject Name:");
                    string sn = Console.ReadLine();
                    Console.WriteLine("Enter Marks:");
                    int m=Convert.ToInt32(Console.ReadLine());
                    Subject sub = new(sn, m);
                    s.Subjects.Add(sub);

                }
                
            }
        }

        public static void AddStudent()
        {
            Console.WriteLine("Enter Student Name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter Rollno");
            int rollno=int.Parse(Console.ReadLine());
            Student newstudent = new Student(name, rollno);
            students.Add(newstudent);
            
        }
    }
}
