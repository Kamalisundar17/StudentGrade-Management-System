using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeMgmt
{
    class Student
    {
       public string name { get; set; }
       public  int rollno { get; set; }

       public List<Subject> Subjects { get; set; }
       public Student(string name, int rollno)
        {
            this.name = name;
            this.rollno = rollno;
            Subjects = new List<Subject>();
        }
        public void addSubjects(Subject su)
        {
            Subjects.Add(su);
        }
        public void displayInfo()
        {
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Roll No:{0}", rollno);
            Console.WriteLine("Subject --- Mark --- Grade");
            GradeCalc gradeCalc = new GradeCalc();
            foreach (Subject su in Subjects)
            {
                Console.WriteLine($"{su.getname()} --- {su.getmarks()} --- {gradeCalc.calcgrade(su.getmarks())}");
            }
            
            double avg = gradeCalc.average(Subjects);
            Console.WriteLine($"Average Marks:{Math.Ceiling(avg)}");
            int a = Convert.ToInt32(avg);
            Console.WriteLine($"Overall Grade:{gradeCalc.calcgrade(a)}");

        }
    }
}
