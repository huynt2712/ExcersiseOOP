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
                InformationExperience = new List<string> (),
                Skills = new List<string> {"HTML","CSS","JavaScript" },
                PhoneNumber ="01231231231",
                Age=20,
                Email="TS@gmail.com",
                Experienceyear=4
            };
            exper.InformationExperience.Add(exper.EmpCode);
            exper.InformationExperience.Add(exper.PhoneNumber);
            exper.InformationExperience.Add(exper.Age.ToString());
            exper.InformationExperience.Add(exper.Email);
            exper.InformationExperience.Add(exper.Experienceyear.ToString());
            exper.InformationExperience.AddRange(exper.Skills);
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
                InformationFresher = new List<string>(),
                Graduationtime =4,
                Graduationtyle="Excellent",
                University= "Posts and Telecommunications Institute of Technology",
                PhoneNumber = "01231231231",
                Age = 20,
                Email = "TS@gmail.com"
            };

            fresher.InformationFresher.Add(fresher.EmpCode);
            fresher.InformationFresher.Add(fresher.Age.ToString());
            fresher.InformationFresher.Add(fresher.Email);
            fresher.InformationFresher.Add(fresher.PhoneNumber);
            fresher.InformationFresher.Add(fresher.Graduationtime.ToString());
            fresher.InformationFresher.Add(fresher.Graduationtyle);
            fresher.InformationFresher.Add(fresher.University);
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
                InformationInter = new List<string>(),
                PhoneNumber = "01231231231",
                Age = 20,
                Email = "TS@gmail.com",
                Specialized="Software",
                Semester=4,
                University= "Posts and Telecommunications Institute of Technology"
            };
            intern.InformationInter.Add(intern.EmpCode);
            intern.InformationInter.Add(intern.Age.ToString());
            intern.InformationInter.Add(intern.Email);
            intern.InformationInter.Add(intern.PhoneNumber);
            intern.InformationInter.Add(intern.Specialized);
            intern.InformationInter.Add(intern.Semester.ToString());
            intern.InformationInter.Add(intern.University);
            intern.GetFullName();
            intern.GetInformation();
            intern.SendRegularMail("John Cena", "HR Department", "Leave request mail", "Leave template", string.Empty);
            intern.SendRegularMail("John Cena", "HR Department", "Project manager", "Leave request mail", "Leave template", string.Empty);
        }
    }
}
