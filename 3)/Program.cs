using System;
using System.Collections.Generic;
namespace Co
{
    class Program
    {
        public abstract class Student
        {
            
            public Student(string name)
            {
                this.name = name;
                state = "";
            }
            public void Read()
            {
                state += "Read ";
            }
            public void Write()
            {
                state += "Write";
            }
            public void Relax()
            {
                state += "Relax";
            }
            public abstract void Study();
            public string Name
            {
                get => name;
                set => name = value;
            }
            public string State
            {
                get => state;
                set => state = value;
            }
            protected string name;
            protected string state;

        }

        public class GoodStudent:Student
        {
            public GoodStudent(string name) : base(name)
            {
                state += "good";
            }
            public override void Study()
            {
                Read(); Write(); Read(); Write(); Relax();
            }
        }

        public class BadStudent : Student
        {
            public BadStudent(string name) : base(name)
            {
                state += "bad";
            }
            public override void Study()
            {
                Relax(); Relax(); Relax(); Relax(); Relax();
            }
        }

        public class Group
        {
            public Group(string nameGroup) 
            {
                this.nameGroup = nameGroup;
                listStud = new List<Student>();
            }
            public void AddStudent(Student st)
            {
                listStud.Add(st);
            }
            public string GetInfo()
            {
                string line = "";
                foreach (Student x in listStud)
                {
                    line += x.Name +  " ";
                }
                return nameGroup + " " + line;
            }
            public string GetFullInfo()
            {
                string line = "";
                foreach (Student x in listStud)
                {
                    line += x.Name + " - " + x.State + " ";
                }
                return nameGroup + " " + line;
            }
            private string nameGroup;
            private List<Student> listStud;

        }

        static void Main(string[] args)
        {

            BadStudent st1 = new BadStudent("Oleksii");
            BadStudent st2 = new BadStudent("Dima");
            GoodStudent st3 = new GoodStudent("Oleksii");
            List<Student> stt = new List<Student> { st1, st2, st3 };
            Group first = new Group("K-25");
            foreach (Student s in stt)
            {
                first.AddStudent(s);
            }
            Console.WriteLine(first.GetInfo());
            Console.WriteLine(first.GetFullInfo());

        }
    }
}
