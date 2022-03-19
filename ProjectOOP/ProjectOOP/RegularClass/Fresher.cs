using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP
{
    class Fresher:Employee,ISendMail
    {
        public List<string> InformationFresher { get; set; }
        public override void GetInformation()
        {
            Console.WriteLine($"Information Fresher: {String.Join(", ", InformationFresher)}");
        }
        public void SendRegularMail(string mailFrom, string mailTo, string title, string content, string template)
        {
            Console.WriteLine($"Fresher mail: Send regular mail from {mailFrom} to {mailTo}");
        }
        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string content, string template)
        {
            Console.WriteLine($"Fresher mail: Send regular mail from {mailFrom} to {mailTo}, cc {mailCC}");
        }
    }
}
