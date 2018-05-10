using System;
using System.Collections.Generic;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    [Serializable]
    public class Discipline
    {
        public string Name;

        public List<Instructor> Instructors;

        public List<Student> Students;
    }
}
