using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Tracker
{
    internal class Manager : Person, IWorkable
    {
        public int TeamSize { get; set; }

        public Manager(string name, string role, int experience, int teamSize) : base(name, role, experience)
        {
            TeamSize = teamSize;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"and I manage team of {TeamSize} peoples.");
        }

        public void DoWork()
        {
            Console.WriteLine("As a manager I assign work to team and manage them");
        }
    }
}
