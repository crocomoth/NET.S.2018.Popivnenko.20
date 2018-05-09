using System;
using System.Collections.Generic;
using System.Linq;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    public class Service : IMyBigInterface
    {
        public List<Student> Students;
        public List<Instructor> Instructors;
        public List<Discipline> Disciplines;
        public Repository Repository;

        public Service()
        {
            Students = new List<Student>();
            Instructors = new List<Instructor>();
            Disciplines = new List<Discipline>();
        }


        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
        }

        public void DeleteStudent(string name)
        {
            var student = Students.First(x => x.Name == name);
            Students.Remove(student);
        }

        public void DeleteInstructor(string name)
        {
            var instructor = Instructors.First(x => x.Name == name);
            Instructors.Remove(instructor);
        }

        public void Log(string data)
        {
            Console.WriteLine(data);
        }

        public void SaveStudents()
        {
            List<object> list = new List<object>();
            foreach (var elem in Students)
            {
                list.Add(elem);
            }

            SaveData(list);
        }

        public void SaveInstructors()
        {
            List<object> list = new List<object>();
            foreach (var elem in Instructors)
            {
                list.Add(elem);
            }

            SaveData(list);
        }

        public void SaveData(List<object> list)
        {
            if (list == null)
            {
                throw new ServiceException("list is null");
            }
            Repository.SaveData(list);
        }

        public List<object> LoadData()
        {
            return Repository.LoadData();
        }

        public void SaveDiscipline(List<Discipline> list)
        {
            if (list == null)
            {
                throw new ServiceException("list is null");
            }

            Repository.SaveDiscipline(list);
        }

        public List<Discipline> LoadDiscipline()
        {
            return Repository.LoadDiscipline();
        }
    }
}
