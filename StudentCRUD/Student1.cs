using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    public class Student1
    {

        public int rollNo { get; set; }
        public string name { get; set; }

        public string school { get; set; }
    }

    public class StudentCrud
    {
        private List<Student1> students;

        public StudentCrud()
        {
            students = new List<Student1>();
        }

        public void AddStudent(Student1 stud)
        {
            students.Add(stud);
        }
        public List<Student1> GetStudents()
        {
            return students;
        }

        public void UpdateStudent(Student1 stud)
        {
            foreach (Student1 s1 in students)
            {
                if (s1.rollNo == stud.rollNo)
                {
                    s1.name = stud.name;
                    s1.school = stud.school;
                }
            }
        }

        public void DeleteStudent(int rollNo)
        {
            foreach (Student1 s1 in students)
            {
                if (s1.rollNo == rollNo)
                {
                    students.Remove(s1);
                }
            }
        }
    }
}
