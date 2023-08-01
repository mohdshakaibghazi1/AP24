using System;
using System.Collections.Generic;

namespace Phase1Section5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };

            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr. RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";

            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;

            // Display information about the subjects
            Console.WriteLine("Subjects:");
            foreach (Subject subject in class1A.Subjects)
            {
                Console.WriteLine($"Name: {subject.Name}, Short Name: {subject.ShortName}");
            }

            // Display information about the students
            Console.WriteLine("\nStudents:");
            foreach (Student student in class1A.Students)
            {
                Console.WriteLine($"Name: {student.Name}, DOB: {student.DateOfBirth}, Address: {student.Address}, Guardian: {student.GuardianName}, Contact: {student.ContactNumber}");
            }

            // Display information about the class teacher
            Console.WriteLine("\nClass Teacher:");
            Console.WriteLine($"Name: {class1A.ClassTeacher.Name}, Date of Joining: {class1A.ClassTeacher.DateOfJoining}, Contact Address: {class1A.ClassTeacher.ContactAddress}");

            // Display information about the class
            Console.WriteLine("\nClass:");
            Console.WriteLine($"Class Name: {class1A.Name}");
        }
    }
}
