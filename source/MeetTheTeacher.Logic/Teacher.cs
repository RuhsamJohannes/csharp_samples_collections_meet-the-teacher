using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltet einen Eintrag in der Sprechstundentabelle
    /// Basisklasse für TeacherWithDetail
    /// </summary>
    public class Teacher
    {
        private string _name;
        private string _weekday;
        private string _time;
        private string _room;
        private string _comment;

        public Teacher(string name, string weekday, string time, string room, string comment)
        {
            _name = name;
            _weekday = weekday;
            _room = room;
            _time = time;
            _comment = comment;
        }

        public string Name { get => _name; }

        public virtual string GetHtmlForName()
        {
            return Name;
        }
    }
}
