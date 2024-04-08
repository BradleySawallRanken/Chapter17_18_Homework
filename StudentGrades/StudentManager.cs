using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class StudentManager
    {
        public static List<Student> LoadData()
        {
            var studentList = new List<Student>();

            studentList.Add(new Student { Name = "Telreyne", TestGrade = 95, LabGrade = 95 });
            studentList.Add(new Student { Name = "Bando", TestGrade = 100, LabGrade = 85 });
            studentList.Add(new Student { Name = "Klov", TestGrade = 85, LabGrade = 90 });

            return studentList;
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public int TestGrade { get; set; }
        public int LabGrade { get; set; }
    }
}
