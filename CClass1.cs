// CClass.cs
using System;
using System.Collections.Generic;

namespace Phase1Section5._6
{
    public class CClass
    {
        public string Name { get; set; }
        public Teacher ClassTeacher { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
