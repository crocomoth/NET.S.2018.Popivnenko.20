using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2018.Popivnenko._20.AntiPattern;

namespace NET.S._2018.Popivnenko._20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Repository repository = new Repository(Directory.GetCurrentDirectory()+"//test.txt");
            Service service = new Service(repository);

            var student = new Student("stud1","551000","5110000");
            var student2 = new Student("stud2","55100","5110001");

            service.AddStudent(student);
            service.AddStudent(student2);
            service.SaveStudents();

            //-------------------------

            RepositoryViewer repositoryViewer = new RepositoryViewer(Directory.GetCurrentDirectory() + "//test.txt");
            Service service2 = new Service(repositoryViewer);

            var instructor = new Instructor("instr1","0102301");
            var instructor2 = new Instructor("instr2","1231241");

            service2.AddInstructor(instructor);
            service2.AddInstructor(instructor2);
            service2.SaveInstructors();

            Console.ReadLine();
        }
    }
}
