using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsoleAppHW.Models
{
    public class ITskills
    {
        public Task TheoryAndPractice { get; set; }
        public Task GraduationProject { get; set; }

        public ITskills(Task theoryandpractice, Task graduationproject)
        {
            TheoryAndPractice = theoryandpractice;
            GraduationProject = graduationproject;
        }
    }
}
