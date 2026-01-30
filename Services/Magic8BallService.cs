using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneApiJD.Services
{
    public class Magic8BallService
    {
        private static readonly string[] responses = new[]
        {
            "It is certain.",
            "It is decidedly so.",
            "Without a doubt.",
            "Yes... definitely.",
            "You may rely on it.",
            "As I see it, yes.",
            "Most likely.",
            "Outlook good.",
            "Yes.",
            "Signs point to yes.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Very doubtful."
        };

        public string Ask(string question)
        {
            Random rand = new Random();
            int index = rand.Next(responses.Length);
            return responses[index];
        }
    }
}