using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=============================================================================");

            Experience exper = new Experience
            {
                EmpCode = "TonyStark",
                FirstName = "Tony",
                LastName = "Stark",
                InformationExperience = new List<string> { "Experience: 5 years", "Skill: HTML, PSD to HTML" }
            };

            exper.GetFullName();
            exper.GetInformation();
            exper.SendRegularMail("Tony Stark", "HR Department", "Leave request mail", "Leave template", string.Empty);
            exper.SendRegularMail("Tony Stark", "HR Department", "Project manager", "Leave request mail", "Leave template", string.Empty);

            Console.WriteLine("=============================================================================");

            Fresher fresher = new Fresher
            {
                EmpCode = "PeterParker",
                FirstName = "Peter",
                LastName = "Parker",
                InformationFresher = new List<string> { "Graduation time: 2021", "Graduation type: Excellent", "University: Telecommunications Institute of Technology" }
            };

            fresher.GetFullName();
            fresher.GetInformation();
            fresher.SendRegularMail("Peter Parker", "HR Department", "Leave request mail", "Leave template", string.Empty);
            fresher.SendRegularMail("Peter Parker", "HR Department", "Project manager", "Leave request mail", "Leave template", string.Empty);

            Console.WriteLine("=============================================================================");

            Intern intern = new Intern
            {
                EmpCode = "JohnCena",
                FirstName = "John",
                LastName = "Cena",
                InformationInter = new List<string> { "Specialized: Software", "Semester: 4", "University: Telecommunications Institute of Technology" }
            };

            intern.GetFullName();
            intern.GetInformation();
            intern.SendRegularMail("John Cena", "HR Department", "Leave request mail", "Leave template", string.Empty);
            intern.SendRegularMail("John Cena", "HR Department", "Project manager", "Leave request mail", "Leave template", string.Empty);
        }
    }
}
