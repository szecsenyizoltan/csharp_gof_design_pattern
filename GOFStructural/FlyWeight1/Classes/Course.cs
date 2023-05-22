using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight1.Classes
{
    internal class Course
    {
        List<Student> students;

        //private int allmark;
        //private int allmissedlectures;

        public double AvgMark 
        {
            get
            {
                return Math.Round(students.Average(t => t.Mark),2);
            }
        }

        public double AvgMissedLectures
        {
            get
            {
                return Math.Round(students.Average(t => t.MissedLectures),2);
            }
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return students;
            }
        }

        public Course()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            //allmark += student.Mark;
            //allmissedlectures += student.MissedLectures;
            //Recalculate();
        }

        //private void Recalculate()
        //{
        //    AvgMark = Math.Round(allmark / (double)students.Count, 2);
        //    AvgMissedLectures = Math.Round(allmissedlectures / (double)students.Count, 2);
        //}

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            //allmark -= student.Mark;
            //allmissedlectures -= student.MissedLectures;
            //Recalculate();
        }


    }
}
