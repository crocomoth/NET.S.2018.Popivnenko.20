using System;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    public class Student
    {
        public string Name;

        public string Group;

        public string StudentCardNumber;

        public Student(string name, string group, string studentCardNumber)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Group = group ?? throw new ArgumentNullException(nameof(group));
            StudentCardNumber = studentCardNumber ?? throw new ArgumentNullException(nameof(studentCardNumber));
        }

        public void AddToDiscipline(Discipline discipline)
        {
            discipline.Students.Add(this);
        }
    }
}
