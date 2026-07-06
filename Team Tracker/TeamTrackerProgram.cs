using System;
using Team_Tracker;


class TeamTrackerProgram
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();

        while (true)
        {
            try
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your role: ");
                string role = Console.ReadLine();
                Console.WriteLine("Enter your experience in years: ");
                int exp = Convert.ToInt32(Console.ReadLine());

                Person p = new Person(name, role, exp);
                persons.Add(p);

                Console.WriteLine("Do you want to add more members? (yes/no)");

                string isContinue = Console.ReadLine();

                if (isContinue.ToLower() != "yes")
                {
                    break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: got exception " + ex.Message);
                Console.WriteLine("Please provide valid details");
            }
        }

        foreach (var item in persons)
        {
            item.Introduce();
        }

    }
}