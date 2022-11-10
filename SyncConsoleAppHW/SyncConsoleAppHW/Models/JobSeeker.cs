using System;
using System.Collections.Generic;
using System.Text;

namespace SyncConsoleAppHW.Models
{
    public class JobSeeker
    {
        public ITskills MyItskills {get; set;}
        public string MyEnglishLanguageSkills { get; set; }

        public JobSeeker(ITskills myItskills, string myEnglishLanguageSkills)
        {
            MyItskills = myItskills;
            MyEnglishLanguageSkills = myEnglishLanguageSkills;
        }
    }
}
