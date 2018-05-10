using System;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    [Serializable]
    public class Instructor
    {
        public string Name;

        public string InstructorCardNumber;

        public Instructor(string name, string instructorCardNumber)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            InstructorCardNumber = instructorCardNumber ?? throw new ArgumentNullException(nameof(instructorCardNumber));
        }

        public void AddToDiscipline(Discipline discipline)
        {
            discipline.Instructors.Add(this);
        }
    }
}
