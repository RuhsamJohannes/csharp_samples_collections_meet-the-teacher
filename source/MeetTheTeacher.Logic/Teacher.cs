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
    public class Teacher : IComparable
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
        public string Weekday { get => _weekday; }
        public string Time { get => _time; }
        public string Room { get => _room; }

        public virtual string GetHtmlForName()
        {
            return Name;
        }
        public virtual string GetHtmlForWeekday()
        {
            return Weekday;
        }
        public virtual string GetHtmlForTime()
        {
            return Time;
        }
        public virtual string GetHtmlForRoom()
        {
            return Room;
        }

        public string GetHtmlForTeacher()
        {
            return $"<td align=\"left\">{GetHtmlForName()}</td>\n" +
                   $"<td align=\"left\">{GetHtmlForWeekday()}</td>\n" +
                   $"<td align=\"left\">{GetHtmlForTime()}</td>\n" +
                   $"<td align=\"left\">{GetHtmlForRoom()}</td>\n";
        }

        public int CompareTo(object obj)
        {
            Teacher other = (Teacher)obj;
            return this.Name.CompareTo(other.Name);
        }
    }
}
