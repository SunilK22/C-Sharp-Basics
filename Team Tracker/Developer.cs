using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Tracker
{
    public class Developer: Person, IWorkable
    {
        public string ProgrammingLangauge { get; set; }

        public Developer(string name, string role, int experience, string language): base(name, role, experience)
        {
            ProgrammingLangauge = language;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, My name is {Name}, I'm {Role} having {Experience} yrs of experience in {ProgrammingLangauge} language.");
        }

        public void DoWork()
        {
            Console.WriteLine("As a developer I write code.");
        }
    }
}
