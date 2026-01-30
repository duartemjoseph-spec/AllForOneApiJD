using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneApiJD.Services
{
    public class MadLibService
    {
        public string MadlibChoices(string name, string color, string noun, string adjective)
        {
            return $"There once was a person named {name} who loved the color {color}. One day, {name} saw a {adjective} {noun} and couldn't believe what they saw!";
        }
    }
}