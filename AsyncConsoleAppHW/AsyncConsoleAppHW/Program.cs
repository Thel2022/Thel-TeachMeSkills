using AsyncConsoleAppHW.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsoleAppHW
{
    internal class Program
    {
        static async Task Main(string[] args)  // 4000 = 1 month
        {
            PayForCourses();

            var theoryandpracticeTask = TeachMeSkills();

            var myEnglishLanguageSkillsTask = EnglishLanguageSkills();

            await Task.WhenAny(theoryandpracticeTask);

            var graduationprojectTask = TeachMeSkillsGraduation();

            var resumeTask = SendResume();
                                    
            ReadyForNewJob(TeachMeSkillsResult(theoryandpracticeTask, graduationprojectTask), await myEnglishLanguageSkillsTask.ConfigureAwait(false));

            await resumeTask;
        }

        private static async Task <Money> EarnMoneyForCourses()
        {
            Console.WriteLine($"Work days routine");

            var earingMoneyTask = Task.Delay(2000);

            await earingMoneyTask;

            Console.WriteLine($"Salary!");

            var money = new Money(700);

            return money;
        }

        private static async Task Payment(Money money)
        {
            int money1 = money.Amount;
            int payment = 700;

            while (money1 > 0)
            {
                money1 = money1 - payment;
                Console.WriteLine($"Payment done!");
            }

        }

        private static async Task PayForCourses()
        {
            for (int i = 4; i > 0; i--)
            {
                var money = EarnMoneyForCourses();
                Payment(await money);
            }

            Console.WriteLine($"All payments made!");
        }

        private static async Task<string> TeachMeSkills()
        {
            Console.WriteLine($"Study has begun");

            var studyTask = Task.Delay(16000);

            await studyTask;

            string theoryandpractice = "some knowledge in my head";

            Console.WriteLine($"{theoryandpractice}");

            return theoryandpractice;
        }

        private static async Task <string> TeachMeSkillsGraduation()
        {
            Console.WriteLine($"Work on a graduation project");

            var graduationTask = Task.Delay(8000);

            await graduationTask;

            string graduationproject = "graduation project done!";

            Console.WriteLine($"{graduationproject}");

            return graduationproject;
        }

        private static ITskills TeachMeSkillsResult(Task theoryandpractice, Task graduationproject)
        {
            var myITskills = new ITskills(theoryandpractice, graduationproject);

            Console.WriteLine($"New horizons!");

            return myITskills;
        }

        private static async Task <string> EnglishLanguageSkills()
        {
            Console.WriteLine($"Study of language has begun");

            var EnglishTask = Task.Delay(12000);

            await EnglishTask;

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

        private static async Task SendResume()
        {
            Console.WriteLine($"Resume sent");

            var ResumeTask = Task.Delay(20000);

            await ResumeTask;

            Console.WriteLine($"New job!");
        }

    }
}

