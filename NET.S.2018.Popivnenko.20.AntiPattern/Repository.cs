using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    public class Repository : IMyBigInterface
    {
        public string Path;

        public Repository(string path)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void AddStudent(Student student)
        {
            throw new ServiceException("illegal operation");
        }

        public void AddInstructor(Instructor instructor)
        {
            throw new ServiceException("illegal operation");
        }

        public void DeleteStudent(string name)
        {
            throw new ServiceException("illegal operation");
        }

        public void DeleteInstructor(string name)
        {
            throw new ServiceException("llegal operation");
        }

        public void Log(string data)
        {
            Console.WriteLine($"repository does stuff {data}");
        }

        public void SaveDiscipline(List<Discipline> list)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }

            FileStream fileStream = new FileStream(Path, FileMode.Open);

            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, list);
            var bytes = mStream.ToArray();

            fileStream.Write(bytes, 0, bytes.Length);
            mStream.Close();
            fileStream.Close();
        }

        public List<Discipline> LoadDiscipline()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }

            FileStream fileStream = new FileStream(Path, FileMode.Open);

            IFormatter formatter = new BinaryFormatter();
            List<Discipline> data = new List<Discipline>();

            while (fileStream.Position < fileStream.Length)
            {
                Discipline obj = (Discipline)formatter.Deserialize(fileStream);
                data.Add(obj);
            }
            fileStream.Close();
            return data;
        }

        public void SaveData(List<object> list)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }

            FileStream fileStream = new FileStream(Path, FileMode.Open);

            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, list);
            var bytes = mStream.ToArray();

            fileStream.Write(bytes,0,bytes.Length);
            mStream.Close();
            fileStream.Close();

        }

        public List<object> LoadData()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }

            FileStream fileStream = new FileStream(Path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            List<object> data = new List<object>();

            while (fileStream.Position < fileStream.Length)
            {
                object obj = (object)formatter.Deserialize(fileStream);
                data.Add(obj);
            }
            fileStream.Close();
            return data;
        }
    }
}
