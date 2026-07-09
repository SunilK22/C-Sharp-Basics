using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Tracker
{
    public class InvalidExperienceException : Exception
    {
       public  InvalidExperienceException(string message) : base(message) { }
    }
}
