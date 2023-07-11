using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    
        public class Student
        {
            static void Main(string[] args)
        {
           
                StudentCrud studentCrud = new StudentCrud();
                int option = 0;
                do
                {


                    Console.WriteLine("1. Add Student Details");
                    Console.WriteLine("2. Update Student Details");
                    Console.WriteLine("3. Delete Student Details");
                    Console.WriteLine("4. Display All Student Details");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Student1 student = new Student1();
                            Console.WriteLine("Enter Roll Number");
                            student.rollNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Student name");
                            student.name = Console.ReadLine();
                            Console.WriteLine("Enter school name");
                            student.school = Console.ReadLine();

                            studentCrud.AddStudent(student);

                            break;
                        case 2:
                            Student1 student1 = new Student1();
                            Console.WriteLine("Enter new Roll No ");
                            student1.rollNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Updated Name");
                            student1.name = Console.ReadLine();
                            Console.WriteLine("Enter Updated School name");
                            student1.school = Console.ReadLine();
                            studentCrud.UpdateStudent(student1);
                            break;
                        case 3:
                            Console.WriteLine("Enter roll No. To delete Record");
                            int rollNo = Convert.ToInt32(Console.ReadLine());
                            studentCrud.DeleteStudent(rollNo);
                            break;
                            ;
                        case 4:
                            List<Student1> students = studentCrud.GetStudents();
                            foreach (Student1 s in students)
                            {
                                Console.WriteLine($"{s.rollNo}-{s.name}-{s.school}");
                            }
                            break;
                    }
                    Console.WriteLine("Press 1 to Continue");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                while (option == 1);
            }
    }
}
