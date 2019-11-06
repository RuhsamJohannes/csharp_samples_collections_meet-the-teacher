using System;
using System.Collections.Generic;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltung der Lehrer (mit und ohne Detailinfos)
    /// </summary>
    public class Controller 
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();
        private readonly Dictionary<string, int> _details = new Dictionary<string, int>();

        /// <summary>
        /// Liste für Sprechstunden und Dictionary für Detailseiten anlegen
        /// </summary>
        public Controller(string[] teacherLines, string[] detailsLines)
        {
            InitTeachers(teacherLines);
            InitDetails(detailsLines);
        }

        public int Count => _teachers.Count;

        public int CountTeachersWithoutDetails => Count - CountTeachersWithDetails;


        /// <summary>
        /// Anzahl der Lehrer mit Detailinfos in der Liste
        /// </summary>
        public int CountTeachersWithDetails => _details.Count;

        /// <summary>
        /// Aus dem Text der Sprechstundendatei werden alle Lehrersprechstunden 
        /// eingelesen. Dabei wird für Lehrer, die eine Detailseite haben
        /// ein TeacherWithDetails-Objekt und für andere Lehrer ein Teacher-Objekt angelegt.
        /// </summary>
        /// <returns>Anzahl der eingelesenen Lehrer</returns>
        private void InitTeachers(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(";");

                _teachers.Add(new Teacher(lineSplit[0], lineSplit[1], lineSplit[3], lineSplit[4], lineSplit[5] + lineSplit[6] + lineSplit[7]));
            }
        }


        /// <summary>
        /// Lehrer, deren Name in der Datei IgnoredTeachers steht werden aus der Liste 
        /// entfernt
        /// </summary>
        public void DeleteIgnoredTeachers(string[] names)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                foreach (string name in names)
                {
                    if (string.Equals(name, _teachers[i].Name, StringComparison.OrdinalIgnoreCase))
                    {
                        _teachers.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Sucht Lehrer in Lehrerliste nach dem Namen
        /// </summary>
        /// <param name="teacherName"></param>
        /// <returns>Index oder -1, falls nicht gefunden</returns>
        private int FindIndexForTeacher(string teacherName)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Ids der Detailseiten für Lehrer die eine
        /// derartige Seite haben einlesen.
        /// </summary>
        private void InitDetails(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] lineSplit = line.Split(";");

                _details.Add(lineSplit[0], Convert.ToInt32(lineSplit[1]));
            }
        }

        /// <summary>
        /// HTML-Tabelle der ganzen Lehrer aufbereiten.
        /// </summary>
        /// <returns>Text für die Html-Tabelle</returns>
        public string GetHtmlTable()
        {
            throw new NotImplementedException();
        }

    }
}
