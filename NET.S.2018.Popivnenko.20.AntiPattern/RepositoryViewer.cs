using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    public class RepositoryViewer : Repository
    {
        public RepositoryViewer(string path) : base(path)
        {
        }

        public override List<object> LoadData()
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
            foreach (var elem in data)
            {
                Console.WriteLine(elem.ToString());
            }
            return data;
        }

        public override List<Discipline> LoadDiscipline()
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
            foreach (var elem in data)
            {
                Console.WriteLine(elem.Name);   
            }
            return data;
        }

        public override void SaveData(List<object> list)
        {
            foreach (var elem in list)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public override void SaveDiscipline(List<Discipline> list)
        {
            foreach (var elem in list)
            {
                Console.WriteLine(elem.Name);
            }
        }
    }
}
