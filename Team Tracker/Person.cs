

namespace Team_Tracker
{
    internal class Person
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Experience { get; set; }


        public Person(string name, string role, int experience)
        {
            Name = name;
            Role = role;
            Experience = experience;
        }


        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, working as a {Role} and I have {Experience} years of experience.");
        }
    }
}
