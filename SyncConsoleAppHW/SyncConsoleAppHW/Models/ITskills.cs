using System;
using System.Collections.Generic;
using System.Text;

namespace SyncConsoleAppHW.Models
{
    public class ITskills
    {
        public string TheoryAndPractice { get; set; }
        public string GraduationProject { get; set; }

        public ITskills(string theoryandpractice, string graduationproject)
        {
            TheoryAndPractice = theoryandpractice;
            GraduationProject = graduationproject;
        }
    }
}
