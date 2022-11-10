using SyncConsoleAppHW.Models;
using System;
using System.Threading;

namespace SyncConsoleAppHW
{
    internal class Program
    {
        static void Main(string[] args)  // 4000 = 1 month
        {
            PayForCourses();

            string theoryandpractice = TeachMeSkills();
            string graduationproject = TeachMeSkillsGraduation();
            string myEnglishLanguageSkills = EnglishLanguageSkills();

            ReadyForNewJob(TeachMeSkillsResult(theoryandpractice, graduationproject), myEnglishLanguageSkills);

            SendResume();
        }

        private static Money EarnMoneyForCourses()
        {
            Console.WriteLine($"Work days routine");

            Thread.Sleep(2000);

            Console.WriteLine($"Salary!");

            var money = new Money(700);

            return money;
        }

        private static void Payment(Money money)
        {
            int money1 = money.Amount;
            int payment = 700;

            while (money1 > 0)
            {
                money1 = money1 - payment;
                Console.WriteLine($"Payment done!");
                Thread.Sleep(2000);
            }                      
                                    
        }

        private static void PayForCourses()
        {
            for (int i = 4; i > 0; i--)
            {
                var money = EarnMoneyForCourses();
                Payment(money);
            }
            Console.WriteLine($"All payments made!");
        }

        private static string TeachMeSkills()
        {
            Console.WriteLine($"Study has begun");

            Thread.Sleep(16000);

            string theoryandpractice = "some knowledge in my head";

            Console.WriteLine($"{theoryandpractice}");

            return theoryandpractice;
        }

        private static string TeachMeSkillsGraduation()
        {
            Console.WriteLine($"Work on a graduation project");

            Thread.Sleep(8000);

            string graduationproject = "graduation project done!";

            Console.WriteLine($"{graduationproject}");

            return graduationproject;
        }

        private static ITskills TeachMeSkillsResult(string theoryandpractice, string graduationproject)
        {
            var myITskills = new ITskills(theoryandpractice, graduationproject);

            Console.WriteLine($"New horizons!");

            return myITskills;           
        }

        private static string EnglishLanguageSkills()
        {
            Console.WriteLine($"Study of language has begun");

            Thread.Sleep(12000);

            string myEnglishLanguageSkills = "*with a strong accent* My name is Dmitry, I'm from Belarus...";

            Console.WriteLine($"{myEnglishLanguageSkills}");

            return myEnglishLanguageSkills;
        }

        private static JobSeeker ReadyForNewJob(ITskills myITskills, string myEnglishLanguageSkills)
        {
            Console.WriteLine($"Ready for new job!");

            var jobseeker = new JobSeeker(myITskills, myEnglishLanguageSkills);
            return jobseeker;
        }

        private static void SendResume()
        {
            Console.WriteLine($"Resume sent");

            Thread.Sleep(20000);

            Console.WriteLine($"New job!");
        }

    }
}
    

