using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Klasse, die einen Detaileintrag mit Link auf dem Namen realisiert.
    /// </summary>
    public class TeacherWithDetail : Teacher
    {
        private int _id;

        public TeacherWithDetail(string name, string weekday, string time, string room, string comment, int id) : base(name, weekday, time, room, comment)
        {
            _id = id;
        }
        public override string GetHtmlForName()
        {
            return $"<a href=\"?id=999\">{Name}</a>";
        }
    }
}
