using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeMgmt
{
    class GradeCalc
    {
        public char calcgrade(int marks)
        {
            if (marks >= 90)
            {
                return 'A';
            }
            else if (marks >= 75)
            {
                return 'B';
            }
            else if (marks >= 50)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }

        }
        public double average(List<Subject> subjects)
        {
            if (subjects == null)
            {
                return 0;
            }
            double sum = 0;
            foreach (var i in subjects)
            {
                sum += i.getmarks();
            }
            return sum / subjects.Count;
        }

       
    }
}
