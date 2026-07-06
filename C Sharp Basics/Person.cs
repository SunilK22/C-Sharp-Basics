using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp_Basics
{
    internal class Person
    {
        private string _name { get; set; }
        private int _age { get; set; }
        private string _city { get; set; }

        public Person(string name, int age, string city)
        {
            _name = name;
            _age = age;
            _city = city;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {_name}, from {_city} and I'm {_age} years old.");
        }
    }
}
