using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP
{
    public class Experience : Employee,ISendMail
    {
        public List<string>InformationExperience { get; set; }
        public int Experienceyear { get; set; }
        public List<string> Skills { get; set; }
        public override void GetInformation()
        {
            Console.WriteLine($"Information Experience: {String.Join(", ", InformationExperience)}");
        }
        public void SendRegularMail(string mailFrom, string mailTo, string title, string content, string template)
        {
            Console.WriteLine($"Experience mail: Send regular mail from {mailFrom} to {mailTo}");
        }
        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string content, string template)
        {
            Console.WriteLine($"Experience mail: Send regular mail from {mailFrom} to {mailTo}, cc {mailCC}");
        }
    }
}
