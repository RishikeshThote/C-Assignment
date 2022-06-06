using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
    internal class Program
    {
        public class Student
        {
            public string id;
            public string name;
            public string dob;
            public override string ToString()
            {
                return "'\n'StudentId:" + " " + this.id + "\n " + "Student Name:" + " " + this.name + "\n " + "Student Dob:" + " " + this.dob;
            }



            public Student(string id, string name, string dob)
            {
                this.id = id;
                this.name = name;
                this.dob = dob;
            }
            public Student()
            {



            }



            public void setId(string id)
            {
                this.id = id;
            }
            public string getId()
            {
                return id;
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public string getName()
            {
                return name;
            }
            public void setDob(string dob)
            {
                this.dob = dob;
            }
            public string getDob()
            {
                return dob;
            }
        }
        public class Info
        {
            public static void display(Student student)
            {
                Console.WriteLine($"The student details is student id {student.id}, student name {student.name}, student dob {student.dob}");
            }



        }
        public class App
        {
            public void scenerio1()
            {
                Student student = new Student("121", "Sanket", "17/11/1997");
                Student student1 = new Student("122", "Kunal", "2/05/1998");
                Student student2 = new Student("123", "Jay", "25/08/1999");
                Info.display(student);
                Info.display(student1);
                Info.display(student2);
            }
            public void scenerio2()
            {
                Student[] students = new Student[2];



                students[0] = new Student("221", "Sumit", "25/8/1996");
                students[1] = new Student("222", "Yash", "15/06/2000");
                for (int i = 0; i < students.Length; i++)
                {
                    Info.display(students[i]);
                }
            }



            public void Scenerio3()
            {
                Console.WriteLine("Enter number of students:");
                int n = Convert.ToInt32(Console.ReadLine());
                object[] array = new object[n];
                for (int i = 0; i < n; i++)
                {
                    Student s = new Student();
                    Console.WriteLine("Enter id:");
                    s.id = Console.ReadLine();
                    Console.WriteLine("Enter Name:");
                    s.name = Console.ReadLine();
                    Console.WriteLine("Enter dob");
                    s.dob = Console.ReadLine();
                    array[i] = s;
                }
                foreach (object obj in array)
                {
                    Console.WriteLine("Student Details:- " + obj);
                }
            }



        }
        public class Test
        {
            public static void Main(string[] args)
            {
                do
                {
                    Console.WriteLine("Choose one");
                    Console.WriteLine("1.Scenerio1");
                    Console.WriteLine("2.Scenerio2");
                    Console.WriteLine("3.Scenerio3");
                    Console.WriteLine("4.Exit");
                    int x = Convert.ToInt32(Console.ReadLine());
                    App ap = new App();
                    if (x == 1)
                    {



                        ap.scenerio1();
                    }
                    if (x == 2)
                    {
                        ap.scenerio2();
                    }
                    if (x == 3)
                    {
                        ap.Scenerio3();
                    }
                    if (x == 4)
                    {
                        Environment.Exit(0);
                    }




                } while (true);
            }
        }
    }


}
