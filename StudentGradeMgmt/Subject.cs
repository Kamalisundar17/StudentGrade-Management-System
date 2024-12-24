using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeMgmt
{
     class Subject
    {
        public string name { get; set; }
        public int marks { get; set; }
        public Subject(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
        }
        public string getname()
        {
            return this.name;
        }
        public int getmarks()
        {
            return this.marks;
        }
    }
}
