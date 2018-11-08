using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIteaBack.Models
{
    public class CalendarForGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Lessons> Lessons { get; set; }
    }

    public class Lessons
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public string FIOlector { get; set; }
        public string NameOfLesson { get; set; }
        public int TypeOfLeson { get; set; }
        public bool IsFirst { get; set; }

        public int DayOfWeek { get; set; }
        public int ParaNumber { get; set; }


    }
}
