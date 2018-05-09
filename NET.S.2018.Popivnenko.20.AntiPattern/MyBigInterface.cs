using System.Collections.Generic;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    public interface IMyBigInterface
    {
        void AddStudent(Student student);
        void AddInstructor(Instructor instructor);
        void DeleteStudent(string name);
        void DeleteInstructor(string name);

        void Log(string data);
        void SaveData(List<object> list);
        List<object> LoadData();

        void SaveDiscipline(List<Discipline> list);
        List<Discipline> LoadDiscipline();
    }
}
