

using System.Net.NetworkInformation;

namespace Team_Tracker
{
    public class Person
    {
        public string Name { get; private set; }
        public string Role { get; set; }
        public int Experience { get; set; }


        public Person(string name, string role, int experience)
        {
            Name = name;
            Role = role;
            Experience = experience;
        }


        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, working as a {Role} and I have {Experience} years of experience.");
        }

        public void GainExperience(int years)
        {
            Experience += years;
        }


    }
}
