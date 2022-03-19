using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP
{
    class Intern:Employee,ISendMail
    {
        public List<string> InformationInter { get; set; }
        public override void GetInformation()
        {
            Console.WriteLine($"Information Inter: {String.Join(", ", InformationInter)}");
        }
        public void SendRegularMail(string mailFrom, string mailTo, string title, string content, string template)
        {
            Console.WriteLine($"Inter mail: Send regular mail from {mailFrom} to {mailTo}");
        }
        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string content, string template)
        {
            Console.WriteLine($"Inter mail: Send regular mail from {mailFrom} to {mailTo}, cc {mailCC}");
        }
    }
}
