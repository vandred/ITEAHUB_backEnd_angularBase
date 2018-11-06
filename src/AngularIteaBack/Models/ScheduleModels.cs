using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIteaBack.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string NameGroup { get; set; }
        public List<Lessons> Schedule { get; set; }
    }

    public class Lessons
    {
        public int Id { get; set; }
        public int TypeLesson { get; set; }
        public string NameLesson { get; set; }
        public string FIOTeacher { get; set; }
        public int RoomNumber { get; set; }
        public string NumberPrefix { get; set; }
    }
}
