using System;
using System.Collections.Generic;
using System.Text;

namespace HackATL_EEVM.Models
{
    public class Question
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Questionnire { get; set; }

        public string Answer { get; set; }

        public bool IsAnswered { get; set; }
        
    }
}
